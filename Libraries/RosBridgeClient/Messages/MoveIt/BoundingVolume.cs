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
	public class BoundingVolume
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/BoundingVolume";

		// Define a volume in 3D
		// A set of solid geometric primitives that make up the volume to define (as a union)
		public List<RosSharp.RosBridgeClient.Messages.Shape.SolidPrimitive> primitives;

		// The poses at which the primitives are located
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> primitive_poses;

		// In addition to primitives, meshes can be specified to add to the bounding volume (again, as union)
		public List<RosSharp.RosBridgeClient.Messages.Shape.Mesh> meshes;

		// The poses at which the meshes are located
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> mesh_poses;


		public BoundingVolume()
		{
			primitives = new List<RosSharp.RosBridgeClient.Messages.Shape.SolidPrimitive>();
			primitive_poses = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
			meshes = new List<RosSharp.RosBridgeClient.Messages.Shape.Mesh>();
			mesh_poses = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
		}
	}
}
