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

namespace RosSharp.RosBridgeClient.Messages.Bond
{
	public class Constants
	{
		[JsonIgnore]
		public const string RosMessageName = "bond/Constants";

		public float DEAD_PUBLISH_PERIOD;

		public float DEFAULT_CONNECT_TIMEOUT;

		public float DEFAULT_HEARTBEAT_TIMEOUT;

		public float DEFAULT_DISCONNECT_TIMEOUT;

		public float DEFAULT_HEARTBEAT_PERIOD;

		public string DISABLE_HEARTBEAT_TIMEOUT_PARAM=/bond_disable_heartbeat_timeout;


		public Constants()
		{
			DISABLE_HEARTBEAT_TIMEOUT_PARAM=/bond_disable_heartbeat_timeout = string.Empty;
		}
	}
}
