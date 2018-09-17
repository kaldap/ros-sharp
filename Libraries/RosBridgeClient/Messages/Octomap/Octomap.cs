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

namespace RosSharp.RosBridgeClient.Messages.Octomap
{
	public class Octomap
	{
		[JsonIgnore]
		public const string RosMessageName = "octomap_msgs/Octomap";

		// A 3D map in binary format, as Octree
		public Header header;

		// Flag to denote a binary (only free/occupied) or full occupancy octree (.bt/.ot file)
		public bool binary;

		// Class id of the contained octree
		public string id;

		// Resolution (in m) of the smallest octree nodes
		public double resolution;

		// binary serialization of octree, use conversions.h to read and write octrees
		public List<sbyte> data;


		public Octomap()
		{
			header = new Header();
			binary = new bool();
			id = string.Empty;
			data = new List<sbyte>();
		}
	}
}
