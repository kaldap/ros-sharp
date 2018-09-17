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

namespace RosSharp.RosBridgeClient.Messages.Control
{
	public class JointTrajectoryControllerState
	{
		[JsonIgnore]
		public const string RosMessageName = "control_msgs/JointTrajectoryControllerState";

		public Header header;

		public List<string> joint_names;

		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint desired;

		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint actual;

		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint error;


		public JointTrajectoryControllerState()
		{
			header = new Header();
			joint_names = new List<string>();
			desired = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint();
			actual = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint();
			error = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectoryPoint();
		}
	}
}
