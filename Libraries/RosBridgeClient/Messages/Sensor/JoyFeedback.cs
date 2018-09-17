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
	public class JoyFeedback
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/JoyFeedback";

		// Declare of the type of feedback
		public byte TYPE_LED;

		public byte TYPE_RUMBLE;

		public byte TYPE_BUZZER;

		public byte type;

		// This will hold an id number for each type of each feedback.
		// Example, the first led would be id=0, the second would be id=1
		public byte id;

		// Intensity of the feedback, from 0.0 to 1.0, inclusive.  If device is
		// actually binary, driver should treat 0<=x<0.5 as off, 0.5<=x<=1 as on.
		public float intensity;


		public JoyFeedback()
		{
		}
	}
}
