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
	public class InteractiveMarkerControl
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/InteractiveMarkerControl";

		// Represents a control that is to be displayed together with an interactive marker
		// Identifying string for this control.
		// You need to assign a unique value to this to receive feedback from the GUI
		// on what actions the user performs on this control (e.g. a button click).
		public string name;

		// Defines the local coordinate frame (relative to the pose of the parent
		// interactive marker) in which is being rotated and translated.
		// Default: Identity
		public RosSharp.RosBridgeClient.Messages.Geometry.Quaternion orientation;

		// Orientation mode: controls how orientation changes.
		// INHERIT: Follow orientation of interactive marker
		// FIXED: Keep orientation fixed at initial state
		// VIEW_FACING: Align y-z plane with screen (x: forward, y:left, z:up).
		public byte INHERIT;

		public byte FIXED;

		public byte VIEW_FACING;

		public byte orientation_mode;

		// Interaction mode for this control
		//
		// NONE: This control is only meant for visualization; no context menu.
		// MENU: Like NONE, but right-click menu is active.
		// BUTTON: Element can be left-clicked.
		// MOVE_AXIS: Translate along local x-axis.
		// MOVE_PLANE: Translate in local y-z plane.
		// ROTATE_AXIS: Rotate around local x-axis.
		// MOVE_ROTATE: Combines MOVE_PLANE and ROTATE_AXIS.
		public byte NONE;

		public byte MENU;

		public byte BUTTON;

		public byte MOVE_AXIS;

		public byte MOVE_PLANE;

		public byte ROTATE_AXIS;

		public byte MOVE_ROTATE;

		// "3D" interaction modes work with the mouse+SHIFT+CTRL or with 3D cursors.
		// MOVE_3D: Translate freely in 3D space.
		// ROTATE_3D: Rotate freely in 3D space about the origin of parent frame.
		// MOVE_ROTATE_3D: Full 6-DOF freedom of translation and rotation about the cursor origin.
		public byte MOVE_3D;

		public byte ROTATE_3D;

		public byte MOVE_ROTATE_3D;

		public byte interaction_mode;

		// If true, the contained markers will also be visible
		// when the gui is not in interactive mode.
		public bool always_visible;

		// Markers to be displayed as custom visual representation.
		// Leave this empty to use the default control handles.
		//
		// Note:
		// - The markers can be defined in an arbitrary coordinate frame,
		//   but will be transformed into the local frame of the interactive marker.
		// - If the header of a marker is empty, its pose will be interpreted as
		//   relative to the pose of the parent interactive marker.
		public List<Marker> markers;

		// In VIEW_FACING mode, set this to true if you don't want the markers
		// to be aligned with the camera view point. The markers will show up
		// as in INHERIT mode.
		public bool independent_marker_orientation;

		// Short description (< 40 characters) of what this control does,
		// e.g. "Move the robot".
		// Default: A generic description based on the interaction mode
		public string description;


		public InteractiveMarkerControl()
		{
			name = string.Empty;
			orientation = new RosSharp.RosBridgeClient.Messages.Geometry.Quaternion();
			always_visible = new bool();
			markers = new List<Marker>();
			independent_marker_orientation = new bool();
			description = string.Empty;
		}
	}
}
