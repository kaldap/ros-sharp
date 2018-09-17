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

namespace RosSharp.RosBridgeClient.Messages.SMACH
{
	public class SmachContainerStatus
	{
		[JsonIgnore]
		public const string RosMessageName = "smach_msgs/SmachContainerStatus";

		public Header header;

		// The path to this node in the server
		public string path;

		// The initial state description
		// Effects an arc from the top state to each one
		public List<string> initial_states;

		// The current state description
		public List<string> active_states;

		// A pickled user data structure
		// i.e. the UserData's internal dictionary
		public string local_data;

		// Debugging info string
		public string info;


		public SmachContainerStatus()
		{
			header = new Header();
			path = string.Empty;
			initial_states = new List<string>();
			active_states = new List<string>();
			local_data = string.Empty;
			info = string.Empty;
		}
	}
}
