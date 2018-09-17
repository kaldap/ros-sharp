using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RosMsgsGenerator
{
	using Decorator = Func<string, string, string>;
	public class MessageWriter
	{
		public string FullName { get; private set; }
		public string Name { get; private set; }
		public string Package { get; private set; }
		public string Namespace { get; private set; }
		public string Dir { get; private set; }
		public string File { get; private set; }

		private StringBuilder sb = new StringBuilder(10 * 1024);

		public MessageWriter(string msgName)
		{
			var p = msgName.Split('/');
			FullName = msgName;
			Name = p[1];
			Package = p[0];

			var ns = LookupNamespace(Package);
			Namespace = "RosSharp.RosBridgeClient.Messages." + ns;
			Dir = Path.Combine("Messages", ns);
			File = Path.Combine(Dir, Name + ".cs");


			// Header
			sb.AppendLine(License);
			sb.AppendLine();
			sb.AppendLine("using Newtonsoft.Json;");
			sb.AppendLine("using System.Collections.Generic;");
			sb.AppendLine("using RosSharp.RosBridgeClient.Messages.Standard;");
			sb.AppendLine();
			sb.AppendLine("namespace " + Namespace);
			sb.AppendLine("{");
			sb.AppendLine("\tpublic class " + Name);
			sb.AppendLine("\t{");
			sb.AppendLine("\t\t[JsonIgnore]");
			sb.AppendLine("\t\tpublic const string RosMessageName = \"" + FullName + "\";");
			sb.AppendLine();
		}
       
		public void LoadFromMsg(string[] lines)
		{
			var space = new char[] { ' ', '\t' };
			var slash = new char[] { '/' };
			var ctorSB = new StringBuilder(10 * 1024);
                       
			Decorator scalarDec = (t, n) => "\t\tpublic " + t + " " + n + ";";
			Decorator arrayDec = (t, n) => "\t\tpublic " + t + "[] " + n + ";";
			Decorator listDec = (t, n) => "\t\tpublic List<" + t + "> " + n + ";";
			Decorator variableDecorator;

			foreach (var l in lines)
			{
				if (string.IsNullOrWhiteSpace(l)) continue;

				var tl = l.Trim();
				if (tl.StartsWith("#", StringComparison.InvariantCulture))
				{
					// Comment
					sb.AppendLine("\t\t//" + tl.Substring(1)); // ToDo: values
				}
				else
				{
					var p = tl.Split(space, 3, StringSplitOptions.RemoveEmptyEntries);
					bool ctor = false;
					variableDecorator = scalarDec;

					// Array?
					int arr;
					if ((arr = p[0].IndexOf('[')) >= 0)
					{
						string eoa = p[0].Substring(arr + 1);
						eoa = eoa.Substring(0, eoa.IndexOf(']')).Trim();
						p[0] = p[0].Substring(0, arr);
						if (!string.IsNullOrEmpty(eoa))
						{
							arr = int.Parse(eoa);
							variableDecorator = arrayDec;
						}
						else
						{
							arr = 0;
							variableDecorator = listDec;
						}
					}

                    // Trim strings
					p[0] = p[0].Trim();
					p[1] = p[1].Trim();

                    // Package?
					if (p[0].Contains('/'))
					{
						ctor = true;
						var ns = p[0].Split(slash, 2);
						ns[0] = "RosSharp.RosBridgeClient.Messages." + LookupNamespace(ns[0]);
						if (ns[0] != Namespace)
							p[0] = ns[0] + "." + ns[1];
						else
							p[0] = ns[1];
					}
					else // Current package or built-in
					{
						// string not handled since it still be string and also needs construction
						if (p[0] == "int8") p[0] = "sbyte";
						else if (p[0] == "uint8") p[0] = "byte";
						else if (p[0] == "int16") p[0] = "short";
						else if (p[0] == "uint16") p[0] = "ushort";
						else if (p[0] == "int32") p[0] = "int";
						else if (p[0] == "uint32") p[0] = "uint";
						else if (p[0] == "int64") p[0] = "long";
						else if (p[0] == "uint64") p[0] = "ulong";
						else if (p[0] == "float32") p[0] = "float";
						else if (p[0] == "float64") p[0] = "double";
                        
						else if (p[0] == "time") { p[0] = "Time"; ctor = true; }
						else if (p[0] == "duration") { p[0] = "Duration"; ctor = true; }
						else ctor = true;
					}

					// Hacky: correct variables named "object"
					if (p[1] == "object")
					{
						p[1] = p[1] + "_";
						sb.AppendLine("\t\t[JsonProperty(\"object\")]");
						sb.AppendLine(variableDecorator(p[0], p[1]));
					}
					else
						sb.AppendLine(variableDecorator(p[0], p[1]));
					sb.AppendLine();

                    // Needs construction
					if (ctor || arr >= 0)
					{
						string ctorStr = (p[0] == "string") ? "string.Empty" : ("new " + p[0] + "()");

						// Construct array/list containers
						if (arr == 0) // Array of undefined size -> list
						{
							ctorSB.AppendLine("\t\t\t" + p[1] + " = new List<" + p[0] + ">();");
							// List is empty so no element needs construction
						}
						else if (arr > 0) // Fixed size array
						{
							ctorSB.AppendLine("\t\t\t" + p[1] + " = new " + p[0] + "[" + arr + "];");
							if (ctor)
							{
								// Elements need construction
								string thisStr = (p[1] == "i") ? "this." : "";
								ctorSB.AppendLine("\t\t\tfor (int i = 0; i < " + arr + "; i++)");
								ctorSB.AppendLine("\t\t\t\t" + thisStr + p[1] + "[i] = " + ctorStr + ";");
							}
						}
						else if (ctor)
                        {
							// Scalar value need construction
							ctorSB.AppendLine("\t\t\t" + p[1] + " = " + ctorStr + ";");
						}
					}
				}              
			}

            sb.AppendLine();
            sb.AppendLine("\t\tpublic " + Name + "()");
			sb.AppendLine("\t\t{");
			sb.Append(ctorSB.ToString());
			sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");
		}

		public void Save()
		{            
			if (!Directory.Exists(Dir))
				Directory.CreateDirectory(Dir);

			using (StreamWriter sw = new StreamWriter(File))
				sw.Write(sb.ToString());
        }

		#region Standard Package Lookup

		private static Dictionary<string, string> StdPackages;

		static MessageWriter()
		{
			StdPackages = new Dictionary<string, string>();

            // Already in RosSharp
			StdPackages.Add("std_msgs", "Standard");
			StdPackages.Add("sensor_msgs", "Sensor");
			StdPackages.Add("nav_msgs", "Navigation");
			StdPackages.Add("geometry_msgs", "Geometry");

            // To be generated
            StdPackages.Add("actionlib_msgs", "ActionLib");
			StdPackages.Add("controller_manager_msgs", "ControllerManager");
			StdPackages.Add("control_msgs", "Control");
            StdPackages.Add("diagnostic_msgs", "Diagnostic");
            StdPackages.Add("gazebo_msgs", "Gazebo");
            StdPackages.Add("graph_msgs", "Graph");
            StdPackages.Add("household_objects_database_msgs", "HouseholdObjectsDatabase");
            StdPackages.Add("manipulation_msgs", "Manipulation");
            StdPackages.Add("map_msgs", "Map");
            StdPackages.Add("moveit_msgs", "MoveIt");
            StdPackages.Add("object_recognition_msgs", "ObjectRecognition");
            StdPackages.Add("octomap_msgs", "Octomap");
            StdPackages.Add("pcl_msgs", "PCL");
            StdPackages.Add("rosgraph_msgs", "RosGraph");
            StdPackages.Add("shape_msgs", "Shape");
            StdPackages.Add("smach_msgs", "SMACH");
            StdPackages.Add("stereo_msgs", "Stereoscopy");
            StdPackages.Add("tf2_msgs", "TF2");
            StdPackages.Add("trajectory_msgs", "Trajectory");
            StdPackages.Add("visualization_msgs", "Visualization");
		}

		private static string FirstUpper(string s)
		{
			if (string.IsNullOrEmpty(s)) return string.Empty;
			return s[0].ToString().ToUpper() + s.Substring(1);
		}

		public static string LookupNamespace(string pkg)
		{
			string look;
			if (StdPackages.TryGetValue(pkg, out look))
				return look;

			var parts = pkg.Split('_').Select(x => FirstUpper(x));
			return string.Join("_", parts);
		}

		#endregion

		private static string License =
@"/*
© Cutter Systems spol. s r.o., 2018
Author: Petr Kalandra (kalandra@cutter.cz)

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/";
	}
}
