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
	public class MotionPlanResponse
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/MotionPlanResponse";

		// The representation of a solution to a planning problem
		// The corresponding robot state
		public RobotState trajectory_start;

		// The group used for planning (usually the same as in the request)
		public string group_name;

		// A solution trajectory, if found
		public RobotTrajectory trajectory;

		// Planning time (seconds)
		public double planning_time;

		// Error code - encodes the overall reason for failure
		public MoveItErrorCodes error_code;


		public MotionPlanResponse()
		{
			trajectory_start = new RobotState();
			group_name = string.Empty;
			trajectory = new RobotTrajectory();
			error_code = new MoveItErrorCodes();
		}
	}
}
