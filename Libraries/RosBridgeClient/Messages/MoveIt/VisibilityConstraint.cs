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
	public class VisibilityConstraint
	{
		[JsonIgnore]
		public const string RosMessageName = "moveit_msgs/VisibilityConstraint";

		// The constraint is useful to maintain visibility to a disc (the target) in a particular frame.
		// This disc forms the base of a visibiliy cone whose tip is at the origin of the sensor.
		// Maintaining visibility is done by ensuring the robot does not obstruct the visibility cone.
		// Note:
		// This constraint does NOT enforce minimum or maximum distances between the sensor
		// and the target, nor does it enforce the target to be in the field of view of
		// the sensor. A PositionConstraint can (and probably should) be used for such purposes.
		// The radius of the disc that should be maintained visible
		public double target_radius;

		// The pose of the disc; as the robot moves, the pose of the disc may change as well
		// This can be in the frame of a particular robot link, for example
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped target_pose;

		// From the sensor origin towards the target, the disc forms a visibility cone
		// This cone is approximated using many sides. For example, when using 4 sides,
		// that in fact makes the visibility region be a pyramid.
		// This value should always be 3 or more.
		public int cone_sides;

		// The pose in which visibility is to be maintained.
		// The frame id should represent the robot link to which the sensor is attached.
		// It is assumed the sensor can look directly at the target, in any direction.
		// This assumption is usually not true, but additional PositionConstraints
		// can resolve this issue.
		public RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped sensor_pose;

		// Even though the disc is maintained visible, the visibility cone can be very small
		// because of the orientation of the disc with respect to the sensor. It is possible
		// for example to view the disk almost from a side, in which case the visibility cone
		// can end up having close to 0 volume. The view angle is defined to be the angle between
		// the normal to the visibility disc and the direction vector from the sensor origin.
		// The value below represents the minimum desired view angle. For a perfect view,
		// this value will be 0 (the two vectors are exact opposites). For a completely obstructed view
		// this value will be Pi/2 (the vectors are perpendicular). This value defined below
		// is the maximum view angle to be maintained. This should be a value in the open interval
		// (0, Pi/2). If 0 is set, the view angle is NOT enforced.
		public double max_view_angle;

		// This angle is used similarly to max_view_angle but limits the maximum angle
		// between the sensor origin direction vector and the axis that connects the
		// sensor origin to the target frame origin. The value is again in the range (0, Pi/2)
		// and is NOT enforced if set to 0.
		public double max_range_angle;

		// The axis that is assumed to indicate the direction of view for the sensor
		// X = 2, Y = 1, Z = 0
		public byte SENSOR_Z=0;

		public byte SENSOR_Y=1;

		public byte SENSOR_X=2;

		public byte sensor_view_direction;

		// A weighting factor for this constraint (denotes relative importance to other constraints. Closer to zero means less important)
		public double weight;


		public VisibilityConstraint()
		{
			target_pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
			sensor_pose = new RosSharp.RosBridgeClient.Messages.Geometry.PoseStamped();
		}
	}
}
