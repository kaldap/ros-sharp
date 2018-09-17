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

namespace RosSharp.RosBridgeClient.Messages.HouseholdObjectsDatabase
{
	public class DatabaseScan
	{
		[JsonIgnore]
		public const string RosMessageName = "household_objects_database_msgs/DatabaseScan";

		// Contains the location of a stored point cloud scan of an object,
		// as well as additional metadata about that scan
		// the database id of the model
		public int model_id;

		// the location of the bag file storing the scan
		public string bagfile_location;

		// the source of the scan (e.g. simulation)
		public string scan_source;

		// the ground truth pose of the object that was scanned
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped pose;

		// the topic that the points in the bag are published on
		public string cloud_topic;


		public DatabaseScan()
		{
			bagfile_location = string.Empty;
			scan_source = string.Empty;
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			cloud_topic = string.Empty;
		}
	}
}
