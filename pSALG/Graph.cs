using System;
using System.Collections.Generic;

namespace pSALG{
	/// <summary>
	/// Description of Graph.
	/// </summary>
	public class Graph{
		List<Vertex> nodes;
		
		public Graph(){
			nodes = new List<Vertex>();
		}
		
		public void addVertex(int id){
			Vertex node = new Vertex(id);
			nodes.Add(node);
		}
		
		public Vertex findVertex(int id){
			return nodes.Find(v=>v.getData()==id);
		}
		
		public List<Vertex> getVertices(){
			return nodes;
		}
		
		public Boolean addEdge(int s, int d){ //(soruce,destination)
			Vertex source,destination;
			
			if((source = findVertex(s))==null){
				throw new Exception("The node " + s + " does not exist");
			}
			if((destination = findVertex(d))==null){
				throw new Exception("The node " + d + " does not exist");
			}
			return addEdge(source,destination);
		}
		
		public Boolean addEdge(Vertex source, Vertex destination){
			if((source.getAdjacencyList().Find(v=>v.getDestination()==destination))==null){
				source.getAdjacencyList().Add(new Edge(destination));
				return true;
			}
			return false;
		}
		
		public string toString(){
			string g;
			g = "";
			foreach(Vertex v in nodes){
				g += v.toString();
			}
			return g;
		}
		
		public void clear(){
			nodes.Clear();
		}
	}
}
