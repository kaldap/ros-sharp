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

namespace RosSharp.RosBridgeClient.Messages.ObjectRecognition
{
	public class Table
	{
		[JsonIgnore]
		public const string RosMessageName = "object_recognition_msgs/Table";

		// Informs that a planar table has been detected at a given location
		public Header header;

		// The pose gives you the transform that take you to the coordinate system
		// of the table, with the origin somewhere in the table plane and the
		// z axis normal to the plane
		public RosSharp.RosBridgeClient.Messages.Geometry.Pose pose;

		// There is no guarantee that the table does NOT extend further than the
		// convex hull; this is just as far as we've observed it.
		// The origin of the table coordinate system is inside the convex hull
		// Set of points forming the convex hull of the table
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point> convex_hull;


		public Table()
		{
			header = new Header();
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.Pose();
			convex_hull = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point>();
		}
	}
}
