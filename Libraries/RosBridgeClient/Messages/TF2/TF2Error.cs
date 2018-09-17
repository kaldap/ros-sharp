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

namespace RosSharp.RosBridgeClient.Messages.TF2
{
	public class TF2Error
	{
		[JsonIgnore]
		public const string RosMessageName = "tf2_msgs/TF2Error";

		public byte NO_ERROR;

		public byte LOOKUP_ERROR;

		public byte CONNECTIVITY_ERROR;

		public byte EXTRAPOLATION_ERROR;

		public byte INVALID_ARGUMENT_ERROR;

		public byte TIMEOUT_ERROR;

		public byte TRANSFORM_ERROR;

		public byte error;

		public string error_string;


		public TF2Error()
		{
			error_string = string.Empty;
		}
	}
}
