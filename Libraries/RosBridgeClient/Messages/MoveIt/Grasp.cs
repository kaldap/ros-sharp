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

namespace RosSharp.RosBridgeClient.Messages.MoveIt
{
	public class Grasp
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/Grasp";

		// This message contains a description of a grasp that would be used
		// with a particular end-effector to grasp an object, including how to
		// approach it, grip it, etc.  This message does not contain any
		// information about a "grasp point" (a position ON the object).
		// Whatever generates this message should have already combined
		// information about grasp points with information about the geometry
		// of the end-effector to compute the grasp_pose in this message.
		// A name for this grasp
		public string id;

		// The internal posture of the hand for the pre-grasp
		// only positions are used
		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory pre_grasp_posture;

		// The internal posture of the hand for the grasp
		// positions and efforts are used
		public RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory grasp_posture;

		// The position of the end-effector for the grasp.  This is the pose of
		// the "parent_link" of the end-effector, not actually the pose of any
		// link *in* the end-effector.  Typically this would be the pose of the
		// most distal wrist link before the hand (end-effector) links began.
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped grasp_pose;

		// The estimated probability of success for this grasp, or some other
		// measure of how "good" it is.
		public double grasp_quality;

		// The approach direction to take before picking an object
		public GripperTranslation pre_grasp_approach;

		// The retreat direction to take after a grasp has been completed (object is attached)
		public GripperTranslation post_grasp_retreat;

		// The retreat motion to perform when releasing the object; this information
		// is not necessary for the grasp itself, but when releasing the object,
		// the information will be necessary. The grasp used to perform a pickup
		// is returned as part of the result, so this information is available for
		// later use.
		public GripperTranslation post_place_retreat;

		// the maximum contact force to use while grasping (<=0 to disable)
		public float max_contact_force;

		// an optional list of obstacles that we have semantic information about
		// and that can be touched/pushed/moved in the course of grasping
		public List<string> allowed_touch_objects;


		public Grasp()
		{
			id = string.Empty;
			pre_grasp_posture = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory();
			grasp_posture = new RosSharp.RosBridgeClient.Messages.Trajectory.JointTrajectory();
			grasp_pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			pre_grasp_approach = new GripperTranslation();
			post_grasp_retreat = new GripperTranslation();
			post_place_retreat = new GripperTranslation();
			allowed_touch_objects = new List<string>();
		}
	}
}
