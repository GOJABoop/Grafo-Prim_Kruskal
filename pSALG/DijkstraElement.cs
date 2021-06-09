using System;

namespace pSALG{
	public class DijkstraElement
	{
		double accumulatedWeight;
		int parent;
		bool definitive;
		
		public DijkstraElement(){
			accumulatedWeight = double.MaxValue;
			parent = -1;
			definitive = false;
		}
		
		public void setAccumulatedWeight(double weight){
			accumulatedWeight = weight;
		}
		
		public void setParent(int parent){
			this.parent = parent;
		}
		
		public void setDefinitive(bool isDefnitive){
			definitive = isDefnitive;
		}
		
		public double getAccumulatedWeight(){
			return accumulatedWeight;
		}
		
		public int getParent(){
			return parent;
		}
		
		public bool isDefinitive(){
			return definitive;
		}
	}
}
