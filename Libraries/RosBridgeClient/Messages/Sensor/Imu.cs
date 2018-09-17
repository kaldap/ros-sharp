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
	public class Imu
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/Imu";

		// This is a message to hold data from an IMU (Inertial Measurement Unit)
		//
		// Accelerations should be in m/s^2 (not in g's), and rotational velocity should be in rad/sec
		//
		// If the covariance of the measurement is known, it should be filled in (if all you know is the
		// variance of each measurement, e.g. from the datasheet, just put those along the diagonal)
		// A covariance matrix of all zeros will be interpreted as "covariance unknown", and to use the
		// data a covariance will have to be assumed or gotten from some other source
		//
		// If you have no estimate for one of the data elements (e.g. your IMU doesn't produce an orientation
		// estimate), please set element 0 of the associated covariance matrix to -1
		// If you are interpreting this message, please check for a value of -1 in the first element of each
		// covariance matrix, and disregard the associated estimate.
		public Header header;

		public RosSharp.RosBridgeClient.Messages.Geometry.Quaternion orientation;

		public double[] orientation_covariance;

		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 angular_velocity;

		public double[] angular_velocity_covariance;

		public RosSharp.RosBridgeClient.Messages.Geometry.Vector3 linear_acceleration;

		public double[] linear_acceleration_covariance;


		public Imu()
		{
			header = new Header();
			orientation = new RosSharp.RosBridgeClient.Messages.Geometry.Quaternion();
			orientation_covariance = new double[9];
			angular_velocity = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			angular_velocity_covariance = new double[9];
			linear_acceleration = new RosSharp.RosBridgeClient.Messages.Geometry.Vector3();
			linear_acceleration_covariance = new double[9];
		}
	}
}
