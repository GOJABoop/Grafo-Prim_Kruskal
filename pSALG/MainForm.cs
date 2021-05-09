using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pSALG
{
	public partial class MainForm : Form
	{
		List<Circle> circles;
		List<KeyValuePair<double,Tuple<Circle,Circle>>> edges;
		List<KeyValuePair<double,Tuple<Circle,Circle>>> candidates;
		Graph graph;
		Graph mstKruskal;
		Graph mstPrim;
		Bitmap bmp;
		int countMst;
		
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
			try{
				circles = new List<Circle>();
				graph = new Graph();
				bmp = new Bitmap(openFileDialogToSearchFile.FileName);
				pictureBoxShowImage.Image = bmp;
				clearAllListBox();
				binarized();
				searchCircles();
				addVertices();
				searchEdges();
				printGraph();
				kruskalProcedure();
			}catch(Exception){
				MessageBox.Show("No image has been selected");
			}
			
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
			} return edge;	
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
			} return edge;
		}
		
		Boolean contains(Circle c){
			foreach(Circle data in circles){
				if((data.getX()-5 <= c.getX() && c.getX() <= (data.getX() + (int)data.getRadio())) && 
				   (data.getY()-5 <= c.getY() && c.getY() <= (data.getY() + (int)data.getRadio()))){
					return  true;	
				}
			}return false;
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
			}
			printLine(false,x1,y1,x2,y2);
			return false;
		}
		
		Boolean isFeasible(KeyValuePair<double,Tuple<Circle,Circle>> e, List<Vertex> s){
			Boolean v_1 = false, v_2 = false;
			foreach(Vertex v in s){
				if(v.getData().Equals(e.Value.Item1)){
					v_1 = true;
				}
				if(v.getData().Equals(e.Value.Item2)){
					v_2 = true;
				}
			}
			if(v_1 && v_2){
				return false;
			}
			return true;
		}
		
		Boolean belongsTo(Circle e, List<Vertex> s){
			foreach(Vertex v in s){
				if(v.getData() == e){
					return true;
				}
			}return false;
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
			edges = new List<KeyValuePair<double, Tuple<Circle, Circle>>>();
			double weight;
			foreach(Vertex v in graph.getVertices()){
				s = circles.Find(d=>d.getId()==v.getData().getId());
				foreach(Circle c in circles){
					if(c.getId() != s.getId()){
						if(!thereIsObstacle(s.getX(),s.getY(),s.getRadio(),c.getX(),c.getY(),c.getRadio())){
							try{
								weight = calculateDistance(s.getX(),s.getY(),c.getX(),c.getY());
								edges.Add(new KeyValuePair<double, Tuple<Circle, Circle>>(weight,new Tuple<Circle,Circle>(s,c)));
								graph.addEdge(s,c,weight); //(source, destination, weight)
							}catch(Exception ex){
								MessageBox.Show(ex.ToString());
							}
						}
					}
				}
			}
		}
		
		List<Tuple<Circle,Circle>> kruskal(){
			DisjointSet sets = new DisjointSet(graph.getVertexCount());
			List<Tuple<Circle,Circle>> kruskalEdges = new List<Tuple<Circle,Circle>>();
			int u,v;
			foreach(Vertex vtx in graph.getVertices()){
				sets.makeSet(vtx.getData().getId()-1);
			}
			edges.Sort((x,y) => x.Key.CompareTo(y.Key));
			for(int i = 0; i < edges.Count; i++){
				u = edges[i].Value.Item1.getId()-1;
				v = edges[i].Value.Item2.getId()-1;
				if(u != v){
					if(sets.findSet(u) != sets.findSet(v)){
						kruskalEdges.Add(new Tuple<Circle,Circle>(edges[i].Value.Item1,edges[i].Value.Item2));
						sets.union(u,v);
					}
				}
			}
			return kruskalEdges;
		}
		
		void kruskalProcedure(){
			string representation;
			double weight;
			Vertex v = null, u  = null;
			Circle s = new Circle();
			Circle d = new Circle();
			mstKruskal = new Graph();
			List<Tuple<Circle,Circle>> krkRepresentation= new List<Tuple<Circle,Circle>>();
			
			krkRepresentation= kruskal();
			for(int i = 0; i < krkRepresentation.Count; i++){
				s = krkRepresentation[i].Item1;
				d = krkRepresentation[i].Item2;
				u = mstKruskal.findVertex(s);
				v = mstKruskal.findVertex(d);
				if(u == null && v == null){
					weight = calculateDistance(s.getX(),s.getY(),d.getX(),d.getY());
					mstKruskal.addVertex(s);
					mstKruskal.addVertex(d);
					mstKruskal.addEdge(s,d,weight);
				}
				else if(u == null){
					weight = calculateDistance(s.getX(),s.getY(),d.getX(),d.getY());	
					mstKruskal.addVertex(s);
					mstKruskal.addEdge(s,d,weight);
				}
				else{
					weight = calculateDistance(s.getX(),s.getY(),d.getX(),d.getY());
					mstKruskal.addVertex(d);
					mstKruskal.addEdge(s,d,weight);
				}
				printLine(true, s.getX(),s.getY(), d.getX(),d.getY());
				representation = "(" + s.getId() + ", " + d.getId() + ")" + '\n';
				listBoxKruskalEdges.Items.Add(representation);
			}
			listBoxWeightKruskal.Items.Add(mstKruskal.getWeight().ToString());
			int j;
			j = 0;
			mstCreated();
			foreach(Vertex ver in mstKruskal.getVertices()){
				if(ver.getAdjacencyList().Count > 0){
					treeViewMstKruskal.Nodes.Add(ver.getData().getId().ToString());
					foreach(Edge e in ver.getAdjacencyList()){
						treeViewMstKruskal.Nodes[j].Nodes.Add(e.toString());
					}
					j++;	
				}
			}
		}

		
		List<KeyValuePair<double,Tuple<Circle,Circle>>> prim(Vertex v_i){
			List<Vertex> s = new List<Vertex>();
			candidates = new List<KeyValuePair<double,Tuple<Circle,Circle>>>();
			KeyValuePair<double,Tuple<Circle,Circle>> e;
			List<KeyValuePair<double,Tuple<Circle,Circle>>> mst = new List<KeyValuePair<double,Tuple<Circle,Circle>>>();
			Circle c1 = new Circle();
			Circle c2 = new Circle();
			Vertex v1;
			addCandidates(v_i);
			s.Add(v_i);
			while( s.Count < graph.getVertexCount() && candidates.Count > 0){
				e = new KeyValuePair<double,Tuple<Circle,Circle>>(0,new Tuple<Circle,Circle>(c1,c2));
				e = selectBestEdge();
				if(isFeasible(e,s)){
					mst.Add(e);
					if(belongsTo(e.Value.Item1,s)){
						v1 = graph.findVertex(e.Value.Item2);
						s.Add(v1);
						addCandidates(v1);	
					}
					else{
						v1 = graph.findVertex(e.Value.Item1);
						s.Add(v1);
						addCandidates(v1);
					}
				}
				candidates.RemoveAt(candidates.IndexOf(e));
			}
			return mst;
		}
		
		void addCandidates(Vertex vertex){
			Circle c1;
			Circle c2;
			if(vertex != null){
				c1 = vertex.getData();
				foreach(Edge e in vertex.getAdjacencyList()){
					c2 = e.getDestination().getData();
					candidates.Add(new KeyValuePair<double, Tuple<Circle, Circle>>(e.getWeight(),new Tuple<Circle,Circle>(c1,c2)));
				}	
			}
		}
		
		KeyValuePair<double,Tuple<Circle,Circle>> selectBestEdge(){
			Circle c1 = new Circle();
			Circle c2 = new Circle();
			KeyValuePair<double,Tuple<Circle,Circle>> best = new KeyValuePair<double,Tuple<Circle,Circle>>(0,new Tuple<Circle,Circle>(c1,c2));
			double min;
			min = double.MaxValue;
			foreach(KeyValuePair<double,Tuple<Circle,Circle>> index in candidates){
				if(index.Key < min){
					best = index;
					min = index.Key;
				}
			}
			return best;
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
			foreach(Vertex v in graph.getVertices()){
				treeViewGraph.Nodes.Add(v.getData().getId().ToString());
				foreach(Edge e in v.getAdjacencyList()){
					treeViewGraph.Nodes[i].Nodes.Add(e.toString());
				}
				i++;
			}
		}
		
		void ButtonExecutePrimClick(object sender, EventArgs e){
			Vertex v_i;
			Circle start = new Circle();
			List<KeyValuePair<double,Tuple<Circle,Circle>>> primRepresentation = new List<KeyValuePair<double, Tuple<Circle,Circle>>>();
			start.setId(Convert.ToInt32(textBoxStartVertexPrim.Text));
			v_i = graph.findVertex(start);
			if(v_i != null){
				primRepresentation = prim(v_i);
				primProcedure(primRepresentation);
			}
			else{
				MessageBox.Show("Vertex does not exists");
			}
		}
		
		void mstCreated(){
			countMst = 0;
			int count;
			count = 0;
			Boolean[] flags = new Boolean[graph.getVertexCount()];
			foreach(Vertex v in graph.getVertices()){
				if(!flags[v.getData().getId()-1]){
					flags[v.getData().getId()-1] = true;
					foreach(Edge e in v.getAdjacencyList()){
						if(!flags[e.getDestination().getData().getId()-1]){
							flags[e.getDestination().getData().getId()-1] = true;
							count++;
						}
						else{
							break;
						}
					}
					if(count == v.getAdjacencyList().Count){
						countMst++;
					}
					count = 0;
				}
			}
			listBoxMstCreatedKruskal.Items.Add(countMst);
		}
		
		void primProcedure(List<KeyValuePair<double,Tuple<Circle,Circle>>> primRepresentation){
			string representation;
			Vertex v = null, u  = null;
			Circle s = new Circle();
			Circle d = new Circle();
			mstPrim = new Graph();
			
			for(int i = 0; i < primRepresentation.Count; i++){
				s = primRepresentation[i].Value.Item1;
				d = primRepresentation[i].Value.Item2;
				u = mstPrim.findVertex(s);
				v = mstPrim.findVertex(d);
				if(u == null && v == null){
					mstPrim.addVertex(s);
					mstPrim.addVertex(d);
					mstPrim.addEdge(s,d,primRepresentation[i].Key);
				}
				else if(u == null){	
					mstPrim.addVertex(s);
					mstPrim.addEdge(s,d,primRepresentation[i].Key);
				}
				else{
					mstPrim.addVertex(d);
					mstPrim.addEdge(s,d,primRepresentation[i].Key);
				}
				//printLine(true, s.getX(),s.getY(), d.getX(),d.getY());
				
				Graphics g = Graphics.FromImage(bmp);
				Pen pen = new Pen(Color.BlueViolet,3);
				PointF p1 = new PointF(s.getX()-5,s.getY()-5);
				PointF p2 = new PointF(d.getX()-5,d.getY()-5);
				g.DrawLine(pen,p1,p2);
				g.Flush();
				representation = "(" + s.getId() + ", " + d.getId() + ")" + '\n';
				listBoxPrim.Items.Add(representation);
			}
			
			listBoxWeightPrim.Items.Add(mstPrim.getWeight().ToString());
			int j;
			j = 0;
			foreach(Vertex ver in mstPrim.getVertices()){
				if(ver.getAdjacencyList().Count > 0){
					treeViewMstPrim.Nodes.Add(ver.getData().getId().ToString());
					foreach(Edge e in ver.getAdjacencyList()){
						treeViewMstPrim.Nodes[j].Nodes.Add(e.toString());
					}
					j++;	
				}
			}
			if(countMst == 1){
				listBoxMstCreatedPrim.Items.Add(countMst);
			}
			else{
				listBoxMstCreatedPrim.Items.Add("1, (" + countMst + " possible)");
			}
		}
		
		void printLine(Boolean mst, int x1, int y1, int x2, int y2){
			Graphics g = Graphics.FromImage(bmp); 
			Pen pen;
			if(!mst){
				pen = new Pen(Color.Green,1);	
			}
			else{
				pen = new Pen(Color.Red,3);
			}
			PointF p1 = new PointF(x1,y1);
			PointF p2 = new PointF(x2,y2);
			g.DrawLine(pen,p1,p2);
		}
		
		void clearAllListBox(){
			treeViewGraph.Nodes.Clear();
			
			treeViewMstKruskal.Nodes.Clear();
			listBoxMstCreatedKruskal.Items.Clear();
			listBoxWeightKruskal.Items.Clear();
			listBoxKruskalEdges.Items.Clear();
			
			treeViewMstPrim.Nodes.Clear();
			listBoxPrim.Items.Clear();
			listBoxMstCreatedPrim.Items.Clear();
			listBoxWeightPrim.Items.Clear();
						
		}
	}
}
