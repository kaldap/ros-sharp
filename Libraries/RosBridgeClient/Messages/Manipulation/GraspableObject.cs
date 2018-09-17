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

namespace RosSharp.RosBridgeClient.Messages.Manipulation
{
	public class GraspableObject
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/GraspableObject";

		// an object that the object_manipulator can work on
		// a graspable object can be represented in multiple ways. This message
		// can contain all of them. Which one is actually used is up to the receiver
		// of this message. When adding new representations, one must be careful that
		// they have reasonable lightweight defaults indicating that that particular
		// representation is not available.
		// the tf frame to be used as a reference frame when combining information from
		// the different representations below
		public string reference_frame_id;

		// potential recognition results from a database of models
		// all poses are relative to the object reference pose
		public List<RosSharp.RosBridgeClient.Messages.HouseholdObjectsDatabase.DatabaseModelPose> potential_models;

		// the point cloud itself
		public RosSharp.RosBridgeClient.Messages.Sensor.PointCloud cluster;

		// a region of a PointCloud2 of interest
		public SceneRegion region;

		// the name that this object has in the collision environment
		public string collision_name;


		public GraspableObject()
		{
			reference_frame_id = string.Empty;
			potential_models = new List<RosSharp.RosBridgeClient.Messages.HouseholdObjectsDatabase.DatabaseModelPose>();
			cluster = new RosSharp.RosBridgeClient.Messages.Sensor.PointCloud();
			region = new SceneRegion();
			collision_name = string.Empty;
		}
	}
}
