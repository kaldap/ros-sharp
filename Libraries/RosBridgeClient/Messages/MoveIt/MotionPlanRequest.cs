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
	public class MotionPlanRequest
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/MotionPlanRequest";

		// This service contains the definition for a request to the motion
		// planner and the output it provides
		// Parameters for the workspace that the planner should work inside
		public WorkspaceParameters workspace_parameters;

		// Starting state updates. If certain joints should be considered
		// at positions other than the current ones, these positions should
		// be set here
		public RobotState start_state;

		// The possible goal states for the model to plan for. Each element of
		// the array defines a goal region. The goal is achieved
		// if the constraints for a particular region are satisfied
		public List<Constraints> goal_constraints;

		// No state at any point along the path in the produced motion plan will violate these constraints (this applies to all points, not just waypoints)
		public Constraints path_constraints;

		// The constraints the resulting trajectory must satisfy
		public TrajectoryConstraints trajectory_constraints;

		// The name of the motion planner to use. If no name is specified,
		// a default motion planner will be used
		public string planner_id;

		// The name of the group of joints on which this planner is operating
		public string group_name;

		// The number of times this plan is to be computed. Shortest solution
		// will be reported.
		public int num_planning_attempts;

		// The maximum amount of time the motion planner is allowed to plan for (in seconds)
		public double allowed_planning_time;

		// Scaling factors for optionally reducing the maximum joint velocities and
		// accelerations.  Allowed values are in (0,1].  The maximum joint velocity and
		// acceleration specified in the robot model are multiplied by thier respective
		// factors.  If either are outside their valid ranges (importantly, this
		// includes being set to 0.0), the factor is set to the default value of 1.0
		// internally (i.e., maximum joint velocity or maximum joint acceleration).
		public double max_velocity_scaling_factor;

		public double max_acceleration_scaling_factor;


		public MotionPlanRequest()
		{
			workspace_parameters = new WorkspaceParameters();
			start_state = new RobotState();
			goal_constraints = new List<Constraints>();
			path_constraints = new Constraints();
			trajectory_constraints = new TrajectoryConstraints();
			planner_id = string.Empty;
			group_name = string.Empty;
		}
	}
}
