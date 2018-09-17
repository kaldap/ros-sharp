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

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
	public class TimeReference
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/TimeReference";

		// Measurement from an external time source not actively synchronized with the system clock.
		public Header header;

		// frame_id is not used
		public Time time_ref;

		public string source;


		public TimeReference()
		{
			header = new Header();
			time_ref = new Time();
			source = string.Empty;
		}
	}
}
