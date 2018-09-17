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
	public class MagneticField
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/MagneticField";

		// Measurement of the Magnetic Field vector at a specific location.
		// If the covariance of the measurement is known, it should be filled in
		// (if all you know is the variance of each measurement, e.g. from the datasheet,
		//just put those along the diagonal)
		// A covariance matrix of all zeros will be interpreted as "covariance unknown",
		// and to use the data a covariance will have to be assumed or gotten from some
		// other source
		public Header header;

		// field was measured
		// frame_id is the location and orientation
		// of the field measurement
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 magnetic_field;

		// field vector in Tesla
		// If your sensor does not output 3 axes,
		// put NaNs in the components not reported.
		public double[] magnetic_field_covariance;

		// 0 is interpreted as variance unknown

		public MagneticField()
		{
			header = new Header();
			magnetic_field = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			magnetic_field_covariance = new double[9];
		}
	}
}
