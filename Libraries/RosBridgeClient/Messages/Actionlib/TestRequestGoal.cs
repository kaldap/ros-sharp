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

namespace RosSharp.RosBridgeClient.Messages.Actionlib
{
	public class TestRequestGoal
	{
		[JsonIgnore]
		public const string RosMessageName = "actionlib/TestRequestGoal";

		// ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
		public int TERMINATE_SUCCESS;

		public int TERMINATE_ABORTED;

		public int TERMINATE_REJECTED;

		public int TERMINATE_LOSE;

		public int TERMINATE_DROP;

		public int TERMINATE_EXCEPTION;

		public int terminate_status;

		public bool ignore_cancel;

		public string result_text;

		public int the_result;

		public bool is_simple_client;

		public Duration delay_accept;

		public Duration delay_terminate;

		public Duration pause_status;


		public TestRequestGoal()
		{
			ignore_cancel = new bool();
			result_text = string.Empty;
			is_simple_client = new bool();
			delay_accept = new Duration();
			delay_terminate = new Duration();
			pause_status = new Duration();
		}
	}
}
