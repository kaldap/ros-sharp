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

namespace RosSharp.RosBridgeClient.Messages.Diagnostic
{
	public class DiagnosticStatus
	{
		[JsonIgnore]
		public const string RosMessageName = "diagnostic_msgs/DiagnosticStatus";

		// This message holds the status of an individual component of the robot.
		//
		// Possible levels of operations
		public enum Level : byte
		{
			OK = 0,
			WARN = 1,
			ERROR = 2,
			STALE = 3
		}

		public Level level;

		public string name;

		public string message;

		public string hardware_id;

		public List<KeyValue> values;


		public DiagnosticStatus()
		{
            level = new byte();
			name = string.Empty;
			message = string.Empty;
			hardware_id = string.Empty;
			values = new List<KeyValue>();
		}
	}
}
