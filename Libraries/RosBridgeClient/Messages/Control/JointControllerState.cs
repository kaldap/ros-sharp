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
	public class JointControllerState
	{
		[JsonIgnore]
		public const string RosMessageName = "control_msgs/JointControllerState";

		public Header header;

		public double set_point;

		public double process_value;

		public double process_value_dot;

		public double error;

		public double time_step;

		public double command;

		public double p;

		public double i;

		public double d;

		public double i_clamp;

		public bool antiwindup;


		public JointControllerState()
		{
			header = new Header();
			antiwindup = new bool();
		}
	}
}
