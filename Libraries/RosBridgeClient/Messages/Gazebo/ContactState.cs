/*
© Cutter Systems spol. s r.o., 2018
Author: Petr Kalandra (kalandra@cutter.cz)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Newtonsoft.Json;
using System.Collections.Generic;
using RosSharp.RosBridgeClient.Messages.Standard;

namespace RosSharp.RosBridgeClient.Messages.Gazebo
{
	public class ContactState
	{
		[JsonIgnore]
		public const string RosMessageName = "gazebo_msgs/ContactState";

		public string info;

		public string collision1_name;

		public string collision2_name;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench> wrenches;

		public RosSharp.RosBridgeClient.Messages.Geometry.Wrench total_wrench;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Vector3> contact_positions;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Vector3> contact_normals;

		public List<double> depths;


		public ContactState()
		{
			info = string.Empty;
			collision1_name = string.Empty;
			collision2_name = string.Empty;
			wrenches = new List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench>();
			total_wrench = new RosSharp.RosBridgeClient.Messages.Geometry.Wrench();
			contact_positions = new List<RosSharp.RosBridgeClient.Messages.Geometry.Vector3>();
			contact_normals = new List<RosSharp.RosBridgeClient.Messages.Geometry.Vector3>();
			depths = new List<double>();
		}
	}
}
