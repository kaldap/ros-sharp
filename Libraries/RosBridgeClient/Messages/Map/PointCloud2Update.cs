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

namespace RosSharp.RosBridgeClient.Messages.Map
{
	public class PointCloud2Update
	{
		[JsonIgnore]
		public const string RosMessageName = "map_msgs/PointCloud2Update";

		public uint ADD=0;

		public uint DELETE=1;

		public Header header;

		public uint type;

		public RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2 points;


		public PointCloud2Update()
		{
			header = new Header();
			points = new RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2();
		}
	}
}
