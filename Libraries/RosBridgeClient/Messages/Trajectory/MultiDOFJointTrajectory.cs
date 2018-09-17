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
	public class MultiDOFJointTrajectory
	{
		[JsonIgnore]
		public const string RosMessageName = "trajectory_msgs/MultiDOFJointTrajectory";

		// The header is used to specify the coordinate frame and the reference time for the trajectory durations
		public Header header;

		// A representation of a multi-dof joint trajectory (each point is a transformation)
		// Each point along the trajectory will include an array of positions/velocities/accelerations
		// that has the same length as the array of joint names, and has the same order of joints as
		// the joint names array.
		public List<string> joint_names;

		public List<MultiDOFJointTrajectoryPoint> points;


		public MultiDOFJointTrajectory()
		{
			header = new Header();
			joint_names = new List<string>();
			points = new List<MultiDOFJointTrajectoryPoint>();
		}
	}
}
