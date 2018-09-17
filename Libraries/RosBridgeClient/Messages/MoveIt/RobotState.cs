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
	public class RobotState
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/RobotState";

		// This message contains information about the robot state, i.e. the positions of its joints and links
		public RosSharp.RosBridgeClient.Messages.Sensor.JointState joint_state;

		// Joints that may have multiple DOF are specified here
		public RosSharp.RosBridgeClient.Messages.Sensor.MultiDOFJointState multi_dof_joint_state;

		// Attached collision objects (attached to some link on the robot)
		public List<AttachedCollisionObject> attached_collision_objects;

		// Flag indicating whether this scene is to be interpreted as a diff with respect to some other scene
		// This is mostly important for handling the attached bodies (whether or not to clear the attached bodies
		// of a moveit::core::RobotState before updating it with this message)
		public bool is_diff;


		public RobotState()
		{
			joint_state = new RosSharp.RosBridgeClient.Messages.Sensor.JointState();
			multi_dof_joint_state = new RosSharp.RosBridgeClient.Messages.Sensor.MultiDOFJointState();
			attached_collision_objects = new List<AttachedCollisionObject>();
			is_diff = new bool();
		}
	}
}
