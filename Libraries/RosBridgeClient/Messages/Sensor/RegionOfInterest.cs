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
	public class RegionOfInterest
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/RegionOfInterest";

		// This message is used to specify a region of interest within an image.
		//
		// When used to specify the ROI setting of the camera when the image was
		// taken, the height and width fields should either match the height and
		// width fields for the associated image; or height = width = 0
		// indicates that the full resolution image was captured.
		public uint x_offset;

		// (0 if the ROI includes the left edge of the image)
		public uint y_offset;

		// (0 if the ROI includes the top edge of the image)
		public uint height;

		public uint width;

		// True if a distinct rectified ROI should be calculated from the "raw"
		// ROI in this message. Typically this should be False if the full image
		// is captured (ROI not used), and True if a subwindow is captured (ROI
		// used).
		public bool do_rectify;


		public RegionOfInterest()
		{
			do_rectify = new bool();
		}
	}
}
