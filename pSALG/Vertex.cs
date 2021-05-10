using System;
using System.Collections.Generic;

namespace pSALG
{
	public class Vertex{
		Circle data;
		List<Edge> adjacencyList;
		
		public Vertex(Circle data){
			this.data = data;
			this.adjacencyList = new List<Edge>();
		}
		
		public Vertex(Vertex s){
			this.data = s.getData();
			this.adjacencyList = s.getAdjacencyList();
		}
		
		public Circle  getData(){
			return data;
		}
		
		public List<Edge> getAdjacencyList(){
			return adjacencyList;
		}	
		
		public int getEdgesCount(){
			return adjacencyList.Count;
		}
		
		public Edge getEdgeAt(int i){
			return adjacencyList[i];
		}
		
		public string toString(){
			string connection;
			connection = data.getId() + "->";
			foreach(Edge e in adjacencyList){
				connection += e.toString() + "->";
			}
			int len;
			len = connection.Length-2;
			connection = connection.Remove(len,2);
			connection += '\n';
			return connection;
		}
	}
}
