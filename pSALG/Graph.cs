using System;
using System.Collections.Generic;

namespace pSALG{
	public class Graph{
		List<Vertex> vertices;
		double weight;
		
		public Graph(){
			vertices = new List<Vertex>();
			weight = 0;
		}
		
		public void addVertex(Circle c){
			Vertex vertex = new Vertex(c);
			vertices.Add(vertex);
		}
		
		public Vertex findVertex(Circle c){
			return vertices.Find(v=>v.getData().getId()==c.getId());
		}
		
		public List<Vertex> getVertices(){
			return vertices;
		}
		
		public int getVertexCount(){
			return vertices.Count;
		}
		
		public Vertex getVertexAt(int i){
			return vertices[i];
		}

		public double getWeight(){
			return weight;
		}
		
		public Boolean addEdge(Circle s, Circle d, double weight){ //(source,destination,weight)
			Vertex source,destination;
			
			if((source = findVertex(s))==null){
				throw new Exception("The node " + s + " does not exist");
			}
			if((destination = findVertex(d))==null){
				throw new Exception("The node " + d + " does not exist");
			}
			return addEdge(source,destination,weight);
		}
		
		public Boolean addEdge(Vertex source, Vertex destination, double weight){
			if((source.getAdjacencyList().Find(v=>v.getDestination()==destination))==null){
				source.getAdjacencyList().Add(new Edge(destination,weight));
				this.weight += weight;
				return true;
			}
			return false;
		}
		
		public string toString(){
			string g;
			g = "";
			foreach(Vertex v in vertices){
				g += v.toString();
			}
			return g;
		}
		
		public void clear(){
			vertices.Clear();
		}
	}
}
