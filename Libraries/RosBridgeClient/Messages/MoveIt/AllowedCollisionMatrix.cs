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
	public class AllowedCollisionMatrix
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/AllowedCollisionMatrix";

		// The list of entry names in the matrix
		public List<string> entry_names;

		// The individual entries in the allowed collision matrix
		// square, symmetric, with same order as entry_names
		public List<AllowedCollisionEntry> entry_values;

		// In addition to the collision matrix itself, we also have
		// the default entry value for each entry name.
		// If the allowed collision flag is queried for a pair of names (n1, n2)
		// that is not found in the collision matrix itself, the value of
		// the collision flag is considered to be that of the entry (n1 or n2)
		// specified in the list below. If both n1 and n2 are found in the list
		// of defaults, the result is computed with an AND operation
		public List<string> default_entry_names;

		public List<bool> default_entry_values;


		public AllowedCollisionMatrix()
		{
			entry_names = new List<string>();
			entry_values = new List<AllowedCollisionEntry>();
			default_entry_names = new List<string>();
			default_entry_values = new List<bool>();
		}
	}
}
