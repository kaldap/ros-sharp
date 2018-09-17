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

namespace RosSharp.RosBridgeClient.Messages.RosGraph
{
	public class TopicStatistics
	{
		[JsonIgnore]
		public const string RosMessageName = "rosgraph_msgs/TopicStatistics";

		// name of the topic
		public string topic;

		// node id of the publisher
		public string node_pub;

		// node id of the subscriber
		public string node_sub;

		// the statistics apply to this time window
		public Time window_start;

		public Time window_stop;

		// number of messages delivered during the window
		public int delivered_msgs;

		// numbers of messages dropped during the window
		public int dropped_msgs;

		// traffic during the window, in bytes
		public int traffic;

		// mean/stddev/max period between two messages
		public Duration period_mean;

		public Duration period_stddev;

		public Duration period_max;

		// mean/stddev/max age of the message based on the
		// timestamp in the message header. In case the
		// message does not have a header, it will be 0.
		public Duration stamp_age_mean;

		public Duration stamp_age_stddev;

		public Duration stamp_age_max;


		public TopicStatistics()
		{
			topic = string.Empty;
			node_pub = string.Empty;
			node_sub = string.Empty;
			window_start = new Time();
			window_stop = new Time();
			period_mean = new Duration();
			period_stddev = new Duration();
			period_max = new Duration();
			stamp_age_mean = new Duration();
			stamp_age_stddev = new Duration();
			stamp_age_max = new Duration();
		}
	}
}
