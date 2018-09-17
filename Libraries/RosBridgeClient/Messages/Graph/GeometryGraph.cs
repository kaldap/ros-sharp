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

namespace RosSharp.RosBridgeClient.Messages.Graph
{
	public class GeometryGraph
	{
		[JsonIgnore]
		public const string RosMessageName = "graph_msgs/GeometryGraph";

		// A reference coordinate frame and timestamp
		public Header header;

		// 3D spacial graph
		public List<RosSharp.RosBridgeClient.Messages.Geometry.Point> nodes;

		// This vector should be the same length as nodes, above, and represents all the connecting nodes
		public List<Edges> edges;


		public GeometryGraph()
		{
			header = new Header();
			nodes = new List<RosSharp.RosBridgeClient.Messages.Geometry.Point>();
			edges = new List<Edges>();
		}
	}
}
