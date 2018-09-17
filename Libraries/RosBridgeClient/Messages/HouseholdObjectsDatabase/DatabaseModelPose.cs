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
	public class DatabaseModelPose
	{
		[JsonIgnore]
		public const string RosMessageName = "household_objects_database_msgs/DatabaseModelPose";

		// Informs that a specific model from the Model Database has been
		// identified at a certain location
		// the database id of the model
		public int model_id;

		// if the object was recognized by the ORK pipeline, its type will be in here
		// if this is not empty, then the string in here will be converted to a household_objects_database id
		// leave this empty if providing an id in the model_id field
		public RosSharp.RosBridgeClient.Messages.ObjectRecognition.ObjectType type;

		// the pose that it can be found in
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped pose;

		// a measure of the confidence level in this detection result
		public float confidence;

		// the name of the object detector that generated this detection result
		public string detector_name;


		public DatabaseModelPose()
		{
			type = new RosSharp.RosBridgeClient.Messages.ObjectRecognition.ObjectType();
			pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			detector_name = string.Empty;
		}
	}
}
