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
	public class Inertia
	{
		[JsonIgnore]
		public const string RosMessageName = "geometry_msgs/Inertia";

		// Mass [kg]
		public double m;

		// Center of mass [m]
		public Vector3 com;

		// Inertia Tensor [kg-m^2]
		//     | ixx ixy ixz |
		// I = | ixy iyy iyz |
		//     | ixz iyz izz |
		public double ixx;

		public double ixy;

		public double ixz;

		public double iyy;

		public double iyz;

		public double izz;


		public Inertia()
		{
			com = new Vector3();
		}
	}
}
