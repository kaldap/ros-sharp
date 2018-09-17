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
	public class Illuminance
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/Illuminance";

		// Single photometric illuminance measurement.  Light should be assumed to be
		// measured along the sensor's x-axis (the area of detection is the y-z plane).
		// The illuminance should have a 0 or positive value and be received with
		// the sensor's +X axis pointing toward the light source.
		// Photometric illuminance is the measure of the human eye's sensitivity of the
		// intensity of light encountering or passing through a surface.
		// All other Photometric and Radiometric measurements should
		// not use this message.
		// This message cannot represent:
		// Luminous intensity (candela/light source output)
		// Luminance (nits/light output per area)
		// Irradiance (watt/area), etc.
		public Header header;

		// frame_id is the location and direction of the reading
		public double illuminance;

		public double variance;


		public Illuminance()
		{
			header = new Header();
		}
	}
}
