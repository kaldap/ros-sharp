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

namespace RosSharp.RosBridgeClient.Messages.Standard
{
	public class MultiArrayLayout
	{
		[JsonIgnore]
		public const string RosMessageName = "std_msgs/MultiArrayLayout";

		// The multiarray declares a generic multi-dimensional array of a
		// particular data type.  Dimensions are ordered from outer most
		// to inner most.
		public List<MultiArrayDimension> dim;

		public uint data_offset;

		// Accessors should ALWAYS be written in terms of dimension stride
		// and specified outer-most dimension first.
		//
		// multiarray(i,j,k) = data[data_offset + dim_stride[1]*i + dim_stride[2]*j + k]
		//
		// A standard, 3-channel 640x480 image with interleaved color channels
		// would be specified as:
		//
		// dim[0].label  = "height"
		// dim[0].size   = 480
		// dim[0].stride = 3*640*480 = 921600  (note dim[0] stride is just size of image)
		// dim[1].label  = "width"
		// dim[1].size   = 640
		// dim[1].stride = 3*640 = 1920
		// dim[2].label  = "channel"
		// dim[2].size   = 3
		// dim[2].stride = 3
		//
		// multiarray(i,j,k) refers to the ith row, jth column, and kth channel.

		public MultiArrayLayout()
		{
			dim = new List<MultiArrayDimension>();
		}
	}
}
