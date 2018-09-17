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
	public class RelativeHumidity
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/RelativeHumidity";

		// Single reading from a relative humidity sensor.  Defines the ratio of partial
		// pressure of water vapor to the saturated vapor pressure at a temperature.
		public Header header;

		// frame_id is the location of the humidity sensor
		public double relative_humidity;

		// from 0.0 to 1.0.
		// 0.0 is no partial pressure of water vapor
		// 1.0 represents partial pressure of saturation
		public double variance;


		public RelativeHumidity()
		{
			header = new Header();
		}
	}
}
