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
	public class AttachedCollisionObject
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/AttachedCollisionObject";

		// The CollisionObject will be attached with a fixed joint to this link
		public string link_name;

		//This contains the actual shapes and poses for the CollisionObject
		//to be attached to the link
		//If action is remove and no object.id is set, all objects
		//attached to the link indicated by link_name will be removed
		[JsonProperty("object")]
		public CollisionObject object_;

		// The set of links that the attached objects are allowed to touch
		// by default - the link_name is already considered by default
		public List<string> touch_links;

		// If certain links were placed in a particular posture for this object to remain attached
		// (e.g., an end effector closing around an object), the posture necessary for releasing
		// the object is stored here
		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory detach_posture;

		// The weight of the attached object, if known
		public double weight;


		public AttachedCollisionObject()
		{
			link_name = string.Empty;
			object_ = new CollisionObject();
			touch_links = new List<string>();
			detach_posture = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory();
		}
	}
}
