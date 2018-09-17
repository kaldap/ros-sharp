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

namespace RosSharp.RosBridgeClient.Messages.Gazebo
{
	public class ODEJointProperties
	{
		[JsonIgnore]
		public const string RosMessageName = "gazebo_msgs/ODEJointProperties";

		// access to low level joint properties, change these at your own risk
		public List<double> damping;

		public List<double> hiStop;

		public List<double> loStop;

		public List<double> erp;

		public List<double> cfm;

		public List<double> stop_erp;

		public List<double> stop_cfm;

		public List<double> fudge_factor;

		public List<double> fmax;

		public List<double> vel;


		public ODEJointProperties()
		{
			damping = new List<double>();
			hiStop = new List<double>();
			loStop = new List<double>();
			erp = new List<double>();
			cfm = new List<double>();
			stop_erp = new List<double>();
			stop_cfm = new List<double>();
			fudge_factor = new List<double>();
			fmax = new List<double>();
			vel = new List<double>();
		}
	}
}
