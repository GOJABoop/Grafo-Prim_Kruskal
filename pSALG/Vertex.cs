using System;
using System.Collections.Generic;

namespace pSALG
{	/// <summary>
	/// Description of Vertex.
	/// </summary>
	public class Vertex{
		int data;
		List<Edge> adjacencyList;
		
		public Vertex(int data){
			this.data = data;
			this.adjacencyList = new List<Edge>();
		}
		public int  getData(){
			return data;
		}
		public List<Edge> getAdjacencyList(){
			return adjacencyList;
		}
		public string toString(){
			string connection;
			connection = data + "->";
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
