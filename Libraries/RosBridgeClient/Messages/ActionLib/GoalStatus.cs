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

namespace RosSharp.RosBridgeClient.Messages.ActionLib
{
	public class GoalStatus
	{
		[JsonIgnore]
		public const string RosMessageName = "actionlib_msgs/GoalStatus";

		public GoalID goal_id;

		public byte status;

		public byte PENDING;

		public byte ACTIVE;

		public byte PREEMPTED;

		//   and has since completed its execution (Terminal State)
		public byte SUCCEEDED;

		public byte ABORTED;

		//    to some failure (Terminal State)
		public byte REJECTED;

		//    because the goal was unattainable or invalid (Terminal State)
		public byte PREEMPTING;

		//    and has not yet completed execution
		public byte RECALLING;

		//    but the action server has not yet confirmed that the goal is canceled
		public byte RECALLED;

		//    and was successfully cancelled (Terminal State)
		public byte LOST;

		//    sent over the wire by an action server
		//Allow for the user to associate a string with GoalStatus for debugging
		public string text;


		public GoalStatus()
		{
			goal_id = new GoalID();
			text = string.Empty;
		}
	}
}
