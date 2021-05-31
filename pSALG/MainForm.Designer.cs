/*
 * Created by SharpDevelop.
 * User: Alberto
 * Date: 16/03/2021
 * Time: 09:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace pSALG
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBoxShowImage;
		private System.Windows.Forms.Button buttonShowImage;
		private System.Windows.Forms.OpenFileDialog openFileDialogToSearchFile;
		private System.Windows.Forms.Button buttonAnalize;
		private System.Windows.Forms.Label labelGraphDesc;
		private System.Windows.Forms.Label labelKruskal;
		private System.Windows.Forms.ListBox listBoxKruskalEdges;
		private System.Windows.Forms.Label labelSelectImage;
		private System.Windows.Forms.TreeView treeViewGraph;
		private System.Windows.Forms.Label labelOrderOfEdgesKruskal;
		private System.Windows.Forms.Label labelPrim;
		private System.Windows.Forms.ListBox listBoxPrim;
		private System.Windows.Forms.Label labelOrderEdgesPrim;
		private System.Windows.Forms.TreeView treeViewMstKruskal;
		private System.Windows.Forms.Label labelWeightKruskal;
		private System.Windows.Forms.ListBox listBoxWeightKruskal;
		private System.Windows.Forms.Label labelMstCreatedKruskal;
		private System.Windows.Forms.ListBox listBoxMstCreatedKruskal;
		private System.Windows.Forms.TreeView treeViewMstPrim;
		private System.Windows.Forms.Label labelWeigthPrim;
		private System.Windows.Forms.Label labelMstCreatedPrim;
		private System.Windows.Forms.ListBox listBoxWeightPrim;
		private System.Windows.Forms.ListBox listBoxMstCreatedPrim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonExecutePrim;
		private System.Windows.Forms.TextBox textBoxStartVertexPrim;
		private System.Windows.Forms.ComboBox comboBoxSelectAlgorithmToShow;
		private System.Windows.Forms.Button buttonShowRepresentation;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		private void InitializeComponent()
		{
			this.pictureBoxShowImage = new System.Windows.Forms.PictureBox();
			this.buttonShowImage = new System.Windows.Forms.Button();
			this.openFileDialogToSearchFile = new System.Windows.Forms.OpenFileDialog();
			this.buttonAnalize = new System.Windows.Forms.Button();
			this.labelGraphDesc = new System.Windows.Forms.Label();
			this.labelKruskal = new System.Windows.Forms.Label();
			this.listBoxKruskalEdges = new System.Windows.Forms.ListBox();
			this.labelSelectImage = new System.Windows.Forms.Label();
			this.treeViewGraph = new System.Windows.Forms.TreeView();
			this.labelOrderOfEdgesKruskal = new System.Windows.Forms.Label();
			this.labelPrim = new System.Windows.Forms.Label();
			this.listBoxPrim = new System.Windows.Forms.ListBox();
			this.labelOrderEdgesPrim = new System.Windows.Forms.Label();
			this.treeViewMstKruskal = new System.Windows.Forms.TreeView();
			this.labelWeightKruskal = new System.Windows.Forms.Label();
			this.listBoxWeightKruskal = new System.Windows.Forms.ListBox();
			this.labelMstCreatedKruskal = new System.Windows.Forms.Label();
			this.listBoxMstCreatedKruskal = new System.Windows.Forms.ListBox();
			this.treeViewMstPrim = new System.Windows.Forms.TreeView();
			this.labelWeigthPrim = new System.Windows.Forms.Label();
			this.labelMstCreatedPrim = new System.Windows.Forms.Label();
			this.listBoxWeightPrim = new System.Windows.Forms.ListBox();
			this.listBoxMstCreatedPrim = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonExecutePrim = new System.Windows.Forms.Button();
			this.textBoxStartVertexPrim = new System.Windows.Forms.TextBox();
			this.comboBoxSelectAlgorithmToShow = new System.Windows.Forms.ComboBox();
			this.buttonShowRepresentation = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxShowImage
			// 
			this.pictureBoxShowImage.Location = new System.Drawing.Point(14, 14);
			this.pictureBoxShowImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pictureBoxShowImage.Name = "pictureBoxShowImage";
			this.pictureBoxShowImage.Size = new System.Drawing.Size(679, 463);
			this.pictureBoxShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxShowImage.TabIndex = 0;
			this.pictureBoxShowImage.TabStop = false;
			// 
			// buttonShowImage
			// 
			this.buttonShowImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowImage.Location = new System.Drawing.Point(85, 485);
			this.buttonShowImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.buttonShowImage.Name = "buttonShowImage";
			this.buttonShowImage.Size = new System.Drawing.Size(68, 31);
			this.buttonShowImage.TabIndex = 1;
			this.buttonShowImage.Text = "image";
			this.buttonShowImage.UseVisualStyleBackColor = true;
			this.buttonShowImage.Click += new System.EventHandler(this.ButtonShowImageClick);
			// 
			// openFileDialogToSearchFile
			// 
			this.openFileDialogToSearchFile.FileName = "openFileDialog1";
			// 
			// buttonAnalize
			// 
			this.buttonAnalize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAnalize.Location = new System.Drawing.Point(163, 485);
			this.buttonAnalize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.buttonAnalize.Name = "buttonAnalize";
			this.buttonAnalize.Size = new System.Drawing.Size(70, 31);
			this.buttonAnalize.TabIndex = 2;
			this.buttonAnalize.Text = "analize";
			this.buttonAnalize.UseVisualStyleBackColor = true;
			this.buttonAnalize.Click += new System.EventHandler(this.ButtonAnalizeClick);
			// 
			// labelGraphDesc
			// 
			this.labelGraphDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGraphDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelGraphDesc.Location = new System.Drawing.Point(85, 610);
			this.labelGraphDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelGraphDesc.Name = "labelGraphDesc";
			this.labelGraphDesc.Size = new System.Drawing.Size(161, 21);
			this.labelGraphDesc.TabIndex = 6;
			this.labelGraphDesc.Text = "General Graph(s) ->";
			// 
			// labelKruskal
			// 
			this.labelKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelKruskal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelKruskal.Location = new System.Drawing.Point(716, 9);
			this.labelKruskal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelKruskal.Name = "labelKruskal";
			this.labelKruskal.Size = new System.Drawing.Size(81, 27);
			this.labelKruskal.TabIndex = 7;
			this.labelKruskal.Text = " Kruskal";
			// 
			// listBoxKruskalEdges
			// 
			this.listBoxKruskalEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.listBoxKruskalEdges.FormattingEnabled = true;
			this.listBoxKruskalEdges.ItemHeight = 20;
			this.listBoxKruskalEdges.Location = new System.Drawing.Point(964, 39);
			this.listBoxKruskalEdges.Name = "listBoxKruskalEdges";
			this.listBoxKruskalEdges.Size = new System.Drawing.Size(93, 204);
			this.listBoxKruskalEdges.TabIndex = 8;
			// 
			// labelSelectImage
			// 
			this.labelSelectImage.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelSelectImage.Location = new System.Drawing.Point(14, 490);
			this.labelSelectImage.Name = "labelSelectImage";
			this.labelSelectImage.Size = new System.Drawing.Size(63, 23);
			this.labelSelectImage.TabIndex = 9;
			this.labelSelectImage.Text = "Select";
			// 
			// treeViewGraph
			// 
			this.treeViewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeViewGraph.Location = new System.Drawing.Point(241, 485);
			this.treeViewGraph.Name = "treeViewGraph";
			this.treeViewGraph.Size = new System.Drawing.Size(244, 152);
			this.treeViewGraph.TabIndex = 11;
			// 
			// labelOrderOfEdgesKruskal
			// 
			this.labelOrderOfEdgesKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderOfEdgesKruskal.Location = new System.Drawing.Point(871, 9);
			this.labelOrderOfEdgesKruskal.Name = "labelOrderOfEdgesKruskal";
			this.labelOrderOfEdgesKruskal.Size = new System.Drawing.Size(202, 27);
			this.labelOrderOfEdgesKruskal.TabIndex = 12;
			this.labelOrderOfEdgesKruskal.Text = "Edge selection order";
			// 
			// labelPrim
			// 
			this.labelPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrim.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelPrim.Location = new System.Drawing.Point(716, 318);
			this.labelPrim.Name = "labelPrim";
			this.labelPrim.Size = new System.Drawing.Size(55, 23);
			this.labelPrim.TabIndex = 13;
			this.labelPrim.Text = "Prim";
			// 
			// listBoxPrim
			// 
			this.listBoxPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.listBoxPrim.FormattingEnabled = true;
			this.listBoxPrim.ItemHeight = 20;
			this.listBoxPrim.Location = new System.Drawing.Point(964, 344);
			this.listBoxPrim.Name = "listBoxPrim";
			this.listBoxPrim.Size = new System.Drawing.Size(93, 204);
			this.listBoxPrim.TabIndex = 14;
			// 
			// labelOrderEdgesPrim
			// 
			this.labelOrderEdgesPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOrderEdgesPrim.Location = new System.Drawing.Point(871, 318);
			this.labelOrderEdgesPrim.Name = "labelOrderEdgesPrim";
			this.labelOrderEdgesPrim.Size = new System.Drawing.Size(186, 23);
			this.labelOrderEdgesPrim.TabIndex = 15;
			this.labelOrderEdgesPrim.Text = "Edge selection order";
			// 
			// treeViewMstKruskal
			// 
			this.treeViewMstKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeViewMstKruskal.ForeColor = System.Drawing.Color.Black;
			this.treeViewMstKruskal.Location = new System.Drawing.Point(716, 40);
			this.treeViewMstKruskal.Name = "treeViewMstKruskal";
			this.treeViewMstKruskal.Size = new System.Drawing.Size(242, 203);
			this.treeViewMstKruskal.TabIndex = 16;
			// 
			// labelWeightKruskal
			// 
			this.labelWeightKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWeightKruskal.Location = new System.Drawing.Point(715, 250);
			this.labelWeightKruskal.Name = "labelWeightKruskal";
			this.labelWeightKruskal.Size = new System.Drawing.Size(81, 23);
			this.labelWeightKruskal.TabIndex = 17;
			this.labelWeightKruskal.Text = "Weight:";
			// 
			// listBoxWeightKruskal
			// 
			this.listBoxWeightKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxWeightKruskal.FormattingEnabled = true;
			this.listBoxWeightKruskal.ItemHeight = 20;
			this.listBoxWeightKruskal.Location = new System.Drawing.Point(792, 249);
			this.listBoxWeightKruskal.Name = "listBoxWeightKruskal";
			this.listBoxWeightKruskal.Size = new System.Drawing.Size(265, 24);
			this.listBoxWeightKruskal.TabIndex = 18;
			// 
			// labelMstCreatedKruskal
			// 
			this.labelMstCreatedKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMstCreatedKruskal.Location = new System.Drawing.Point(715, 280);
			this.labelMstCreatedKruskal.Name = "labelMstCreatedKruskal";
			this.labelMstCreatedKruskal.Size = new System.Drawing.Size(130, 23);
			this.labelMstCreatedKruskal.TabIndex = 19;
			this.labelMstCreatedKruskal.Text = "MST Created:";
			// 
			// listBoxMstCreatedKruskal
			// 
			this.listBoxMstCreatedKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxMstCreatedKruskal.FormattingEnabled = true;
			this.listBoxMstCreatedKruskal.ItemHeight = 20;
			this.listBoxMstCreatedKruskal.Location = new System.Drawing.Point(834, 279);
			this.listBoxMstCreatedKruskal.Name = "listBoxMstCreatedKruskal";
			this.listBoxMstCreatedKruskal.Size = new System.Drawing.Size(124, 24);
			this.listBoxMstCreatedKruskal.TabIndex = 20;
			// 
			// treeViewMstPrim
			// 
			this.treeViewMstPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.treeViewMstPrim.Location = new System.Drawing.Point(715, 344);
			this.treeViewMstPrim.Name = "treeViewMstPrim";
			this.treeViewMstPrim.Size = new System.Drawing.Size(243, 204);
			this.treeViewMstPrim.TabIndex = 21;
			// 
			// labelWeigthPrim
			// 
			this.labelWeigthPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWeigthPrim.Location = new System.Drawing.Point(716, 555);
			this.labelWeigthPrim.Name = "labelWeigthPrim";
			this.labelWeigthPrim.Size = new System.Drawing.Size(81, 23);
			this.labelWeigthPrim.TabIndex = 22;
			this.labelWeigthPrim.Text = "Weight: ";
			// 
			// labelMstCreatedPrim
			// 
			this.labelMstCreatedPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMstCreatedPrim.Location = new System.Drawing.Point(716, 592);
			this.labelMstCreatedPrim.Name = "labelMstCreatedPrim";
			this.labelMstCreatedPrim.Size = new System.Drawing.Size(129, 23);
			this.labelMstCreatedPrim.TabIndex = 23;
			this.labelMstCreatedPrim.Text = "MST Created:";
			// 
			// listBoxWeightPrim
			// 
			this.listBoxWeightPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxWeightPrim.FormattingEnabled = true;
			this.listBoxWeightPrim.ItemHeight = 20;
			this.listBoxWeightPrim.Location = new System.Drawing.Point(792, 554);
			this.listBoxWeightPrim.Name = "listBoxWeightPrim";
			this.listBoxWeightPrim.Size = new System.Drawing.Size(265, 24);
			this.listBoxWeightPrim.TabIndex = 24;
			// 
			// listBoxMstCreatedPrim
			// 
			this.listBoxMstCreatedPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxMstCreatedPrim.FormattingEnabled = true;
			this.listBoxMstCreatedPrim.ItemHeight = 20;
			this.listBoxMstCreatedPrim.Location = new System.Drawing.Point(834, 591);
			this.listBoxMstCreatedPrim.Name = "listBoxMstCreatedPrim";
			this.listBoxMstCreatedPrim.Size = new System.Drawing.Size(124, 24);
			this.listBoxMstCreatedPrim.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(507, 490);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 45);
			this.label1.TabIndex = 26;
			this.label1.Text = "Write a number vertex to start Prim\'s algorithm";
			// 
			// buttonExecutePrim
			// 
			this.buttonExecutePrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExecutePrim.Location = new System.Drawing.Point(525, 584);
			this.buttonExecutePrim.Name = "buttonExecutePrim";
			this.buttonExecutePrim.Size = new System.Drawing.Size(141, 31);
			this.buttonExecutePrim.TabIndex = 27;
			this.buttonExecutePrim.Text = "Execute Prim";
			this.buttonExecutePrim.UseVisualStyleBackColor = true;
			this.buttonExecutePrim.Click += new System.EventHandler(this.ButtonExecutePrimClick);
			// 
			// textBoxStartVertexPrim
			// 
			this.textBoxStartVertexPrim.Location = new System.Drawing.Point(542, 538);
			this.textBoxStartVertexPrim.Name = "textBoxStartVertexPrim";
			this.textBoxStartVertexPrim.Size = new System.Drawing.Size(100, 26);
			this.textBoxStartVertexPrim.TabIndex = 28;
			// 
			// comboBoxSelectAlgorithmToShow
			// 
			this.comboBoxSelectAlgorithmToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxSelectAlgorithmToShow.FormattingEnabled = true;
			this.comboBoxSelectAlgorithmToShow.Items.AddRange(new object[] {
			"Original",
			"Kruskal",
			"Prim",
			"Both",
			"Graph"});
			this.comboBoxSelectAlgorithmToShow.Location = new System.Drawing.Point(35, 536);
			this.comboBoxSelectAlgorithmToShow.Name = "comboBoxSelectAlgorithmToShow";
			this.comboBoxSelectAlgorithmToShow.Size = new System.Drawing.Size(162, 28);
			this.comboBoxSelectAlgorithmToShow.TabIndex = 29;
			this.comboBoxSelectAlgorithmToShow.Text = "Original";
			// 
			// buttonShowRepresentation
			// 
			this.buttonShowRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowRepresentation.Location = new System.Drawing.Point(35, 570);
			this.buttonShowRepresentation.Name = "buttonShowRepresentation";
			this.buttonShowRepresentation.Size = new System.Drawing.Size(162, 26);
			this.buttonShowRepresentation.TabIndex = 30;
			this.buttonShowRepresentation.Text = "show representation";
			this.buttonShowRepresentation.UseVisualStyleBackColor = true;
			this.buttonShowRepresentation.Click += new System.EventHandler(this.ButtonShowRepresentationClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 641);
			this.Controls.Add(this.buttonShowRepresentation);
			this.Controls.Add(this.comboBoxSelectAlgorithmToShow);
			this.Controls.Add(this.textBoxStartVertexPrim);
			this.Controls.Add(this.buttonExecutePrim);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxMstCreatedPrim);
			this.Controls.Add(this.listBoxWeightPrim);
			this.Controls.Add(this.labelMstCreatedPrim);
			this.Controls.Add(this.labelWeigthPrim);
			this.Controls.Add(this.treeViewMstPrim);
			this.Controls.Add(this.listBoxMstCreatedKruskal);
			this.Controls.Add(this.labelMstCreatedKruskal);
			this.Controls.Add(this.listBoxWeightKruskal);
			this.Controls.Add(this.labelWeightKruskal);
			this.Controls.Add(this.treeViewMstKruskal);
			this.Controls.Add(this.labelOrderEdgesPrim);
			this.Controls.Add(this.listBoxPrim);
			this.Controls.Add(this.labelPrim);
			this.Controls.Add(this.labelOrderOfEdgesKruskal);
			this.Controls.Add(this.treeViewGraph);
			this.Controls.Add(this.labelSelectImage);
			this.Controls.Add(this.listBoxKruskalEdges);
			this.Controls.Add(this.labelKruskal);
			this.Controls.Add(this.labelGraphDesc);
			this.Controls.Add(this.buttonAnalize);
			this.Controls.Add(this.buttonShowImage);
			this.Controls.Add(this.pictureBoxShowImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "MainForm";
			this.Text = "Minimum Spanning Trees";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
