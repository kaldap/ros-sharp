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

namespace RosSharp.RosBridgeClient.Messages.Dynamic_Reconfigure
{
	public class ParamDescription
	{
		[JsonIgnore]
		public const string RosMessageName = "dynamic_reconfigure/ParamDescription";

		public string name;

		public string type;

		public uint level;

		public string description;

		public string edit_method;


		public ParamDescription()
		{
			name = string.Empty;
			type = string.Empty;
			description = string.Empty;
			edit_method = string.Empty;
		}
	}
}
