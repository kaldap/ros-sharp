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
	public class PlanningOptions
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PlanningOptions";

		// The diff to consider for the planning scene (optional)
		public PlanningScene planning_scene_diff;

		// If this flag is set to true, the action
		// returns an executable plan in the response but does not attempt execution
		public bool plan_only;

		// If this flag is set to true, the action of planning &
		// executing is allowed to look around  (move sensors) if
		// it seems that not enough information is available about
		// the environment
		public bool look_around;

		// If this value is positive, the action of planning & executing
		// is allowed to look around for a maximum number of attempts;
		// If the value is left as 0, the default value is used, as set
		// with dynamic_reconfigure
		public int look_around_attempts;

		// If set and if look_around is true, this value is used as
		// the maximum cost allowed for a path to be considered executable.
		// If the cost of a path is higher than this value, more sensing or
		// a new plan needed. If left as 0.0 but look_around is true, then
		// the default value set via dynamic_reconfigure is used
		public double max_safe_execution_cost;

		// If the plan becomes invalidated during execution, it is possible to have
		// that plan recomputed and execution restarted. This flag enables this
		// functionality
		public bool replan;

		// The maximum number of replanning attempts
		public int replan_attempts;

		// The amount of time to wait in between replanning attempts (in seconds)
		public double replan_delay;


		public PlanningOptions()
		{
			planning_scene_diff = new PlanningScene();
			plan_only = new bool();
			look_around = new bool();
			replan = new bool();
		}
	}
}
