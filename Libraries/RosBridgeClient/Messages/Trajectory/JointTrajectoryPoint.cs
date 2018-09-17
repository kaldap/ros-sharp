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

namespace RosSharp.RosBridgeClient.Messages.Trajectory
{
	public class JointTrajectoryPoint
	{
		[JsonIgnore]
		public const string RosMessageName = "trajectory_msgs/JointTrajectoryPoint";

		// Each trajectory point specifies either positions[, velocities[, accelerations]]
		// or positions[, effort] for the trajectory to be executed.
		// All specified values are in the same order as the joint names in JointTrajectory.msg
		public List<double> positions;

		public List<double> velocities;

		public List<double> accelerations;

		public List<double> effort;

		public Duration time_from_start;


		public JointTrajectoryPoint()
		{
			positions = new List<double>();
			velocities = new List<double>();
			accelerations = new List<double>();
			effort = new List<double>();
			time_from_start = new Duration();
		}
	}
}
