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
	public class PlanningSceneComponents
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PlanningSceneComponents";

		// This message defines the components that make up the PlanningScene message.
		// The values can be used as a bitfield to specify which parts of the PlanningScene message
		// are of interest
		// Scene name, model name, model root
		public uint SCENE_SETTINGS=1;

		// Joint values of the robot state
		public uint ROBOT_STATE=2;

		// Attached objects (including geometry) for the robot state
		public uint ROBOT_STATE_ATTACHED_OBJECTS=4;

		// The names of the world objects
		public uint WORLD_OBJECT_NAMES=8;

		// The geometry of the world objects
		public uint WORLD_OBJECT_GEOMETRY=16;

		// The maintained octomap
		public uint OCTOMAP=32;

		// The maintained list of transforms
		public uint TRANSFORMS=64;

		// The allowed collision matrix
		public uint ALLOWED_COLLISION_MATRIX=128;

		// The default link padding and link scaling
		public uint LINK_PADDING_AND_SCALING=256;

		// The stored object colors
		public uint OBJECT_COLORS=512;

		// Bitfield combining options indicated above
		public uint components;


		public PlanningSceneComponents()
		{
		}
	}
}
