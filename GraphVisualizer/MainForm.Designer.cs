namespace GraphVisualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IncidencyTabPage = new System.Windows.Forms.TabPage();
            this.IncidencyMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjacencyTabPage = new System.Windows.Forms.TabPage();
            this.AdjacencyMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HamiltonTabPage = new System.Windows.Forms.TabPage();
            this.MedianSearchButton = new System.Windows.Forms.Button();
            this.CenterSearchButton = new System.Windows.Forms.Button();
            this.HamiltonLengthLabel = new System.Windows.Forms.Label();
            this.HamiltonResultLabel = new System.Windows.Forms.Label();
            this.ExecuteHamiltonButton = new System.Windows.Forms.Button();
            this.DijkstraTabPage = new System.Windows.Forms.TabPage();
            this.DijkstraMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteDijkstrasAlgorithmButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GraphViewTabPage = new System.Windows.Forms.TabPage();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.Decrease_Scale = new System.Windows.Forms.Button();
            this.Increase_Scale = new System.Windows.Forms.Button();
            this.DrawPrimButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DrawGraphButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MatrixOfWeightsTabPage = new System.Windows.Forms.TabPage();
            this.AddNodeToMatrixButton = new System.Windows.Forms.Button();
            this.SaveMatrixButton = new System.Windows.Forms.Button();
            this.MatrixOfWeightsDataGridView = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableTabPage = new System.Windows.Forms.TabPage();
            this.AddConnectionButton = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.NodeConnectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.TabView = new System.Windows.Forms.TabControl();
            this.IncidencyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncidencyMatrixDataGridView)).BeginInit();
            this.AdjacencyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixDataGridView)).BeginInit();
            this.HamiltonTabPage.SuspendLayout();
            this.DijkstraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DijkstraMatrixDataGridView)).BeginInit();
            this.GraphViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MatrixOfWeightsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfWeightsDataGridView)).BeginInit();
            this.TableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeConnectionsDataGridView)).BeginInit();
            this.TabView.SuspendLayout();
            this.SuspendLayout();
            // 
            // IncidencyTabPage
            // 
            this.IncidencyTabPage.Controls.Add(this.IncidencyMatrixDataGridView);
            this.IncidencyTabPage.Location = new System.Drawing.Point(4, 25);
            this.IncidencyTabPage.Name = "IncidencyTabPage";
            this.IncidencyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IncidencyTabPage.Size = new System.Drawing.Size(977, 532);
            this.IncidencyTabPage.TabIndex = 8;
            this.IncidencyTabPage.Text = "Incidency";
            this.IncidencyTabPage.UseVisualStyleBackColor = true;
            // 
            // IncidencyMatrixDataGridView
            // 
            this.IncidencyMatrixDataGridView.AllowUserToAddRows = false;
            this.IncidencyMatrixDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.IncidencyMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidencyMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.IncidencyMatrixDataGridView.Location = new System.Drawing.Point(0, 0);
            this.IncidencyMatrixDataGridView.Name = "IncidencyMatrixDataGridView";
            this.IncidencyMatrixDataGridView.Size = new System.Drawing.Size(977, 530);
            this.IncidencyMatrixDataGridView.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // AdjacencyTabPage
            // 
            this.AdjacencyTabPage.Controls.Add(this.AdjacencyMatrixDataGridView);
            this.AdjacencyTabPage.Location = new System.Drawing.Point(4, 25);
            this.AdjacencyTabPage.Name = "AdjacencyTabPage";
            this.AdjacencyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdjacencyTabPage.Size = new System.Drawing.Size(977, 532);
            this.AdjacencyTabPage.TabIndex = 7;
            this.AdjacencyTabPage.Text = "Adjacency";
            this.AdjacencyTabPage.UseVisualStyleBackColor = true;
            // 
            // AdjacencyMatrixDataGridView
            // 
            this.AdjacencyMatrixDataGridView.AllowUserToAddRows = false;
            this.AdjacencyMatrixDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.AdjacencyMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.AdjacencyMatrixDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AdjacencyMatrixDataGridView.Name = "AdjacencyMatrixDataGridView";
            this.AdjacencyMatrixDataGridView.Size = new System.Drawing.Size(977, 530);
            this.AdjacencyMatrixDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // HamiltonTabPage
            // 
            this.HamiltonTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.HamiltonTabPage.Controls.Add(this.MedianSearchButton);
            this.HamiltonTabPage.Controls.Add(this.CenterSearchButton);
            this.HamiltonTabPage.Controls.Add(this.HamiltonLengthLabel);
            this.HamiltonTabPage.Controls.Add(this.HamiltonResultLabel);
            this.HamiltonTabPage.Controls.Add(this.ExecuteHamiltonButton);
            this.HamiltonTabPage.Location = new System.Drawing.Point(4, 25);
            this.HamiltonTabPage.Name = "HamiltonTabPage";
            this.HamiltonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HamiltonTabPage.Size = new System.Drawing.Size(977, 532);
            this.HamiltonTabPage.TabIndex = 6;
            this.HamiltonTabPage.Text = "Hamilton";
            // 
            // MedianSearchButton
            // 
            this.MedianSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.MedianSearchButton.FlatAppearance.BorderSize = 0;
            this.MedianSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedianSearchButton.Location = new System.Drawing.Point(889, 68);
            this.MedianSearchButton.Name = "MedianSearchButton";
            this.MedianSearchButton.Size = new System.Drawing.Size(80, 25);
            this.MedianSearchButton.TabIndex = 4;
            this.MedianSearchButton.Text = "Median";
            this.MedianSearchButton.UseVisualStyleBackColor = false;
            this.MedianSearchButton.Click += new System.EventHandler(this.MedianSearchButton_Click);
            // 
            // CenterSearchButton
            // 
            this.CenterSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.CenterSearchButton.FlatAppearance.BorderSize = 0;
            this.CenterSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterSearchButton.Location = new System.Drawing.Point(889, 37);
            this.CenterSearchButton.Name = "CenterSearchButton";
            this.CenterSearchButton.Size = new System.Drawing.Size(80, 25);
            this.CenterSearchButton.TabIndex = 3;
            this.CenterSearchButton.Text = "Center";
            this.CenterSearchButton.UseVisualStyleBackColor = false;
            this.CenterSearchButton.Click += new System.EventHandler(this.CenterSearchButton_Click);
            // 
            // HamiltonLengthLabel
            // 
            this.HamiltonLengthLabel.AutoSize = true;
            this.HamiltonLengthLabel.Location = new System.Drawing.Point(6, 62);
            this.HamiltonLengthLabel.Name = "HamiltonLengthLabel";
            this.HamiltonLengthLabel.Size = new System.Drawing.Size(130, 13);
            this.HamiltonLengthLabel.TabIndex = 2;
            this.HamiltonLengthLabel.Text = "Length will be shown here";
            // 
            // HamiltonResultLabel
            // 
            this.HamiltonResultLabel.AutoSize = true;
            this.HamiltonResultLabel.Location = new System.Drawing.Point(6, 32);
            this.HamiltonResultLabel.Name = "HamiltonResultLabel";
            this.HamiltonResultLabel.Size = new System.Drawing.Size(127, 13);
            this.HamiltonResultLabel.TabIndex = 1;
            this.HamiltonResultLabel.Text = "Result will be shown here";
            // 
            // ExecuteHamiltonButton
            // 
            this.ExecuteHamiltonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.ExecuteHamiltonButton.FlatAppearance.BorderSize = 0;
            this.ExecuteHamiltonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteHamiltonButton.Location = new System.Drawing.Point(889, 6);
            this.ExecuteHamiltonButton.Name = "ExecuteHamiltonButton";
            this.ExecuteHamiltonButton.Size = new System.Drawing.Size(80, 25);
            this.ExecuteHamiltonButton.TabIndex = 0;
            this.ExecuteHamiltonButton.Text = "Hamilton";
            this.ExecuteHamiltonButton.UseVisualStyleBackColor = false;
            this.ExecuteHamiltonButton.Click += new System.EventHandler(this.ExecuteHamiltonButtonClick);
            // 
            // DijkstraTabPage
            // 
            this.DijkstraTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.DijkstraTabPage.Controls.Add(this.DijkstraMatrixDataGridView);
            this.DijkstraTabPage.Controls.Add(this.ExecuteDijkstrasAlgorithmButton);
            this.DijkstraTabPage.Controls.Add(this.textBox2);
            this.DijkstraTabPage.Location = new System.Drawing.Point(4, 25);
            this.DijkstraTabPage.Name = "DijkstraTabPage";
            this.DijkstraTabPage.Size = new System.Drawing.Size(977, 532);
            this.DijkstraTabPage.TabIndex = 3;
            this.DijkstraTabPage.Text = "Dijkstra";
            // 
            // DijkstraMatrixDataGridView
            // 
            this.DijkstraMatrixDataGridView.AllowUserToAddRows = false;
            this.DijkstraMatrixDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.DijkstraMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DijkstraMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.DijkstraMatrixDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DijkstraMatrixDataGridView.Name = "DijkstraMatrixDataGridView";
            this.DijkstraMatrixDataGridView.Size = new System.Drawing.Size(880, 530);
            this.DijkstraMatrixDataGridView.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // ExecuteDijkstrasAlgorithmButton
            // 
            this.ExecuteDijkstrasAlgorithmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.ExecuteDijkstrasAlgorithmButton.FlatAppearance.BorderSize = 0;
            this.ExecuteDijkstrasAlgorithmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteDijkstrasAlgorithmButton.Location = new System.Drawing.Point(889, 6);
            this.ExecuteDijkstrasAlgorithmButton.Name = "ExecuteDijkstrasAlgorithmButton";
            this.ExecuteDijkstrasAlgorithmButton.Size = new System.Drawing.Size(80, 25);
            this.ExecuteDijkstrasAlgorithmButton.TabIndex = 1;
            this.ExecuteDijkstrasAlgorithmButton.Text = "Execute";
            this.ExecuteDijkstrasAlgorithmButton.UseVisualStyleBackColor = false;
            this.ExecuteDijkstrasAlgorithmButton.Click += new System.EventHandler(this.ExecuteDijkstrasAlgorithmButtonClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(889, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 0;
            // 
            // GraphViewTabPage
            // 
            this.GraphViewTabPage.Controls.Add(this.MoveLeft);
            this.GraphViewTabPage.Controls.Add(this.MoveDown);
            this.GraphViewTabPage.Controls.Add(this.MoveUp);
            this.GraphViewTabPage.Controls.Add(this.MoveRight);
            this.GraphViewTabPage.Controls.Add(this.Decrease_Scale);
            this.GraphViewTabPage.Controls.Add(this.Increase_Scale);
            this.GraphViewTabPage.Controls.Add(this.DrawPrimButton);
            this.GraphViewTabPage.Controls.Add(this.textBox1);
            this.GraphViewTabPage.Controls.Add(this.DrawGraphButton);
            this.GraphViewTabPage.Controls.Add(this.pictureBox1);
            this.GraphViewTabPage.Location = new System.Drawing.Point(4, 25);
            this.GraphViewTabPage.Name = "GraphViewTabPage";
            this.GraphViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GraphViewTabPage.Size = new System.Drawing.Size(977, 532);
            this.GraphViewTabPage.TabIndex = 2;
            this.GraphViewTabPage.Text = "Graph view";
            this.GraphViewTabPage.UseVisualStyleBackColor = true;
            // 
            // MoveLeft
            // 
            this.MoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.MoveLeft.FlatAppearance.BorderSize = 0;
            this.MoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLeft.Location = new System.Drawing.Point(889, 200);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(80, 25);
            this.MoveLeft.TabIndex = 10;
            this.MoveLeft.Text = "←";
            this.MoveLeft.UseVisualStyleBackColor = false;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.MoveDown.FlatAppearance.BorderSize = 0;
            this.MoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDown.Location = new System.Drawing.Point(889, 293);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(80, 25);
            this.MoveDown.TabIndex = 9;
            this.MoveDown.Text = "↓";
            this.MoveDown.UseVisualStyleBackColor = false;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.MoveUp.FlatAppearance.BorderSize = 0;
            this.MoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUp.Location = new System.Drawing.Point(889, 262);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(80, 25);
            this.MoveUp.TabIndex = 8;
            this.MoveUp.Text = "↑";
            this.MoveUp.UseVisualStyleBackColor = false;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.MoveRight.FlatAppearance.BorderSize = 0;
            this.MoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveRight.Location = new System.Drawing.Point(889, 231);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(80, 25);
            this.MoveRight.TabIndex = 7;
            this.MoveRight.Text = "→";
            this.MoveRight.UseVisualStyleBackColor = false;
            this.MoveRight.Click += new System.EventHandler(this.MoveRightBtn_Click);
            // 
            // Decrease_Scale
            // 
            this.Decrease_Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.Decrease_Scale.FlatAppearance.BorderSize = 0;
            this.Decrease_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrease_Scale.Location = new System.Drawing.Point(889, 499);
            this.Decrease_Scale.Name = "Decrease_Scale";
            this.Decrease_Scale.Size = new System.Drawing.Size(80, 25);
            this.Decrease_Scale.TabIndex = 6;
            this.Decrease_Scale.Text = "-";
            this.Decrease_Scale.UseVisualStyleBackColor = false;
            this.Decrease_Scale.Click += new System.EventHandler(this.Decrease_Scale_Click);
            // 
            // Increase_Scale
            // 
            this.Increase_Scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.Increase_Scale.FlatAppearance.BorderSize = 0;
            this.Increase_Scale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increase_Scale.Location = new System.Drawing.Point(889, 468);
            this.Increase_Scale.Name = "Increase_Scale";
            this.Increase_Scale.Size = new System.Drawing.Size(80, 25);
            this.Increase_Scale.TabIndex = 5;
            this.Increase_Scale.Text = "+";
            this.Increase_Scale.UseVisualStyleBackColor = false;
            this.Increase_Scale.Click += new System.EventHandler(this.Increase_Scale_Click_1);
            // 
            // DrawPrimButton
            // 
            this.DrawPrimButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.DrawPrimButton.FlatAppearance.BorderSize = 0;
            this.DrawPrimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawPrimButton.Location = new System.Drawing.Point(889, 81);
            this.DrawPrimButton.Name = "DrawPrimButton";
            this.DrawPrimButton.Size = new System.Drawing.Size(80, 25);
            this.DrawPrimButton.TabIndex = 3;
            this.DrawPrimButton.Text = "Prim";
            this.DrawPrimButton.UseVisualStyleBackColor = false;
            this.DrawPrimButton.Click += new System.EventHandler(this.DrawPrimButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(889, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 2;
            // 
            // DrawGraphButton
            // 
            this.DrawGraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.DrawGraphButton.FlatAppearance.BorderSize = 0;
            this.DrawGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawGraphButton.Location = new System.Drawing.Point(889, 6);
            this.DrawGraphButton.Name = "DrawGraphButton";
            this.DrawGraphButton.Size = new System.Drawing.Size(80, 25);
            this.DrawGraphButton.TabIndex = 1;
            this.DrawGraphButton.Text = "Draw graph";
            this.DrawGraphButton.UseVisualStyleBackColor = false;
            this.DrawGraphButton.Click += new System.EventHandler(this.DrawGraphButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(977, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MatrixOfWeightsTabPage
            // 
            this.MatrixOfWeightsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.MatrixOfWeightsTabPage.Controls.Add(this.AddNodeToMatrixButton);
            this.MatrixOfWeightsTabPage.Controls.Add(this.SaveMatrixButton);
            this.MatrixOfWeightsTabPage.Controls.Add(this.MatrixOfWeightsDataGridView);
            this.MatrixOfWeightsTabPage.Location = new System.Drawing.Point(4, 25);
            this.MatrixOfWeightsTabPage.Name = "MatrixOfWeightsTabPage";
            this.MatrixOfWeightsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MatrixOfWeightsTabPage.Size = new System.Drawing.Size(977, 532);
            this.MatrixOfWeightsTabPage.TabIndex = 1;
            this.MatrixOfWeightsTabPage.Text = "Matrix view";
            // 
            // AddNodeToMatrixButton
            // 
            this.AddNodeToMatrixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.AddNodeToMatrixButton.FlatAppearance.BorderSize = 0;
            this.AddNodeToMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNodeToMatrixButton.Location = new System.Drawing.Point(889, 37);
            this.AddNodeToMatrixButton.Name = "AddNodeToMatrixButton";
            this.AddNodeToMatrixButton.Size = new System.Drawing.Size(80, 25);
            this.AddNodeToMatrixButton.TabIndex = 2;
            this.AddNodeToMatrixButton.Text = "Add vertex";
            this.AddNodeToMatrixButton.UseVisualStyleBackColor = false;
            this.AddNodeToMatrixButton.Click += new System.EventHandler(this.AddNodeToMatrixButtonClick);
            // 
            // SaveMatrixButton
            // 
            this.SaveMatrixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.SaveMatrixButton.FlatAppearance.BorderSize = 0;
            this.SaveMatrixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveMatrixButton.Location = new System.Drawing.Point(889, 6);
            this.SaveMatrixButton.Name = "SaveMatrixButton";
            this.SaveMatrixButton.Size = new System.Drawing.Size(80, 25);
            this.SaveMatrixButton.TabIndex = 1;
            this.SaveMatrixButton.Text = "Save";
            this.SaveMatrixButton.UseVisualStyleBackColor = false;
            this.SaveMatrixButton.Click += new System.EventHandler(this.SaveMatrixButtonClick);
            // 
            // MatrixOfWeightsDataGridView
            // 
            this.MatrixOfWeightsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.MatrixOfWeightsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.MatrixOfWeightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixOfWeightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1});
            this.MatrixOfWeightsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MatrixOfWeightsDataGridView.Name = "MatrixOfWeightsDataGridView";
            this.MatrixOfWeightsDataGridView.RowHeadersWidth = 51;
            this.MatrixOfWeightsDataGridView.Size = new System.Drawing.Size(880, 530);
            this.MatrixOfWeightsDataGridView.TabIndex = 0;
            // 
            // x1
            // 
            this.x1.HeaderText = "X";
            this.x1.MinimumWidth = 6;
            this.x1.Name = "x1";
            this.x1.Width = 39;
            // 
            // TableTabPage
            // 
            this.TableTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TableTabPage.Controls.Add(this.AddConnectionButton);
            this.TableTabPage.Controls.Add(this.button_Save);
            this.TableTabPage.Controls.Add(this.NodeConnectionsDataGridView);
            this.TableTabPage.Location = new System.Drawing.Point(4, 25);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TableTabPage.Size = new System.Drawing.Size(977, 532);
            this.TableTabPage.TabIndex = 0;
            this.TableTabPage.Text = "Table view";
            // 
            // AddConnectionButton
            // 
            this.AddConnectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.AddConnectionButton.FlatAppearance.BorderSize = 0;
            this.AddConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConnectionButton.Location = new System.Drawing.Point(889, 37);
            this.AddConnectionButton.Name = "AddConnectionButton";
            this.AddConnectionButton.Size = new System.Drawing.Size(80, 25);
            this.AddConnectionButton.TabIndex = 2;
            this.AddConnectionButton.Text = "Add edge";
            this.AddConnectionButton.UseVisualStyleBackColor = false;
            this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButtonClick);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(889, 6);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 25);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // NodeConnectionsDataGridView
            // 
            this.NodeConnectionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.NodeConnectionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.NodeConnectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeConnectionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.NodeConnectionsDataGridView.Name = "NodeConnectionsDataGridView";
            this.NodeConnectionsDataGridView.RowHeadersWidth = 51;
            this.NodeConnectionsDataGridView.Size = new System.Drawing.Size(880, 530);
            this.NodeConnectionsDataGridView.TabIndex = 0;
            // 
            // TabView
            // 
            this.TabView.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabView.Controls.Add(this.TableTabPage);
            this.TabView.Controls.Add(this.MatrixOfWeightsTabPage);
            this.TabView.Controls.Add(this.DijkstraTabPage);
            this.TabView.Controls.Add(this.HamiltonTabPage);
            this.TabView.Controls.Add(this.GraphViewTabPage);
            this.TabView.Controls.Add(this.AdjacencyTabPage);
            this.TabView.Controls.Add(this.IncidencyTabPage);
            this.TabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabView.Location = new System.Drawing.Point(0, 0);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(985, 561);
            this.TabView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(985, 561);
            this.Controls.Add(this.TabView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix analyzer";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.IncidencyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncidencyMatrixDataGridView)).EndInit();
            this.AdjacencyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixDataGridView)).EndInit();
            this.HamiltonTabPage.ResumeLayout(false);
            this.HamiltonTabPage.PerformLayout();
            this.DijkstraTabPage.ResumeLayout(false);
            this.DijkstraTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DijkstraMatrixDataGridView)).EndInit();
            this.GraphViewTabPage.ResumeLayout(false);
            this.GraphViewTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MatrixOfWeightsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfWeightsDataGridView)).EndInit();
            this.TableTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NodeConnectionsDataGridView)).EndInit();
            this.TabView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage IncidencyTabPage;
        private System.Windows.Forms.DataGridView IncidencyMatrixDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TabPage AdjacencyTabPage;
        private System.Windows.Forms.DataGridView AdjacencyMatrixDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage HamiltonTabPage;
        private System.Windows.Forms.Label HamiltonLengthLabel;
        private System.Windows.Forms.Label HamiltonResultLabel;
        private System.Windows.Forms.Button ExecuteHamiltonButton;
        private System.Windows.Forms.TabPage DijkstraTabPage;
        private System.Windows.Forms.Button ExecuteDijkstrasAlgorithmButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage GraphViewTabPage;
        private System.Windows.Forms.Button DrawPrimButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DrawGraphButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage MatrixOfWeightsTabPage;
        private System.Windows.Forms.Button AddNodeToMatrixButton;
        private System.Windows.Forms.Button SaveMatrixButton;
        private System.Windows.Forms.DataGridView MatrixOfWeightsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.TabPage TableTabPage;
        private System.Windows.Forms.Button AddConnectionButton;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView NodeConnectionsDataGridView;
        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.Button CenterSearchButton;
        private System.Windows.Forms.DataGridView DijkstraMatrixDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Decrease_Scale;
        private System.Windows.Forms.Button Increase_Scale;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MedianSearchButton;
    }
}

