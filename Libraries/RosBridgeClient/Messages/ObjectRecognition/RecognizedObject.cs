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
	public class RecognizedObject
	{
		[JsonIgnore]
		public const string RosMessageName = "object_recognition_msgs/RecognizedObject";

		//#################################################### HEADER ###########################################################
		// The header frame corresponds to the pose frame, NOT the point_cloud frame.
		public Header header;

		//################################################# OBJECT INFO #########################################################
		// Contains information about the type and the position of a found object
		// Some of those fields might not be filled because the used techniques do not fill them or because the user does not
		// request them
		// The type of the found object
		public ObjectType type;

		//confidence: how sure you are it is that object and not another one.
		// It is between 0 and 1 and the closer to one it is the better
		public float confidence;

		//############################################### OBJECT CLUSTERS #######################################################
		// Sometimes you can extract the 3d points that belong to the object, in the frames of the original sensors
		// (it is an array as you might have several sensors)
		public List<RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2> point_clouds;

		// Sometimes, you can only provide a bounding box/shape, even in 3d
		// This is in the pose frame
		public RosSharp.RosBridgeClient.Messages.Shape.Mesh bounding_mesh;

		// Sometimes, you only have 2d input so you can't really give a pose, you just get a contour, or a box
		// The last point will be linked to the first one automatically
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point> bounding_contours;

		//################################################### POSE INFO #########################################################
		// This is the result that everybody expects : the pose in some frame given with the input. The units are radian/meters
		// as usual
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseWithCovarianceStamped pose;


		public RecognizedObject()
		{
			header = new Header();
			type = new ObjectType();
			point_clouds = new List<RosSharp.RosBridgeClient.Messages.Sensor.PointCloud2>();
			bounding_mesh = new RosSharp.RosBridgeClient.Messages.Shape.Mesh();
			bounding_contours = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point>();
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseWithCovarianceStamped();
		}
	}
}
