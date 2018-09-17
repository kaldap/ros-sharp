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

namespace RosSharp.RosBridgeClient.Messages.Shape
{
	public class SolidPrimitive
	{
		[JsonIgnore]
		public const string RosMessageName = "shape_msgs/SolidPrimitive";

		// Define box, sphere, cylinder, cone
		// All shapes are defined to have their bounding boxes centered around 0,0,0.
		public byte BOX=1;

		public byte SPHERE=2;

		public byte CYLINDER=3;

		public byte CONE=4;

		// The type of the shape
		public byte type;

		// The dimensions of the shape
		public List<double> dimensions;

		// The meaning of the shape dimensions: each constant defines the index in the 'dimensions' array
		// For the BOX type, the X, Y, and Z dimensions are the length of the corresponding
		// sides of the box.
		public byte BOX_X=0;

		public byte BOX_Y=1;

		public byte BOX_Z=2;

		// For the SPHERE type, only one component is used, and it gives the radius of
		// the sphere.
		public byte SPHERE_RADIUS=0;

		// For the CYLINDER and CONE types, the center line is oriented along
		// the Z axis.  Therefore the CYLINDER_HEIGHT (CONE_HEIGHT) component
		// of dimensions gives the height of the cylinder (cone).  The
		// CYLINDER_RADIUS (CONE_RADIUS) component of dimensions gives the
		// radius of the base of the cylinder (cone).  Cone and cylinder
		// primitives are defined to be circular. The tip of the cone is
		// pointing up, along +Z axis.
		public byte CYLINDER_HEIGHT=0;

		public byte CYLINDER_RADIUS=1;

		public byte CONE_HEIGHT=0;

		public byte CONE_RADIUS=1;


		public SolidPrimitive()
		{
			dimensions = new List<double>();
		}
	}
}
