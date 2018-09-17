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
	public class JointLimits
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/JointLimits";

		// This message contains information about limits of a particular joint (or control dimension)
		public string joint_name;

		// true if the joint has position limits
		public bool has_position_limits;

		// min and max position limits
		public double min_position;

		public double max_position;

		// true if joint has velocity limits
		public bool has_velocity_limits;

		// max velocity limit
		public double max_velocity;

		// min_velocity is assumed to be -max_velocity
		// true if joint has acceleration limits
		public bool has_acceleration_limits;

		// max acceleration limit
		public double max_acceleration;

		// min_acceleration is assumed to be -max_acceleration

		public JointLimits()
		{
			joint_name = string.Empty;
			has_position_limits = new bool();
			has_velocity_limits = new bool();
			has_acceleration_limits = new bool();
		}
	}
}
