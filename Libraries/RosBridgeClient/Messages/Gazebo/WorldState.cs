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
	public class WorldState
	{
		[JsonIgnore]
		public const string RosMessageName = "gazebo_msgs/WorldState";

		// This is a message that holds data necessary to reconstruct a snapshot of the world
		//
		// = Approach to Message Passing =
		// The state of the world is defined by either
		//   1. Inertial Model pose, twist
		//      * kinematic data - connectivity graph from Model to each Link
		//      * joint angles
		//      * joint velocities
		//      * Applied forces - Body wrench
		//        * relative transform from Body to each collision Geom
		// Or
		//   2. Inertial (absolute) Body pose, twist, wrench
		//      * relative transform from Body to each collision Geom - constant, so not sent over wire
		//      * back compute from canonical body info to get Model pose and twist.
		//
		// Chooing (2.) because it matches most physics engines out there
		//   and is simpler.
		//
		// = Future =
		// Consider impacts on using reduced coordinates / graph (parent/child links) approach
		//   constraint and physics solvers.
		//
		// = Application =
		// This message is used to do the following:
		//   * reconstruct the world and objects for sensor generation
		//   * stop / start simulation - need pose, twist, wrench of each body
		//   * collision detection - need pose of each collision geometry.  velocity/acceleration if
		//
		// = Assumptions =
		// Assuming that each (physics) processor node locally already has
		//   * collision information - Trimesh for Geoms, etc
		//   * relative transforms from Body to Geom - this is assumed to be fixed, do not send oved wire
		//   * inertial information - does not vary in time
		//   * visual information - does not vary in time
		//
		public Header header;

		public List<string> name;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> pose;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Twist> twist;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench> wrench;


		public WorldState()
		{
			header = new Header();
			name = new List<string>();
			pose = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
			twist = new List<RosSharp.RosBridgeClient.Messages.Geometry.Twist>();
			wrench = new List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench>();
		}
	}
}
