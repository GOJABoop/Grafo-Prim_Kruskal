using System;

namespace pSALG{
	/// <summary>
	/// Description of Edge.
	/// </summary>
	public class Edge{
		Vertex destination;
		int weight;
		public Edge(Vertex destination/*, int weight*/){
			this.destination = destination;
			this.weight = 1;
		}
		public Vertex getDestination(){
			return destination;
		}
		public int getWeight(){
			return weight;
		}
		public string toString(){
			return destination.getData().ToString();
		}
	}
}
