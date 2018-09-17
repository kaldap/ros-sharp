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
	public class ChannelFloat32
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/ChannelFloat32";

		// This message is used by the PointCloud message to hold optional data
		// associated with each point in the cloud. The length of the values
		// array should be the same as the length of the points array in the
		// PointCloud, and each value should be associated with the corresponding
		// point.
		// Channel names in existing practice include:
		//   "u", "v" - row and column (respectively) in the left stereo image.
		//              This is opposite to usual conventions but remains for
		//              historical reasons. The newer PointCloud2 message has no
		//              such problem.
		//   "rgb" - For point clouds produced by color stereo cameras. uint8
		//           (R,G,B) values packed into the least significant 24 bits,
		//           in order.
		//   "intensity" - laser or pixel intensity.
		//   "distance"
		// The channel name should give semantics of the channel (e.g.
		// "intensity" instead of "value").
		public string name;

		// The values array should be 1-1 with the elements of the associated
		// PointCloud.
		public List<float> values;


		public ChannelFloat32()
		{
			name = string.Empty;
			values = new List<float>();
		}
	}
}
