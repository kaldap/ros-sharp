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
	public class MultiEchoLaserScan
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/MultiEchoLaserScan";

		// Single scan from a multi-echo planar laser range-finder
		//
		// If you have another ranging device with different behavior (e.g. a sonar
		// array), please find or create a different message, since applications
		// will make fairly laser-specific assumptions about this data
		public Header header;

		// the first ray in the scan.
		//
		// in frame frame_id, angles are measured around
		// the positive Z axis (counterclockwise, if Z is up)
		// with zero angle being forward along the x axis
		public float angle_min;

		public float angle_max;

		public float angle_increment;

		public float time_increment;

		// is moving, this will be used in interpolating position
		// of 3d points
		public float scan_time;

		public float range_min;

		public float range_max;

		public List<LaserEcho> ranges;

		// +Inf measurements are out of range
		// -Inf measurements are too close to determine exact distance.
		public List<LaserEcho> intensities;

		// device does not provide intensities, please leave
		// the array empty.

		public MultiEchoLaserScan()
		{
			header = new Header();
			ranges = new List<LaserEcho>();
			intensities = new List<LaserEcho>();
		}
	}
}
