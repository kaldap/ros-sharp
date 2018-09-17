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
	public class KinematicSolverInfo
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/KinematicSolverInfo";

		// A list of joints in the kinematic tree
		public List<string> joint_names;

		// A list of joint limits corresponding to the joint names
		public List<JointLimits> limits;

		// A list of links that the kinematics node provides solutions for
		public List<string> link_names;


		public KinematicSolverInfo()
		{
			joint_names = new List<string>();
			limits = new List<JointLimits>();
			link_names = new List<string>();
		}
	}
}
