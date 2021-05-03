using System;

namespace pSALG
{
	public class DisjointSet{
		int[] rank;
		int[] parent;
		
		public DisjointSet(int n){
			rank = new int[n];
			parent = new int[n];
		}
		
		public void makeSet(int  x){
			parent[x] = x;
			rank[x] = 0;
	    }
		
		public int findSet(int x){
			if (x != parent[x]){
	            parent[x] = findSet(parent[x]);
	        }
			return parent[x];
	    }
		
		public void union(int x, int y){
			x = findSet(x);
			y = findSet(y);
	        if (rank[x] > rank[y])
	        	parent[y] = x;	
	        else{
	        	parent[x] = y;
	        	if(rank[x] == rank[y]){
	        		rank[y]++;
	        	}
	        }
	    }
	}
}
