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
	public class ImageMarker
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/ImageMarker";

		public byte CIRCLE=0;

		public byte LINE_STRIP=1;

		public byte LINE_LIST=2;

		public byte POLYGON=3;

		public byte POINTS=4;

		public byte ADD=0;

		public byte REMOVE=1;

		public Header header;

		public string ns;

		public int id;

		public int type;

		public int action;

		public RosSharp.RosBridgeClient.Messages.Geometry.Point position;

		public float scale;

		public RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA outline_color;

		public byte filled;

		public RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA fill_color;

		public Duration lifetime;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point> points;

		public List<RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA> outline_colors;


		public ImageMarker()
		{
			header = new Header();
			ns = string.Empty;
			position = new RosSharp.RosBridgeClient.Messages.Geometry.Point();
			outline_color = new RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA();
			fill_color = new RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA();
			lifetime = new Duration();
			points = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point>();
			outline_colors = new List<RosSharp.RosBridgeClient.Messages.Standard.ColorRGBA>();
		}
	}
}
