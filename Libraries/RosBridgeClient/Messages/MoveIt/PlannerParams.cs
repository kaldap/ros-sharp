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

namespace RosSharp.RosBridgeClient.Messages.MoveIt
{
	public class PlannerParams
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/PlannerParams";

		// parameter names (same size as values)
		public List<string> keys;

		// parameter values (same size as keys)
		public List<string> values;

		// parameter description (can be empty)
		public List<string> descriptions;


		public PlannerParams()
		{
			keys = new List<string>();
			values = new List<string>();
			descriptions = new List<string>();
		}
	}
}
