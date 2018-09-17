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
	public class InteractiveMarkerUpdate
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/InteractiveMarkerUpdate";

		// Identifying string. Must be unique in the topic namespace
		// that this server works on.
		public string server_id;

		// Sequence number.
		// The client will use this to detect if it has missed an update.
		public ulong seq_num;

		// Type holds the purpose of this message.  It must be one of UPDATE or KEEP_ALIVE.
		// UPDATE: Incremental update to previous state.
		//         The sequence number must be 1 higher than for
		//         the previous update.
		// KEEP_ALIVE: Indicates the that the server is still living.
		//             The sequence number does not increase.
		//             No payload data should be filled out (markers, poses, or erases).
		public byte KEEP_ALIVE;

		public byte UPDATE;

		public byte type;

		//Note: No guarantees on the order of processing.
		//      Contents must be kept consistent by sender.
		//Markers to be added or updated
		public List<InteractiveMarker> markers;

		//Poses of markers that should be moved
		public List<InteractiveMarkerPose> poses;

		//Names of markers to be erased
		public List<string> erases;


		public InteractiveMarkerUpdate()
		{
			server_id = string.Empty;
			markers = new List<InteractiveMarker>();
			poses = new List<InteractiveMarkerPose>();
			erases = new List<string>();
		}
	}
}
