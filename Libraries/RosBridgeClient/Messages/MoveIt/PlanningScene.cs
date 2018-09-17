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
	public class PlanningScene
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PlanningScene";

		// name of planning scene
		public string name;

		// full robot state
		public RobotState robot_state;

		// The name of the robot model this scene is for
		public string robot_model_name;

		//additional frames for duplicating tf (with respect to the planning frame)
		public List<RosSharp.RosBridgeClient.Messages.Geometry.TransformStamped> fixed_frame_transforms;

		//full allowed collision matrix
		public AllowedCollisionMatrix allowed_collision_matrix;

		// all link paddings
		public List<LinkPadding> link_padding;

		// all link scales
		public List<LinkScale> link_scale;

		// Attached objects, collision objects, even the octomap or collision map can have
		// colors associated to them. This array specifies them.
		public List<ObjectColor> object_colors;

		// the collision map
		public PlanningSceneWorld world;

		// Flag indicating whether this scene is to be interpreted as a diff with respect to some other scene
		public bool is_diff;


		public PlanningScene()
		{
			name = string.Empty;
			robot_state = new RobotState();
			robot_model_name = string.Empty;
			fixed_frame_transforms = new List<RosSharp.RosBridgeClient.Messages.Geometry.TransformStamped>();
			allowed_collision_matrix = new AllowedCollisionMatrix();
			link_padding = new List<LinkPadding>();
			link_scale = new List<LinkScale>();
			object_colors = new List<ObjectColor>();
			world = new PlanningSceneWorld();
			is_diff = new bool();
		}
	}
}
