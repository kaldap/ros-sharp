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

namespace RosSharp.RosBridgeClient.Messages.Visualization
{
	public class Marker
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/Marker";

		// See http://www.ros.org/wiki/rviz/DisplayTypes/Marker and http://www.ros.org/wiki/rviz/Tutorials/Markers%3A%20Basic%20Shapes for more information on using this message with rviz
		public byte ARROW=0;

		public byte CUBE=1;

		public byte SPHERE=2;

		public byte CYLINDER=3;

		public byte LINE_STRIP=4;

		public byte LINE_LIST=5;

		public byte CUBE_LIST=6;

		public byte SPHERE_LIST=7;

		public byte POINTS=8;

		public byte TEXT_VIEW_FACING=9;

		public byte MESH_RESOURCE=10;

		public byte TRIANGLE_LIST=11;

		public byte ADD=0;

		public byte MODIFY=0;

		public byte DELETE=2;

		public byte DELETEALL=3;

		public Header header;

		public string ns;

		public int id;

		public int type;

		public int action;

		public RosSharp.RosBridgeClient.Messages.Geometry.Pose pose;

		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 scale;

		public RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA color;

		public Duration lifetime;

		public bool frame_locked;

		//Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, ...)
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point> points;

		//Only used if the type specified has some use for them (eg. POINTS, LINE_STRIP, ...)
		//number of colors must either be 0 or equal to the number of points
		//NOTE: alpha is not yet used
		public List<RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA> colors;

		// NOTE: only used for text markers
		public string text;

		// NOTE: only used for MESH_RESOURCE markers
		public string mesh_resource;

		public bool mesh_use_embedded_materials;


		public Marker()
		{
			header = new Header();
			ns = string.Empty;
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.Pose();
			scale = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			color = new RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA();
			lifetime = new Duration();
			frame_locked = new bool();
			points = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point>();
			colors = new List<RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA>();
			text = string.Empty;
			mesh_resource = string.Empty;
			mesh_use_embedded_materials = new bool();
		}
	}
}
