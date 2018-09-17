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
	public class MenuEntry
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/MenuEntry";

		// MenuEntry message.
		// Each InteractiveMarker message has an array of MenuEntry messages.
		// A collection of MenuEntries together describe a
		// menu/submenu/subsubmenu/etc tree, though they are stored in a flat
		// array.  The tree structure is represented by giving each menu entry
		// an ID number and a "parent_id" field.  Top-level entries are the
		// ones with parent_id = 0.  Menu entries are ordered within their
		// level the same way they are ordered in the containing array.  Parent
		// entries must appear before their children.
		// Example:
		// - id = 3
		//   parent_id = 0
		//   title = "fun"
		// - id = 2
		//   parent_id = 0
		//   title = "robot"
		// - id = 4
		//   parent_id = 2
		//   title = "pr2"
		// - id = 5
		//   parent_id = 2
		//   title = "turtle"
		//
		// Gives a menu tree like this:
		//  - fun
		//  - robot
		//    - pr2
		//    - turtle
		// ID is a number for each menu entry.  Must be unique within the
		// control, and should never be 0.
		public uint id;

		// ID of the parent of this menu entry, if it is a submenu.  If this
		// menu entry is a top-level entry, set parent_id to 0.
		public uint parent_id;

		// menu / entry title
		public string title;

		// Arguments to command indicated by command_type (below)
		public string command;

		// Command_type stores the type of response desired when this menu
		// entry is clicked.
		// FEEDBACK: send an InteractiveMarkerFeedback message with menu_entry_id set to this entry's id.
		// ROSRUN: execute "rosrun" with arguments given in the command field (above).
		// ROSLAUNCH: execute "roslaunch" with arguments given in the command field (above).
		public byte FEEDBACK=0;

		public byte ROSRUN=1;

		public byte ROSLAUNCH=2;

		public byte command_type;


		public MenuEntry()
		{
			title = string.Empty;
			command = string.Empty;
		}
	}
}
