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
		private System.Windows.Forms.Label labelSelectImage;
		private System.Windows.Forms.TreeView treeViewGraph;
		private System.Windows.Forms.ComboBox comboBoxSelectAlgorithmToShow;
		private System.Windows.Forms.Button buttonShowRepresentation;
		private System.Windows.Forms.ListBox listBoxShortestPaths;
		private System.Windows.Forms.Label labelAllPaths;
		private System.Windows.Forms.ComboBox comboBoxDestinations;
		private System.Windows.Forms.Button buttonShowPath;
		private System.Windows.Forms.Label labelSeePath;
		private System.Windows.Forms.Label labelDestination;
		private System.Windows.Forms.Label label1;
		
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
			this.labelSelectImage = new System.Windows.Forms.Label();
			this.treeViewGraph = new System.Windows.Forms.TreeView();
			this.comboBoxSelectAlgorithmToShow = new System.Windows.Forms.ComboBox();
			this.buttonShowRepresentation = new System.Windows.Forms.Button();
			this.listBoxShortestPaths = new System.Windows.Forms.ListBox();
			this.labelAllPaths = new System.Windows.Forms.Label();
			this.comboBoxDestinations = new System.Windows.Forms.ComboBox();
			this.buttonShowPath = new System.Windows.Forms.Button();
			this.labelSeePath = new System.Windows.Forms.Label();
			this.labelDestination = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxShowImage
			// 
			this.pictureBoxShowImage.Location = new System.Drawing.Point(14, 14);
			this.pictureBoxShowImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBoxShowImage.Name = "pictureBoxShowImage";
			this.pictureBoxShowImage.Size = new System.Drawing.Size(679, 463);
			this.pictureBoxShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxShowImage.TabIndex = 0;
			this.pictureBoxShowImage.TabStop = false;
			this.pictureBoxShowImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxShowImageMouseClick);
			// 
			// buttonShowImage
			// 
			this.buttonShowImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowImage.Location = new System.Drawing.Point(800, 9);
			this.buttonShowImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.buttonAnalize.Location = new System.Drawing.Point(878, 9);
			this.buttonAnalize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.labelGraphDesc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelGraphDesc.Location = new System.Drawing.Point(703, 44);
			this.labelGraphDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelGraphDesc.Name = "labelGraphDesc";
			this.labelGraphDesc.Size = new System.Drawing.Size(161, 21);
			this.labelGraphDesc.TabIndex = 6;
			this.labelGraphDesc.Text = "General Graph(s) ";
			// 
			// labelSelectImage
			// 
			this.labelSelectImage.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelSelectImage.Location = new System.Drawing.Point(729, 14);
			this.labelSelectImage.Name = "labelSelectImage";
			this.labelSelectImage.Size = new System.Drawing.Size(63, 23);
			this.labelSelectImage.TabIndex = 9;
			this.labelSelectImage.Text = "Select";
			// 
			// treeViewGraph
			// 
			this.treeViewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeViewGraph.Location = new System.Drawing.Point(706, 68);
			this.treeViewGraph.Name = "treeViewGraph";
			this.treeViewGraph.Size = new System.Drawing.Size(271, 143);
			this.treeViewGraph.TabIndex = 11;
			// 
			// comboBoxSelectAlgorithmToShow
			// 
			this.comboBoxSelectAlgorithmToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxSelectAlgorithmToShow.FormattingEnabled = true;
			this.comboBoxSelectAlgorithmToShow.Items.AddRange(new object[] {
			"Original",
			"Graph"});
			this.comboBoxSelectAlgorithmToShow.Location = new System.Drawing.Point(706, 482);
			this.comboBoxSelectAlgorithmToShow.Name = "comboBoxSelectAlgorithmToShow";
			this.comboBoxSelectAlgorithmToShow.Size = new System.Drawing.Size(86, 28);
			this.comboBoxSelectAlgorithmToShow.TabIndex = 29;
			this.comboBoxSelectAlgorithmToShow.Text = "Original";
			// 
			// buttonShowRepresentation
			// 
			this.buttonShowRepresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowRepresentation.Location = new System.Drawing.Point(807, 482);
			this.buttonShowRepresentation.Name = "buttonShowRepresentation";
			this.buttonShowRepresentation.Size = new System.Drawing.Size(162, 26);
			this.buttonShowRepresentation.TabIndex = 30;
			this.buttonShowRepresentation.Text = "show representation";
			this.buttonShowRepresentation.UseVisualStyleBackColor = true;
			this.buttonShowRepresentation.Click += new System.EventHandler(this.ButtonShowRepresentationClick);
			// 
			// listBoxShortestPaths
			// 
			this.listBoxShortestPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxShortestPaths.FormattingEnabled = true;
			this.listBoxShortestPaths.ItemHeight = 20;
			this.listBoxShortestPaths.Location = new System.Drawing.Point(706, 260);
			this.listBoxShortestPaths.Name = "listBoxShortestPaths";
			this.listBoxShortestPaths.Size = new System.Drawing.Size(268, 144);
			this.listBoxShortestPaths.TabIndex = 34;
			// 
			// labelAllPaths
			// 
			this.labelAllPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAllPaths.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelAllPaths.Location = new System.Drawing.Point(729, 234);
			this.labelAllPaths.Name = "labelAllPaths";
			this.labelAllPaths.Size = new System.Drawing.Size(228, 23);
			this.labelAllPaths.TabIndex = 35;
			this.labelAllPaths.Text = "All shortest paths from source";
			// 
			// comboBoxDestinations
			// 
			this.comboBoxDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDestinations.FormattingEnabled = true;
			this.comboBoxDestinations.Location = new System.Drawing.Point(807, 433);
			this.comboBoxDestinations.Name = "comboBoxDestinations";
			this.comboBoxDestinations.Size = new System.Drawing.Size(76, 28);
			this.comboBoxDestinations.TabIndex = 36;
			this.comboBoxDestinations.Text = "select ";
			// 
			// buttonShowPath
			// 
			this.buttonShowPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowPath.Location = new System.Drawing.Point(889, 433);
			this.buttonShowPath.Name = "buttonShowPath";
			this.buttonShowPath.Size = new System.Drawing.Size(74, 28);
			this.buttonShowPath.TabIndex = 37;
			this.buttonShowPath.Text = "show";
			this.buttonShowPath.UseVisualStyleBackColor = true;
			this.buttonShowPath.Click += new System.EventHandler(this.ButtonShowPathClick);
			// 
			// labelSeePath
			// 
			this.labelSeePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSeePath.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelSeePath.Location = new System.Drawing.Point(800, 407);
			this.labelSeePath.Name = "labelSeePath";
			this.labelSeePath.Size = new System.Drawing.Size(83, 23);
			this.labelSeePath.TabIndex = 38;
			this.labelSeePath.Text = "See path";
			// 
			// labelDestination
			// 
			this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDestination.Location = new System.Drawing.Point(703, 435);
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.Size = new System.Drawing.Size(98, 23);
			this.labelDestination.TabIndex = 39;
			this.labelDestination.Text = "Destination:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(104, 487);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(504, 23);
			this.label1.TabIndex = 40;
			this.label1.Text = "One click to place a particula, second click to start tour animation";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(989, 523);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelDestination);
			this.Controls.Add(this.labelSeePath);
			this.Controls.Add(this.buttonShowPath);
			this.Controls.Add(this.comboBoxDestinations);
			this.Controls.Add(this.labelAllPaths);
			this.Controls.Add(this.listBoxShortestPaths);
			this.Controls.Add(this.buttonShowRepresentation);
			this.Controls.Add(this.comboBoxSelectAlgorithmToShow);
			this.Controls.Add(this.treeViewGraph);
			this.Controls.Add(this.labelSelectImage);
			this.Controls.Add(this.labelGraphDesc);
			this.Controls.Add(this.buttonAnalize);
			this.Controls.Add(this.buttonShowImage);
			this.Controls.Add(this.pictureBoxShowImage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "Dijkstra";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowImage)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
