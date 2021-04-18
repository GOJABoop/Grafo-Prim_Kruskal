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
		private System.Windows.Forms.ListBox listBoxGraph;
		private System.Windows.Forms.Label labelGraphDesc;
		private System.Windows.Forms.Label labelClosestCircles;
		private System.Windows.Forms.ListBox listBoxClosestCircles;
		private System.Windows.Forms.Label labelSelectImage;
		private System.Windows.Forms.Label labelClickOnDesc;
		
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
			this.listBoxGraph = new System.Windows.Forms.ListBox();
			this.labelGraphDesc = new System.Windows.Forms.Label();
			this.labelClosestCircles = new System.Windows.Forms.Label();
			this.listBoxClosestCircles = new System.Windows.Forms.ListBox();
			this.labelSelectImage = new System.Windows.Forms.Label();
			this.labelClickOnDesc = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxShowImage
			// 
			this.pictureBoxShowImage.Location = new System.Drawing.Point(14, 14);
			this.pictureBoxShowImage.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBoxShowImage.Name = "pictureBoxShowImage";
			this.pictureBoxShowImage.Size = new System.Drawing.Size(679, 463);
			this.pictureBoxShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxShowImage.TabIndex = 0;
			this.pictureBoxShowImage.TabStop = false;
			// 
			// buttonShowImage
			// 
			this.buttonShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowImage.Location = new System.Drawing.Point(799, 9);
			this.buttonShowImage.Margin = new System.Windows.Forms.Padding(5);
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
			this.buttonAnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAnalize.Location = new System.Drawing.Point(993, 9);
			this.buttonAnalize.Margin = new System.Windows.Forms.Padding(5);
			this.buttonAnalize.Name = "buttonAnalize";
			this.buttonAnalize.Size = new System.Drawing.Size(70, 31);
			this.buttonAnalize.TabIndex = 2;
			this.buttonAnalize.Text = "analize";
			this.buttonAnalize.UseVisualStyleBackColor = true;
			this.buttonAnalize.Click += new System.EventHandler(this.ButtonAnalizeClick);
			// 
			// listBoxGraph
			// 
			this.listBoxGraph.Font = new System.Drawing.Font("Miriam Mono CLM", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.listBoxGraph.FormattingEnabled = true;
			this.listBoxGraph.ItemHeight = 19;
			this.listBoxGraph.Location = new System.Drawing.Point(701, 84);
			this.listBoxGraph.Margin = new System.Windows.Forms.Padding(5);
			this.listBoxGraph.Name = "listBoxGraph";
			this.listBoxGraph.Size = new System.Drawing.Size(374, 232);
			this.listBoxGraph.TabIndex = 3;
			// 
			// labelGraphDesc
			// 
			this.labelGraphDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGraphDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelGraphDesc.Location = new System.Drawing.Point(701, 55);
			this.labelGraphDesc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelGraphDesc.Name = "labelGraphDesc";
			this.labelGraphDesc.Size = new System.Drawing.Size(244, 24);
			this.labelGraphDesc.TabIndex = 6;
			this.labelGraphDesc.Text = "Graph (Vertices -> Edges)";
			// 
			// labelClosestCircles
			// 
			this.labelClosestCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelClosestCircles.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelClosestCircles.Location = new System.Drawing.Point(701, 334);
			this.labelClosestCircles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelClosestCircles.Name = "labelClosestCircles";
			this.labelClosestCircles.Size = new System.Drawing.Size(312, 27);
			this.labelClosestCircles.TabIndex = 7;
			this.labelClosestCircles.Text = "Pair of closest points";
			// 
			// listBoxClosestCircles
			// 
			this.listBoxClosestCircles.Font = new System.Drawing.Font("Miriam Mono CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.listBoxClosestCircles.FormattingEnabled = true;
			this.listBoxClosestCircles.ItemHeight = 18;
			this.listBoxClosestCircles.Location = new System.Drawing.Point(701, 364);
			this.listBoxClosestCircles.Name = "listBoxClosestCircles";
			this.listBoxClosestCircles.Size = new System.Drawing.Size(374, 94);
			this.listBoxClosestCircles.TabIndex = 8;
			// 
			// labelSelectImage
			// 
			this.labelSelectImage.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelSelectImage.Location = new System.Drawing.Point(701, 14);
			this.labelSelectImage.Name = "labelSelectImage";
			this.labelSelectImage.Size = new System.Drawing.Size(90, 23);
			this.labelSelectImage.TabIndex = 9;
			this.labelSelectImage.Text = "Select an";
			// 
			// labelClickOnDesc
			// 
			this.labelClickOnDesc.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelClickOnDesc.Location = new System.Drawing.Point(875, 14);
			this.labelClickOnDesc.Name = "labelClickOnDesc";
			this.labelClickOnDesc.Size = new System.Drawing.Size(110, 23);
			this.labelClickOnDesc.TabIndex = 10;
			this.labelClickOnDesc.Text = "and click on";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1091, 483);
			this.Controls.Add(this.labelClickOnDesc);
			this.Controls.Add(this.labelSelectImage);
			this.Controls.Add(this.listBoxClosestCircles);
			this.Controls.Add(this.labelClosestCircles);
			this.Controls.Add(this.labelGraphDesc);
			this.Controls.Add(this.listBoxGraph);
			this.Controls.Add(this.buttonAnalize);
			this.Controls.Add(this.buttonShowImage);
			this.Controls.Add(this.pictureBoxShowImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.Text = "pSALG";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
