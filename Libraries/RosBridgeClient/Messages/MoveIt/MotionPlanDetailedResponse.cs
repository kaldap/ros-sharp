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
	public class MotionPlanDetailedResponse
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/MotionPlanDetailedResponse";

		// The representation of a solution to a planning problem, including intermediate data
		// The starting state considered for the robot solution path
		public RobotState trajectory_start;

		// The group used for planning (usually the same as in the request)
		public string group_name;

		// Multiple solution paths are reported, each reflecting intermediate steps in the trajectory processing
		// The list of reported trajectories
		public List<RobotTrajectory> trajectory;

		// Description of the reported trajectories (name of processing step)
		public List<string> description;

		// The amount of time spent computing a particular step in motion plan computation
		public List<double> processing_time;

		// Status at the end of this plan
		public MoveItErrorCodes error_code;


		public MotionPlanDetailedResponse()
		{
			trajectory_start = new RobotState();
			group_name = string.Empty;
			trajectory = new List<RobotTrajectory>();
			description = new List<string>();
			processing_time = new List<double>();
			error_code = new MoveItErrorCodes();
		}
	}
}
