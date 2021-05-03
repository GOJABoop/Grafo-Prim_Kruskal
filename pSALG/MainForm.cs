using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pSALG
{
	public partial class MainForm : Form
	{
		List<Circle> circles = new List<Circle>();
		Graph graph = new Graph();
		Bitmap bmp;
		
		public MainForm(){
			InitializeComponent();
		}
		
		void ButtonShowImageClick(object sender, EventArgs e){
			try{
				openFileDialogToSearchFile.ShowDialog();
				pictureBoxShowImage.Image = Image.FromFile(openFileDialogToSearchFile.FileName);				
			}catch(Exception){
				MessageBox.Show("No image has been selected");
			}
		}
		
		void ButtonAnalizeClick(object sender, EventArgs e){
			
				bmp = new Bitmap(openFileDialogToSearchFile.FileName);
				pictureBoxShowImage.Image = bmp;
				circles.Clear();
				graph.clear();
				binarized();
				searchCircles();
				addVertices();
				searchEdges();
				pairClosestPoints();
				printGraph();
				kruskal();
			
		}
		
		Boolean isBlack(Color color){ 
			if(color.R == 0)
				if(color.G == 0)
					if(color.B == 0)
						return true;
			return false;
		}
		
		Boolean isWhite(Color color){ 
			if(color.R == 255)
				if(color.G == 255)
					if(color.B == 255)
						return true;
			return false;
		}
		
		Boolean isGreen(Color color){ 
			if(color.R == 0)
				if(color.G == 128)
					if(color.B == 0)
						return true;
			return false;
		}
		
		Boolean neighborsIsBlack(int x, int y){
			int k, i;
			Boolean edge;
			edge = false;
			k = x - 1;
			for(i = 0; i < 3; k++, i++){
				if(y > 1 && x > 1){
					if(isBlack(bmp.GetPixel(k,y-1)) || 
					   isBlack(bmp.GetPixel(k,y)) || 
					   isBlack(bmp.GetPixel(k,y+1))){
					   	edge = true;
					   	break;
					}
				}
			}
			return edge;	
		}
		
		Boolean isEdge(int x, int y){
			int k, i;
			Boolean edge;
			edge = false;
			k = x - 1;
			for(i = 0; i < 3; k++, i++){
				if(isWhite(bmp.GetPixel(k,y-1)) || isWhite(bmp.GetPixel(k,y)) || isWhite(bmp.GetPixel(k,y+1))){
				   	edge = true;
				   	break;
				}
			}
			return edge;
		}
		
		Boolean contains(Circle c){
			foreach(Circle data in circles){
				if((data.getX()-5 <= c.getX() && c.getX() <= (data.getX() + (int)data.getRadio())) && 
				   (data.getY()-5 <= c.getY() && c.getY() <= (data.getY() + (int)data.getRadio()))){
					return  true;	
				}
			}
			return false;
		}
		
		Boolean isOutOfCircles(int x, int y,int x1, int y1, double sRadio, int x2, int y2, double dRadio){
			double a, b, c, d;
			
			a = Math.Pow(x1 - x, 2);
			b = Math.Pow(y1 - y, 2);
			c = Math.Sqrt(a + b);
			
			a = Math.Pow(x2 - x, 2);
			b = Math.Pow(y2 - y, 2);
			d = Math.Sqrt(a + b);
			if(c < sRadio+6 || d < dRadio+6){
				return false;
			}
			return true;
		}
		
		Boolean thereIsObstacle(int x1, int y1, double sRadio, int x2, int y2, double dRadio){
			double m, c, y, x;
			int limit, difX;
			Color color;
			//define equation menbers
			m = c = 0;
			if((x2-x1) != 0){
				m = ((double)y2-(double)y1)/((double)x2-(double)x1);
				c = (-1 * (double)x1 * (double)m) + (double)y1;					
			}
			difX = Math.Abs(x1-x2);
			if(difX <= 14){
				limit =	limit = Math.Max(y1,y2);
				x = Math.Min(x1,x2);
				for(y = Math.Min(y1,y2); y < limit; y++){
					color = bmp.GetPixel((int)x,(int)y);
					if(!isGreen(color) && !isWhite(color) && isOutOfCircles((int)x,(int)y,x1,y1,sRadio,x2,y2,dRadio)){
						return true;
					}
				}
				for(y = Math.Min(y1,y2); y < limit; y++){
					bmp.SetPixel((int)x,(int)y,Color.Green);
				}
			}
			else{
				limit = Math.Max(x1,x2);//search an obstacle
				for(x = Math.Min(x1,x2); x < limit; x++){
					y = ((double)m * (double)x) + (double)c;
					color = bmp.GetPixel((int)x,(int)y);
					if(!isGreen(color) && !isWhite(color) && isOutOfCircles((int)x,(int)y,x1,y1,sRadio,x2,y2,dRadio)){
						return true;
					}
				}
				for(x = Math.Min(x1,x2); x <= limit; x++){//printLine
					y = ((double)m * (double)x) + (double)c;
					bmp.SetPixel((int)x,(int)y,Color.Green);
				}
			}
			return false;
		}

		Circle defineData(int j, int i){ //(x,y) 
			Circle c = new Circle();
			double radio;
			int middleY, middleX;
			int x, y , k, m, radioX, radioY;
			
			 x = j;
             y = i;
			//Define center			    (j, i)							(j, i+1)
            while (!isWhite(bmp.GetPixel(x, y)) && !isWhite(bmp.GetPixel(x, y+1)))
                y++;
            middleY = (y + i) / 2;
            						  //(j, i)							(j+1, i)
            while (!isWhite(bmp.GetPixel(x, y)) && !isWhite(bmp.GetPixel(x+1, y))) 
                x++;
            middleX = (x + j) / 2; 
			
            //define radio
            k = middleX;
            while (!isWhite(bmp.GetPixel(k, middleY)))
                k++;
            radioX = k -middleX;
            
            m = middleY;
            while (!isWhite(bmp.GetPixel(middleX, m)))
                m++;
            radioY = m -middleY;
            
            radio = (radioX +radioY) / 2;
			c.setData(middleX,middleY,radio,circles.Count+1);
			return c;
		}
		
		Circle getClosestCircle(int j, int i, double diagonal){ //(x , y ,circles)
			Circle c = new Circle();
			double minDistance, currentDistance;
			minDistance = diagonal;
			foreach(Circle data in circles){
				currentDistance = calculateDistance(j, i, data.getX(), data.getY());
				if(currentDistance < minDistance){
					c.setData(data.getX(),data.getY(),data.getRadio(),data.getId());
					minDistance = currentDistance;
				}
			}
			return c;
		}
		
		double calculateDistance(int x1, int y1, int x2, int y2){
			return Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // d(A,B) = sqrt((x2 - x1)^2 + (y2 - y1)^2)
		}
		
		void searchCircles(){
			Color actualColor;
			double a, b, c, diagonal;
			diagonal = Math.Sqrt(Math.Pow(bmp.Height, 2) + Math.Pow(bmp.Width, 2));
			for(int i = 0; i < bmp.Height; i++){
				for(int j = 0; j < bmp.Width; j++){ 
					actualColor= bmp.GetPixel(j,i);
					if(isBlack(actualColor) && isEdge(j,i)){
						if(circles.Count > 0){
							Circle closestCircle = new Circle();
							closestCircle = getClosestCircle(j, i, diagonal);
							a = Math.Pow(closestCircle.getX() - j, 2);
							b = Math.Pow(closestCircle.getY() - i, 2);
							c = Math.Sqrt(a + b);
							if(c > closestCircle.getRadio() + 5){ 
								Circle circle = new Circle();
								circle = defineData(j,i);
								if(!contains(circle)){
									circles.Add(circle);
								}
							}
						} 
						else{
							Circle circle = new Circle();
							circle = defineData(j,i);
							circles.Add(circle);
						}
					}
				}
			}
			foreach(Circle cir in circles){
				markPoint(cir.getX(),cir.getY(),cir.getId(),false);
			}
		}
		
		void addVertices(){
			foreach(Circle c in circles){
				graph.addVertex(c);	
			}
		}
		
		void searchEdges(){
			Circle s = new Circle(); //s = source
			double weight;
			foreach(Vertex v in graph.getVertices()){
				s = circles.Find(d=>d.getId()==v.getData().getId());
				foreach(Circle c in circles){
					if(c.getId() != s.getId()){
						if(!thereIsObstacle(s.getX(),s.getY(),s.getRadio(),c.getX(),c.getY(),c.getRadio())){
							try{
								weight = calculateDistance(s.getX(),s.getY(),c.getX(),c.getY());
								graph.addEdge(s,c,weight); //(source, destination, weight)
							}catch(Exception ex){
								MessageBox.Show(ex.ToString());
							}
						}
					}
				}
			}
		}
		
		void kruskal(){
			DisjointSet sets = new DisjointSet(graph.getVertexCount());
			Vertex vertex = null;
			foreach(Vertex v in graph.getVertices()){
				sets.makeSet(v.getData().getId()-1);
			}
			foreach(Vertex v in graph.getVertices()){
				if(vertex == null) vertex = new Vertex(v.getData());
				foreach(Edge e in v.getAdjacencyList()){
					if(v.getData().getId() != e.getDestination().getData().getId()){
						if(sets.findSet(v.getData().getId()-1) == sets.findSet(e.getDestination().getData().getId()-1)){
							vertex.getAdjacencyList().Add(e);
							sets.union(v.getData().getId()-1, e.getDestination().getData().getId()-1);
						}
					}
				}
			}
			listBoxClosestCircles.Items.Add(vertex.toString());
		}
		
		void pairClosestPoints(){
			double minDistance, currentDistance;
			int  x1, y1, x2, y2;
			string representation;
			Point closestPoint = new Point();
			x1 = y1 = x2 = y2 = 0;
			listBoxClosestCircles.Items.Clear();
			minDistance = Math.Sqrt(Math.Pow(bmp.Height, 2) + Math.Pow(bmp.Width, 2));//Diagonal
			
			if(circles.Count == 0){
				listBoxClosestCircles.Items.Add("There is no point");
			}
			else if(circles.Count == 1){
				listBoxClosestCircles.Items.Add("There is only one point");
			}
			else{
				foreach(Circle c in circles){
					foreach(Circle closest in circles){
						if(c.getId() != closest.getId()){
							currentDistance = calculateDistance(c.getX(), c.getY(), closest.getX(), closest.getY());
							if(currentDistance < minDistance){
								closestPoint.X = c.getId();
								closestPoint.Y = closest.getId();
								minDistance = currentDistance;
								x1 = c.getX();
								y1 = c.getY();
								x2 = closest.getX();
								y2 = closest.getY();
							}
						}
					}
				}
				markPoint(x1,y1,closestPoint.X,true);
				markPoint(x2,y2,closestPoint.Y,true);
				representation = "The closest point is (" + closestPoint.X + ", " + closestPoint.Y + ")." + '\n';
				listBoxClosestCircles.Items.Add(representation);
				representation = "Euclidian distance: " + minDistance + '\n';		
				listBoxClosestCircles.Items.Add(representation);				
			}
		}
		
		void binarized(){
			for (int i = 0; i < bmp.Height - 1; i++)
                for (int j = 0; j < bmp.Width - 1; j++)
					if (!isWhite(bmp.GetPixel(j, i)) && neighborsIsBlack(j, i))
        	             bmp.SetPixel(j, i, Color.Black);
		}
		
		void markPoint(int x, int y, int id, Boolean isForClosest){
			Graphics g = Graphics.FromImage(bmp); 
			Font = new Font("Microsoft Sans Serif", 17, FontStyle.Regular, GraphicsUnit.Pixel);
			
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
		 	g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			g.TextRenderingHint =System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			if(!isForClosest){
				g.DrawString(id.ToString(), Font, Brushes.LightGray,new Point(x,y));
			}
			else{
				g.DrawString(id.ToString(), Font, Brushes.Yellow,new Point(x,y));
				colorCenter(x,y);
			}
			g.Flush();
		}
		
		void colorCenter(int x, int y){
			bmp.SetPixel(x,y,Color.Yellow);
			bmp.SetPixel(x,y-1,Color.Yellow);
			bmp.SetPixel(x,y+1,Color.Yellow);
			
			bmp.SetPixel(x+1,y,Color.Yellow);
			bmp.SetPixel(x+1,y-1,Color.Yellow);
			bmp.SetPixel(x+1,y+1,Color.Yellow);
			
			bmp.SetPixel(x-1,y,Color.Yellow);
			bmp.SetPixel(x-1,y-1,Color.Yellow);
			bmp.SetPixel(x-1,y+1,Color.Yellow);
		}
		
		void printGraph(){
			int i;
			i = 0;
			treeViewGraph.Nodes.Clear();
			foreach(Vertex v in graph.getVertices()){
				treeViewGraph.Nodes.Add(v.getData().getId().ToString());
				foreach(Edge e in v.getAdjacencyList()){
					treeViewGraph.Nodes[i].Nodes.Add(e.toString());
				}
				i++;
			}
		}
	}
}
