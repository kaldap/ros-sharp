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

namespace RosSharp.RosBridgeClient.Messages.Manipulation
{
	public class Grasp
	{
		[JsonIgnore]
		public const string RosMessageName = "manipulation_msgs/Grasp";

		// A name for this grasp
		public string id;

		// The internal posture of the hand for the pre-grasp
		// only positions are used
		public RosSharp.RosBridgeClient.Messages.Sensor.JointState pre_grasp_posture;

		// The internal posture of the hand for the grasp
		// positions and efforts are used
		public RosSharp.RosBridgeClient.Messages.Sensor.JointState grasp_posture;

		// The position of the end-effector for the grasp
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped grasp_pose;

		// The estimated probability of success for this grasp, or some other
		// measure of how "good" it is.
		public double grasp_quality;

		// The approach motion
		public GripperTranslation approach;

		// The retreat motion
		public GripperTranslation retreat;

		// the maximum contact force to use while grasping (<=0 to disable)
		public float max_contact_force;

		// an optional list of obstacles that we have semantic information about
		// and that can be touched/pushed/moved in the course of grasping
		public List<string> allowed_touch_objects;


		public Grasp()
		{
			id = string.Empty;
			pre_grasp_posture = new RosSharp.RosBridgeClient.Messages.Sensor.JointState();
			grasp_posture = new RosSharp.RosBridgeClient.Messages.Sensor.JointState();
			grasp_pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			approach = new GripperTranslation();
			retreat = new GripperTranslation();
			allowed_touch_objects = new List<string>();
		}
	}
}
