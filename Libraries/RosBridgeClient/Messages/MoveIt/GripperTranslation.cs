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
	public class GripperTranslation
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/GripperTranslation";

		// defines a translation for the gripper, used in pickup or place tasks
		// for example for lifting an object off a table or approaching the table for placing
		// the direction of the translation
		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3Stamped direction;

		// the desired translation distance
		public float desired_distance;

		// the min distance that must be considered feasible before the
		// grasp is even attempted
		public float min_distance;


		public GripperTranslation()
		{
			direction = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3Stamped();
		}
	}
}
