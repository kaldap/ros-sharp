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
	public class ObjectInformation
	{
		[JsonIgnore]
		public const string RosMessageName = "object_recognition_msgs/ObjectInformation";

		//############################################# VISUALIZATION INFO ######################################################
		//################## THIS INFO SHOULD BE OBTAINED INDEPENDENTLY FROM THE CORE, LIKE IN AN RVIZ PLUGIN ###################
		// The human readable name of the object
		public string name;

		// The full mesh of the object: this can be useful for display purposes, augmented reality ... but it can be big
		// Make sure the type is MESH
		public RosSharp.RosBridgeClient.Messages.Shape.Mesh ground_truth_mesh;

		// Sometimes, you only have a cloud in the DB
		// Make sure the type is POINTS
		public RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2 ground_truth_point_cloud;


		public ObjectInformation()
		{
			name = string.Empty;
			ground_truth_mesh = new RosSharp.RosBridgeClient.Messages.Shape.Mesh();
			ground_truth_point_cloud = new RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2();
		}
	}
}
