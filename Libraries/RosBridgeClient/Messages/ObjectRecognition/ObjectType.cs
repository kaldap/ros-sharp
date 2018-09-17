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

namespace RosSharp.RosBridgeClient.Messages.ObjectRecognition
{
	public class ObjectType
	{
		[JsonIgnore]
		public const string RosMessageName = "object_recognition_msgs/ObjectType";

		//################################################# OBJECT ID #########################################################
		// Contains information about the type of a found object. Those two sets of parameters together uniquely define an
		// object
		// The key of the found object: the unique identifier in the given db
		public string key;

		// The db parameters stored as a JSON/compressed YAML string. An object id does not make sense without the corresponding
		// database. E.g., in object_recognition, it can look like: "{'type':'CouchDB', 'root':'http://localhost'}"
		// There is no conventional format for those parameters and it's nice to keep that flexibility.
		// The object_recognition_core as a generic DB type that can read those fields
		// Current examples:
		// For CouchDB:
		//   type: 'CouchDB'
		//   root: 'http://localhost:5984'
		//   collection: 'object_recognition'
		// For SQL household database:
		//   type: 'SqlHousehold'
		//   host: 'wgs36'
		//   port: 5432
		//   user: 'willow'
		//   password: 'willow'
		//   name: 'household_objects'
		//   module: 'tabletop'
		public string db;


		public ObjectType()
		{
			key = string.Empty;
			db = string.Empty;
		}
	}
}
