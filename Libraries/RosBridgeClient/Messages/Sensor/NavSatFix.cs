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
	public class NavSatFix
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/NavSatFix";

		// Navigation Satellite fix for any Global Navigation Satellite System
		//
		// Specified using the WGS 84 reference ellipsoid
		// header.stamp specifies the ROS time for this measurement (the
		//        corresponding satellite time may be reported using the
		//        sensor_msgs/TimeReference message).
		//
		// header.frame_id is the frame of reference reported by the satellite
		//        receiver, usually the location of the antenna.  This is a
		//        Euclidean frame relative to the vehicle, not a reference
		//        ellipsoid.
		public Header header;

		// satellite fix status information
		public NavSatStatus status;

		// Latitude [degrees]. Positive is north of equator; negative is south.
		public double latitude;

		// Longitude [degrees]. Positive is east of prime meridian; negative is west.
		public double longitude;

		// Altitude [m]. Positive is above the WGS 84 ellipsoid
		// (quiet NaN if no altitude is available).
		public double altitude;

		// Position covariance [m^2] defined relative to a tangential plane
		// through the reported position. The components are East, North, and
		// Up (ENU), in row-major order.
		//
		// Beware: this coordinate system exhibits singularities at the poles.
		public double[] position_covariance;

		// If the covariance of the fix is known, fill it in completely. If the
		// GPS receiver provides the variance of each measurement, put them
		// along the diagonal. If only Dilution of Precision is available,
		// estimate an approximate covariance from that.
		public byte COVARIANCE_TYPE_UNKNOWN;

		public byte COVARIANCE_TYPE_APPROXIMATED;

		public byte COVARIANCE_TYPE_DIAGONAL_KNOWN;

		public byte COVARIANCE_TYPE_KNOWN;

		public byte position_covariance_type;


		public NavSatFix()
		{
			header = new Header();
			status = new NavSatStatus();
			position_covariance = new double[9];
		}
	}
}
