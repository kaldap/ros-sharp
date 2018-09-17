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

namespace RosSharp.RosBridgeClient.Messages.ControllerManager
{
	public class ControllerStatistics
	{
		[JsonIgnore]
		public const string RosMessageName = "controller_manager_msgs/ControllerStatistics";

		// This message contains the state of one realtime controller
		// that was spawned in the controller manager
		// the name of the controller
		public string name;

		// the type of the controller
		public string type;

		// the time at which these controller statistics were measured
		public Time timestamp;

		// bool that indicates if the controller is currently
		// in a running or a stopped state
		public bool running;

		// the maximum time the update loop of the controller ever needed to complete
		public Duration max_time;

		// the average time the update loop of the controller needs to complete.
		// the average is computed in a sliding time window.
		public Duration mean_time;

		// the variance on the time the update loop of the controller needs to complete.
		// the variance applies to a sliding time window.
		public Duration variance_time;

		// the number of times this controller broke the realtime loop
		public int num_control_loop_overruns;

		// the timestamp of the last time this controller broke the realtime loop
		public Time time_last_control_loop_overrun;


		public ControllerStatistics()
		{
			name = string.Empty;
			type = string.Empty;
			timestamp = new Time();
			running = new bool();
			max_time = new Duration();
			mean_time = new Duration();
			variance_time = new Duration();
			time_last_control_loop_overrun = new Time();
		}
	}
}
