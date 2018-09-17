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
	public class SmachContainerStructure
	{
		[JsonIgnore]
		public const string RosMessageName = "smach_msgs/SmachContainerStructure";

		public Header header;

		// The path to this node in the server
		public string path;

		// The children of this node
		public List<string> children;

		// The outcome edges
		// Each index across these arrays denote one edge
		public List<string> internal_outcomes;

		public List<string> outcomes_from;

		public List<string> outcomes_to;

		// The potential outcomes from this container
		public List<string> container_outcomes;


		public SmachContainerStructure()
		{
			header = new Header();
			path = string.Empty;
			children = new List<string>();
			internal_outcomes = new List<string>();
			outcomes_from = new List<string>();
			outcomes_to = new List<string>();
			container_outcomes = new List<string>();
		}
	}
}
