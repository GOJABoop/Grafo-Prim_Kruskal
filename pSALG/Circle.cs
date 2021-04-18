using System;

namespace pSALG
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle{
		const double pi = 3.1416;
		double radio;
		int x;
		int y;
		int id;
		double area;
		
		public Circle(){
			radio = 0;
			x = 0;
			y = 0;
			id = 0;
			area = 0;
		}
		
		public void setId(int i){
			id = i;
		}
		
		public void setArea(){
			area = pi * radio * radio;
		}
		
		public void setRadio(double r){
			radio = r;
		}
		
		public void setX(int j){
			x = j;
		}
		
		public void setY(int i){
			y = i;
		}
		
		public int  getId(){
			return id;
		}
		
		public double getRadio(){
			return radio;
		}
		
		public double getArea(){
			return area;
		}
		
		public int getX(){
			return x;
		}
		
		public int getY(){
			return y;
		}
		
		public void setData(int x, int y, double r, int i){
			this.x = x;
			this.y = y;
			radio = r;
			id = i;
			setArea();
		}
		
		public string toString(){
			string c;
			int l;
			c =  id + ".-";
			l = c.Length;
			for(int i = c.Length; i < 7; i++){
				c += "  ";
			}
				 
			c += "(" + x + ", " + y + ")";
			if(l < 4){
				for(int i = c.Length; i < 15; i++){
					c += "  ";
				}
			}
			else{
				for(int i = c.Length; i < 26; i++){
					c += "  ";
				}
			}
			c+= "(" + radio+ "p)"+ '\n';
			return c;
		}
	}
}
