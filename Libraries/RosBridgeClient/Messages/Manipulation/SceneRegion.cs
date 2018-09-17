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
	public class SceneRegion
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/SceneRegion";

		// Point cloud
		public RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2 cloud;

		// Indices for the region of interest
		public List<int> mask;

		// One of the corresponding 2D images, if applicable
		public RosSharp.RosBridgeClient.Messages.Sensor.Image image;

		// The disparity image, if applicable
		public RosSharp.RosBridgeClient.Messages.Sensor.Image disparity_image;

		// Camera info for the camera that took the image
		public RosSharp.RosBridgeClient.Messages.Sensor.CameraInfo cam_info;

		// a 3D region of interest for grasp planning
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped roi_box_pose;

		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 roi_box_dims;


		public SceneRegion()
		{
			cloud = new RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2();
			mask = new List<int>();
			image = new RosSharp.RosBridgeClient.Messages.Sensor.Image();
			disparity_image = new RosSharp.RosBridgeClient.Messages.Sensor.Image();
			cam_info = new RosSharp.RosBridgeClient.Messages.Sensor.CameraInfo();
			roi_box_pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			roi_box_dims = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
		}
	}
}
