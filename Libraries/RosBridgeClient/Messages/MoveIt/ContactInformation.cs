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
	public class ContactInformation
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/ContactInformation";

		// Standard ROS header contains information
		// about the frame in which this
		// contact is specified
		public Header header;

		// Position of the contact point
		public RosSharp.RosBridgeClient.Messages.Geometry.Point position;

		// Normal corresponding to the contact point
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 normal;

		// Depth of contact point
		public double depth;

		// Name of the first body that is in contact
		// This could be a link or a namespace that represents a body
		public string contact_body_1;

		public uint body_type_1;

		// Name of the second body that is in contact
		// This could be a link or a namespace that represents a body
		public string contact_body_2;

		public uint body_type_2;

		public uint ROBOT_LINK=0;

		public uint WORLD_OBJECT=1;

		public uint ROBOT_ATTACHED=2;


		public ContactInformation()
		{
			header = new Header();
			position = new RosSharp.RosBridgeClient.Messages.Geometry.Point();
			normal = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			contact_body_1 = string.Empty;
			contact_body_2 = string.Empty;
		}
	}
}
