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
	public class DisplayTrajectory
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/DisplayTrajectory";

		// The model id for which this path has been generated
		public string model_id;

		// The representation of the path contains position values for all the joints that are moving along the path; a sequence of trajectories may be specified
		public List<RobotTrajectory> trajectory;

		// The robot state is used to obtain positions for all/some of the joints of the robot.
		// It is used by the path display node to determine the positions of the joints that are not specified in the joint path message above.
		// If the robot state message contains joint position information for joints that are also mentioned in the joint path message, the positions in the joint path message will overwrite the positions specified in the robot state message.
		public RobotState trajectory_start;


		public DisplayTrajectory()
		{
			model_id = string.Empty;
			trajectory = new List<RobotTrajectory>();
			trajectory_start = new RobotState();
		}
	}
}
