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
	public class MultiDOFJointState
	{
		[JsonIgnore]
		public const string RosMessageName = "sensor_msgs/MultiDOFJointState";

		// Representation of state for joints with multiple degrees of freedom,
		// following the structure of JointState.
		//
		// It is assumed that a joint in a system corresponds to a transform that gets applied
		// along the kinematic chain. For example, a planar joint (as in URDF) is 3DOF (x, y, yaw)
		// and those 3DOF can be expressed as a transformation matrix, and that transformation
		// matrix can be converted back to (x, y, yaw)
		//
		// Each joint is uniquely identified by its name
		// The header specifies the time at which the joint states were recorded. All the joint states
		// in one message have to be recorded at the same time.
		//
		// This message consists of a multiple arrays, one for each part of the joint state.
		// The goal is to make each of the fields optional. When e.g. your joints have no
		// wrench associated with them, you can leave the wrench array empty.
		//
		// All arrays in this message should have the same size, or be empty.
		// This is the only way to uniquely associate the joint name with the correct
		// states.
		public Header header;

		public List<string> joint_names;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Transform> transforms;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Twist> twist;

		public List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench> wrench;


		public MultiDOFJointState()
		{
			header = new Header();
			joint_names = new List<string>();
			transforms = new List<RosSharp.RosBridgeClient.Messages.Geometry.Transform>();
			twist = new List<RosSharp.RosBridgeClient.Messages.Geometry.Twist>();
			wrench = new List<RosSharp.RosBridgeClient.Messages.Geometry.Wrench>();
		}
	}
}
