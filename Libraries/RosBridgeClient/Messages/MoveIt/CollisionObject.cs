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
	public class CollisionObject
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/CollisionObject";

		// a header, used for interpreting the poses
		public Header header;

		// the id of the object (name used in MoveIt)
		public string id;

		// The object type in a database of known objects
		public RosSharp.RosBridgeClient.Messages.ObjectRecognition.ObjectType type;

		// the the collision geometries associated with the object;
		// their poses are with respect to the specified header
		// solid geometric primitives
		public List<RosSharp.RosBridgeClient.Messages.Shape.SolidPrimitive> primitives;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> primitive_poses;

		// meshes
		public List<RosSharp.RosBridgeClient.Messages.Shape.Mesh> meshes;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> mesh_poses;

		// bounding planes (equation is specified, but the plane can be oriented using an additional pose)
		public List<RosSharp.RosBridgeClient.Messages.Shape.Plane> planes;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Pose> plane_poses;

		public enum Operation : byte
		{
			// Adds the object to the planning scene. If the object previously existed, it is replaced.
			ADD = 0,

			// Removes the object from the environment entirely (everything that matches the specified id)
			REMOVE = 1,

			// Append to an object that already exists in the planning scene. If the does not exist, it is added.
			APPEND = 2,

			// If an object already exists in the scene, new poses can be sent (the geometry arrays must be left empty)
			// if solely moving the object is desired
			MOVE = 3
		}

		// Operation to be performed
		public Operation operation;


		public CollisionObject()
		{
			header = new Header();
			id = string.Empty;
			type = new RosSharp.RosBridgeClient.Messages.ObjectRecognition.ObjectType();
			primitives = new List<RosSharp.RosBridgeClient.Messages.Shape.SolidPrimitive>();
			primitive_poses = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
			meshes = new List<RosSharp.RosBridgeClient.Messages.Shape.Mesh>();
			mesh_poses = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
			planes = new List<RosSharp.RosBridgeClient.Messages.Shape.Plane>();
			plane_poses = new List<RosSharp.RosBridgeClient.Messages.Geometry.Pose>();
			operation = new byte();
		}
	}
}
