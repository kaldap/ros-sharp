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
	public class ProjectedMapInfo
	{
		[JsonIgnore]
		public const string RosMessageName = "map_msgs/ProjectedMapInfo";

		public string frame_id;

		public double x;

		public double y;

		public double width;

		public double height;

		public double min_z;

		public double max_z;


		public ProjectedMapInfo()
		{
			frame_id = string.Empty;
		}
	}
}
