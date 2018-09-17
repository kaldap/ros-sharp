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
	public class ManipulationResult
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/ManipulationResult";

		// Result codes for manipulation tasks
		// task completed as expected
		// generally means you can proceed as planned
		public int SUCCESS;

		// task not possible (e.g. out of reach or obstacles in the way)
		// generally means that the world was not disturbed, so you can try another task
		public int UNFEASIBLE;

		// task was thought possible, but failed due to unexpected events during execution
		// it is likely that the world was disturbed, so you are encouraged to refresh
		// your sensed world model before proceeding to another task
		public int FAILED;

		// a lower level error prevented task completion (e.g. joint controller not responding)
		// generally requires human attention
		public int ERROR;

		// means that at some point during execution we ended up in a state that the collision-aware
		// arm navigation module will not move out of. The world was likely not disturbed, but you
		// probably need a new collision map to move the arm out of the stuck position
		public int ARM_MOVEMENT_PREVENTED;

		// specific to grasp actions
		// the object was grasped successfully, but the lift attempt could not achieve the minimum lift distance requested
		// it is likely that the collision environment will see collisions between the hand/object and the support surface
		public int LIFT_FAILED;

		// specific to place actions
		// the object was placed successfully, but the retreat attempt could not achieve the minimum retreat distance requested
		// it is likely that the collision environment will see collisions between the hand and the object
		public int RETREAT_FAILED;

		// indicates that somewhere along the line a human said "wait, stop, this is bad, go back and do something else"
		public int CANCELLED;

		// the actual value of this error code
		public int value;


		public ManipulationResult()
		{
		}
	}
}
