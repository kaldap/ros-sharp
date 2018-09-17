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

namespace RosSharp.RosBridgeClient.Messages.MoveIt
{
	public class PositionConstraint
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PositionConstraint";

		// This message contains the definition of a position constraint.
		public Header header;

		// The robot link this constraint refers to
		public string link_name;

		// The offset (in the link frame) for the target point on the link we are planning for
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 target_point_offset;

		// The volume this constraint refers to
		public BoundingVolume constraint_region;

		// A weighting factor for this constraint (denotes relative importance to other constraints. Closer to zero means less important)
		public double weight;


		public PositionConstraint()
		{
			header = new Header();
			link_name = string.Empty;
			target_point_offset = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			constraint_region = new BoundingVolume();
		}
	}
}
