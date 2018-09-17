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
	public class JointConstraint
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/JointConstraint";

		// Constrain the position of a joint to be within a certain bound
		public string joint_name;

		// the bound to be achieved is [position - tolerance_below, position + tolerance_above]
		public double position;

		public double tolerance_above;

		public double tolerance_below;

		// A weighting factor for this constraint (denotes relative importance to other constraints. Closer to zero means less important)
		public double weight;


		public JointConstraint()
		{
			joint_name = string.Empty;
		}
	}
}
