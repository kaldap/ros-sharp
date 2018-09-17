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
	public class InteractiveMarkerFeedback
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/InteractiveMarkerFeedback";

		// Time/frame info.
		public Header header;

		// Identifying string. Must be unique in the topic namespace.
		public string client_id;

		// Feedback message sent back from the GUI, e.g.
		// when the status of an interactive marker was modified by the user.
		// Specifies which interactive marker and control this message refers to
		public string marker_name;

		public string control_name;

		// Type of the event
		// KEEP_ALIVE: sent while dragging to keep up control of the marker
		// MENU_SELECT: a menu entry has been selected
		// BUTTON_CLICK: a button control has been clicked
		// POSE_UPDATE: the pose has been changed using one of the controls
		public byte KEEP_ALIVE;

		public byte POSE_UPDATE;

		public byte MENU_SELECT;

		public byte BUTTON_CLICK;

		public byte MOUSE_DOWN;

		public byte MOUSE_UP;

		public byte event_type;

		// Current pose of the marker
		// Note: Has to be valid for all feedback types.
		public RosSharp.RosBridgeClient.Messages.Geometry.Pose pose;

		// Contains the ID of the selected menu entry
		// Only valid for MENU_SELECT events.
		public uint menu_entry_id;

		// If event_type is BUTTON_CLICK, MOUSE_DOWN, or MOUSE_UP, mouse_point
		// may contain the 3 dimensional position of the event on the
		// control.  If it does, mouse_point_valid will be true.  mouse_point
		// will be relative to the frame listed in the header.
		public RosSharp.RosBridgeClient.Messages.Geometry.Point mouse_point;

		public bool mouse_point_valid;


		public InteractiveMarkerFeedback()
		{
			header = new Header();
			client_id = string.Empty;
			marker_name = string.Empty;
			control_name = string.Empty;
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.Pose();
			mouse_point = new RosSharp.RosBridgeClient.Messages.Geometry.Point();
			mouse_point_valid = new bool();
		}
	}
}
