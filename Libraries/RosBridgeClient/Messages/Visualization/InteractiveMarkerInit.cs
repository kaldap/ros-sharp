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
	public class InteractiveMarkerInit
	{
		[JsonIgnore]
		public const string RosMessageName = "visualization_msgs/InteractiveMarkerInit";

		// Identifying string. Must be unique in the topic namespace
		// that this server works on.
		public string server_id;

		// Sequence number.
		// The client will use this to detect if it has missed a subsequent
		// update.  Every update message will have the same sequence number as
		// an init message.  Clients will likely want to unsubscribe from the
		// init topic after a successful initialization to avoid receiving
		// duplicate data.
		public ulong seq_num;

		// All markers.
		public List<InteractiveMarker> markers;


		public InteractiveMarkerInit()
		{
			server_id = string.Empty;
			markers = new List<InteractiveMarker>();
		}
	}
}
