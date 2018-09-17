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

namespace RosSharp.RosBridgeClient.Messages.Manipulation
{
	public class GraspResult
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/GraspResult";

		public int SUCCESS;

		public int GRASP_OUT_OF_REACH;

		public int GRASP_IN_COLLISION;

		public int GRASP_UNFEASIBLE;

		public int PREGRASP_OUT_OF_REACH;

		public int PREGRASP_IN_COLLISION;

		public int PREGRASP_UNFEASIBLE;

		public int LIFT_OUT_OF_REACH;

		public int LIFT_IN_COLLISION;

		public int LIFT_UNFEASIBLE;

		public int MOVE_ARM_FAILED;

		public int GRASP_FAILED;

		public int LIFT_FAILED;

		public int RETREAT_FAILED;

		public int result_code;

		// whether the state of the world was disturbed by this attempt. generally, this flag
		// shows if another task can be attempted, or a new sensed world model is recommeded
		// before proceeding
		public bool continuation_possible;


		public GraspResult()
		{
			continuation_possible = new bool();
		}
	}
}
