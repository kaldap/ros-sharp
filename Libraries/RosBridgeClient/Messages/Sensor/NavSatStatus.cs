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

namespace RosSharp.RosBridgeClient.Messages.Sensor
{
	public class NavSatStatus
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/NavSatStatus";

		// Navigation Satellite fix status for any Global Navigation Satellite System
		// Whether to output an augmented fix is determined by both the fix
		// type and the last time differential corrections were received.  A
		// fix is valid when status >= STATUS_FIX.
		public sbyte STATUS_NO_FIX;

		public sbyte STATUS_FIX;

		public sbyte STATUS_SBAS_FIX;

		public sbyte STATUS_GBAS_FIX;

		public sbyte status;

		// Bits defining which Global Navigation Satellite System signals were
		// used by the receiver.
		public ushort SERVICE_GPS;

		public ushort SERVICE_GLONASS;

		public ushort SERVICE_COMPASS;

		public ushort SERVICE_GALILEO;

		public ushort service;


		public NavSatStatus()
		{
		}
	}
}
