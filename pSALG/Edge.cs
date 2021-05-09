using System;

namespace pSALG{
	public class Edge{
		Vertex destination;
		double weight;
		
		public Edge(){
			destination = null;
			weight = 0;
		}
		public Edge(Vertex destination, double weight){
			this.destination = destination;
			this.weight = weight;
		}
		public Vertex getDestination(){
			return destination;
		}
		public double getWeight(){
			return weight;
		}
		public string toString(){
			return ">" + destination.getData().getId() + ", " + weight;
		}
	}
}
