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

namespace RosSharp.RosBridgeClient.Messages.Geometry
{
	public class TransformStamped
	{
		[JsonIgnore]
		public const string RosMessageName = "geometry_msgs/TransformStamped";

		// This expresses a transform from coordinate frame header.frame_id
		// to the coordinate frame child_frame_id
		//
		// This message is mostly used by the
		// <a href="http://wiki.ros.org/tf">tf</a> package.
		// See its documentation for more information.
		public Header header;

		public string child_frame_id;

		public Transform transform;


		public TransformStamped()
		{
			header = new Header();
			child_frame_id = string.Empty;
			transform = new Transform();
		}
	}
}
