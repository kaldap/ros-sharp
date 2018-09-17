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

namespace RosSharp.RosBridgeClient.Messages.Geometry
{
	public class AccelWithCovariance
	{
		[JsonIgnore]
		public const string RosMessageName = "geometry_msgs/AccelWithCovariance";

		// This expresses acceleration in free space with uncertainty.
		public Accel accel;

		// Row-major representation of the 6x6 covariance matrix
		// The orientation parameters use a fixed-axis representation.
		// In order, the parameters are:
		// (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
		public double[] covariance;


		public AccelWithCovariance()
		{
			accel = new Accel();
			covariance = new double[36];
		}
	}
}
