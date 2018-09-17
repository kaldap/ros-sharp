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
	public class JointTolerance
	{
		[JsonIgnore]
		public const string RosMessageName = "control_msgs/JointTolerance";

		// The tolerances specify the amount the position, velocity, and
		// accelerations can vary from the setpoints.  For example, in the case
		// of trajectory control, when the actual position varies beyond
		// (desired position + position tolerance), the trajectory goal may
		// abort.
		//
		// There are two special values for tolerances:
		//  * 0 - The tolerance is unspecified and will remain at whatever the default is
		//  * -1 - The tolerance is "erased".  If there was a default, the joint will be
		//         allowed to move without restriction.
		public string name;

		public double position;

		public double velocity;

		public double acceleration;


		public JointTolerance()
		{
			name = string.Empty;
		}
	}
}
