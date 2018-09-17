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
	public class PointCloud
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/PointCloud";

		// This message holds a collection of 3d points, plus optional additional
		// information about each point.
		// Time of sensor data acquisition, coordinate frame ID.
		public Header header;

		// Array of 3d points. Each Point32 should be interpreted as a 3d point
		// in the frame given in the header.
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point32> points;

		// Each channel should have the same number of elements as points array,
		// and the data in each channel should correspond 1:1 with each point.
		// Channel names in common practice are listed in ChannelFloat32.msg.
		public List<ChannelFloat32> channels;


		public PointCloud()
		{
			header = new Header();
			points = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point32>();
			channels = new List<ChannelFloat32>();
		}
	}
}
