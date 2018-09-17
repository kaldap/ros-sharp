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
	public class Range
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/Range";

		// Single range reading from an active ranger that emits energy and reports
		// one range reading that is valid along an arc at the distance measured.
		// This message is  not appropriate for laser scanners. See the LaserScan
		// message if you are working with a laser scanner.
		// This message also can represent a fixed-distance (binary) ranger.  This
		// sensor will have min_range===max_range===distance of detection.
		// These sensors follow REP 117 and will output -Inf if the object is detected
		// and +Inf if the object is outside of the detection range.
		public Header header;

		// returned the distance reading
		// Radiation type enums
		// If you want a value added to this list, send an email to the ros-users list
		public byte ULTRASOUND=0;

		public byte INFRARED=1;

		public byte radiation_type;

		// (sound, IR, etc) [enum]
		public float field_of_view;

		// valid for [rad]
		// the object causing the range reading may have
		// been anywhere within -field_of_view/2 and
		// field_of_view/2 at the measured range.
		// 0 angle corresponds to the x-axis of the sensor.
		public float min_range;

		public float max_range;

		// Fixed distance rangers require min_range==max_range
		public float range;

		// (Note: values < range_min or > range_max
		// should be discarded)
		// Fixed distance rangers only output -Inf or +Inf.
		// -Inf represents a detection within fixed distance.
		// (Detection too close to the sensor to quantify)
		// +Inf represents no detection within the fixed distance.
		// (Object out of range)

		public Range()
		{
			header = new Header();
		}
	}
}
