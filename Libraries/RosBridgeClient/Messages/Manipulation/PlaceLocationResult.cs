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
	public class PlaceLocationResult
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/PlaceLocationResult";

		public int SUCCESS;

		public int PLACE_OUT_OF_REACH;

		public int PLACE_IN_COLLISION;

		public int PLACE_UNFEASIBLE;

		public int PREPLACE_OUT_OF_REACH;

		public int PREPLACE_IN_COLLISION;

		public int PREPLACE_UNFEASIBLE;

		public int RETREAT_OUT_OF_REACH;

		public int RETREAT_IN_COLLISION;

		public int RETREAT_UNFEASIBLE;

		public int MOVE_ARM_FAILED;

		public int PLACE_FAILED;

		public int RETREAT_FAILED;

		public int result_code;

		// whether the state of the world was disturbed by this attempt. generally, this flag
		// shows if another task can be attempted, or a new sensed world model is recommeded
		// before proceeding
		public bool continuation_possible;


		public PlaceLocationResult()
		{
			continuation_possible = new bool();
		}
	}
}
