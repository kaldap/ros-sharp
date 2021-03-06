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
	public class OctomapWithPose
	{
		[JsonIgnore]
		public const string RosMessageName = "octomap_msgs/OctomapWithPose";

		// A 3D map in binary format, as Octree
		public Header header;

		// The pose of the octree with respect to the header frame
		public RosSharp.RosBridgeClient.Messages.Geometry.Pose origin;

		// The actual octree msg
		public Octomap octomap;


		public OctomapWithPose()
		{
			header = new Header();
			origin = new RosSharp.RosBridgeClient.Messages.Geometry.Pose();
			octomap = new Octomap();
		}
	}
}
