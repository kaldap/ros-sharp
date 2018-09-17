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
	public class MoveItErrorCodes
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/MoveItErrorCodes";

		public int val;

		// overall behavior
		public int SUCCESS=1;

		public int FAILURE=99999;

		public int PLANNING_FAILED=-1;

		public int INVALID_MOTION_PLAN=-2;

		public int MOTION_PLAN_INVALIDATED_BY_ENVIRONMENT_CHANGE=-3;

		public int CONTROL_FAILED=-4;

		public int UNABLE_TO_AQUIRE_SENSOR_DATA=-5;

		public int TIMED_OUT=-6;

		public int PREEMPTED=-7;

		// planning & kinematics request errors
		public int START_STATE_IN_COLLISION=-10;

		public int START_STATE_VIOLATES_PATH_CONSTRAINTS=-11;

		public int GOAL_IN_COLLISION=-12;

		public int GOAL_VIOLATES_PATH_CONSTRAINTS=-13;

		public int GOAL_CONSTRAINTS_VIOLATED=-14;

		public int INVALID_GROUP_NAME=-15;

		public int INVALID_GOAL_CONSTRAINTS=-16;

		public int INVALID_ROBOT_STATE=-17;

		public int INVALID_LINK_NAME=-18;

		public int INVALID_OBJECT_NAME=-19;

		// system errors
		public int FRAME_TRANSFORM_FAILURE=-21;

		public int COLLISION_CHECKING_UNAVAILABLE=-22;

		public int ROBOT_STATE_STALE=-23;

		public int SENSOR_INFO_STALE=-24;

		// kinematics errors
		public int NO_IK_SOLUTION=-31;


		public MoveItErrorCodes()
		{
		}
	}
}
