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
	public class PlanningSceneWorld
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PlanningSceneWorld";

		// collision objects
		public List<CollisionObject> collision_objects;

		// The octomap that represents additional collision data
		public RosSharp.RosBridgeClient.Messages.Octomap.OctomapWithPose octomap;


		public PlanningSceneWorld()
		{
			collision_objects = new List<CollisionObject>();
			octomap = new RosSharp.RosBridgeClient.Messages.Octomap.OctomapWithPose();
		}
	}
}
