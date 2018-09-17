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

namespace RosSharp.RosBridgeClient.Messages.MoveIt
{
	public class WorkspaceParameters
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/WorkspaceParameters";

		// This message contains a set of parameters useful in
		// setting up the volume (a box) in which the robot is allowed to move.
		// This is useful only when planning for mobile parts of
		// the robot as well.
		// Define the frame of reference for the box corners
		public Header header;

		// The minumum corner of the box, with respect to the robot starting pose
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 min_corner;

		// The maximum corner of the box, with respect to the robot starting pose
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 max_corner;


		public WorkspaceParameters()
		{
			header = new Header();
			min_corner = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			max_corner = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
		}
	}
}
