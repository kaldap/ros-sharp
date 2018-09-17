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
	public class OrientationConstraint
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/OrientationConstraint";

		// This message contains the definition of an orientation constraint.
		public Header header;

		// The desired orientation of the robot link specified as a quaternion
		public RosSharp.RosBridgeClient.Messages.Geometry.Quaternion orientation;

		// The robot link this constraint refers to
		public string link_name;

		// optional axis-angle error tolerances specified
		public double absolute_x_axis_tolerance;

		public double absolute_y_axis_tolerance;

		public double absolute_z_axis_tolerance;

		// A weighting factor for this constraint (denotes relative importance to other constraints. Closer to zero means less important)
		public double weight;


		public OrientationConstraint()
		{
			header = new Header();
			orientation = new RosSharp.RosBridgeClient.Messages.Geometry.Quaternion();
			link_name = string.Empty;
		}
	}
}
