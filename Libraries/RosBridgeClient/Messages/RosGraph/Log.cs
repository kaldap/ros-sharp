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
using System;
using System.Collections.Generic;
using RosSharp.RosBridgeClient.Messages.Standard;

namespace RosSharp.RosBridgeClient.Messages.RosGraph
{
	public class Log
	{
		[JsonIgnore]
		public const string RosMessageName = "rosgraph_msgs/Log";

		//#
		//# Severity level constants
		//#
		[Flags]
		public enum SecurityLevel : byte
		{
		    DEBUG = 1,
		    INFO = 2,
		    WARN = 4,
		    ERROR = 8,
		    FATAL = 16
	    }

		//#
		//# Fields
		//#
		public Header header;

		public SecurityLevel level;

		public string name;

		public string msg;

		public string file;

		public string function;

		public uint line;

		public List<string> topics;


		public Log()
		{
            header = new Header();
			level = new byte();
			name = string.Empty;
			msg = string.Empty;
			file = string.Empty;
			function = string.Empty;
			topics = new List<string>();
		}
	}
}
