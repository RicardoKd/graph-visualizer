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
            this.HamiltonLengthLabel = new System.Windows.Forms.Label();
            this.HamiltonResultLabel = new System.Windows.Forms.Label();
            this.ExecuteHamiltonButton = new System.Windows.Forms.Button();
            this.DijkstraTabPage = new System.Windows.Forms.TabPage();
            this.ExecuteDijkstrasAlgorithmButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GraphViewTabPage = new System.Windows.Forms.TabPage();
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
            this.CenterSearchButton = new System.Windows.Forms.Button();
            this.DijkstraMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncidencyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncidencyMatrixDataGridView)).BeginInit();
            this.AdjacencyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrixDataGridView)).BeginInit();
            this.HamiltonTabPage.SuspendLayout();
            this.DijkstraTabPage.SuspendLayout();
            this.GraphViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MatrixOfWeightsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfWeightsDataGridView)).BeginInit();
            this.TableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NodeConnectionsDataGridView)).BeginInit();
            this.TabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DijkstraMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IncidencyTabPage
            // 
            this.IncidencyTabPage.Controls.Add(this.IncidencyMatrixDataGridView);
            this.IncidencyTabPage.Location = new System.Drawing.Point(4, 22);
            this.IncidencyTabPage.Name = "IncidencyTabPage";
            this.IncidencyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IncidencyTabPage.Size = new System.Drawing.Size(952, 511);
            this.IncidencyTabPage.TabIndex = 8;
            this.IncidencyTabPage.Text = "Incidency";
            this.IncidencyTabPage.UseVisualStyleBackColor = true;
            // 
            // IncidencyMatrixDataGridView
            // 
            this.IncidencyMatrixDataGridView.AllowUserToAddRows = false;
            this.IncidencyMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidencyMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.IncidencyMatrixDataGridView.Location = new System.Drawing.Point(6, 6);
            this.IncidencyMatrixDataGridView.Name = "IncidencyMatrixDataGridView";
            this.IncidencyMatrixDataGridView.Size = new System.Drawing.Size(940, 499);
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
            this.AdjacencyTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdjacencyTabPage.Name = "AdjacencyTabPage";
            this.AdjacencyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdjacencyTabPage.Size = new System.Drawing.Size(952, 511);
            this.AdjacencyTabPage.TabIndex = 7;
            this.AdjacencyTabPage.Text = "Adjacency";
            this.AdjacencyTabPage.UseVisualStyleBackColor = true;
            // 
            // AdjacencyMatrixDataGridView
            // 
            this.AdjacencyMatrixDataGridView.AllowUserToAddRows = false;
            this.AdjacencyMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.AdjacencyMatrixDataGridView.Location = new System.Drawing.Point(6, 6);
            this.AdjacencyMatrixDataGridView.Name = "AdjacencyMatrixDataGridView";
            this.AdjacencyMatrixDataGridView.Size = new System.Drawing.Size(940, 499);
            this.AdjacencyMatrixDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // HamiltonTabPage
            // 
            this.HamiltonTabPage.Controls.Add(this.CenterSearchButton);
            this.HamiltonTabPage.Controls.Add(this.HamiltonLengthLabel);
            this.HamiltonTabPage.Controls.Add(this.HamiltonResultLabel);
            this.HamiltonTabPage.Controls.Add(this.ExecuteHamiltonButton);
            this.HamiltonTabPage.Location = new System.Drawing.Point(4, 22);
            this.HamiltonTabPage.Name = "HamiltonTabPage";
            this.HamiltonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HamiltonTabPage.Size = new System.Drawing.Size(952, 511);
            this.HamiltonTabPage.TabIndex = 6;
            this.HamiltonTabPage.Text = "Hamilton";
            this.HamiltonTabPage.UseVisualStyleBackColor = true;
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
            this.ExecuteHamiltonButton.Location = new System.Drawing.Point(861, 6);
            this.ExecuteHamiltonButton.Name = "ExecuteHamiltonButton";
            this.ExecuteHamiltonButton.Size = new System.Drawing.Size(85, 30);
            this.ExecuteHamiltonButton.TabIndex = 0;
            this.ExecuteHamiltonButton.Text = "Hamilton";
            this.ExecuteHamiltonButton.UseVisualStyleBackColor = true;
            this.ExecuteHamiltonButton.Click += new System.EventHandler(this.ExecuteHamiltonButtonClick);
            // 
            // DijkstraTabPage
            // 
            this.DijkstraTabPage.Controls.Add(this.DijkstraMatrixDataGridView);
            this.DijkstraTabPage.Controls.Add(this.ExecuteDijkstrasAlgorithmButton);
            this.DijkstraTabPage.Controls.Add(this.textBox2);
            this.DijkstraTabPage.Location = new System.Drawing.Point(4, 22);
            this.DijkstraTabPage.Name = "DijkstraTabPage";
            this.DijkstraTabPage.Size = new System.Drawing.Size(952, 511);
            this.DijkstraTabPage.TabIndex = 3;
            this.DijkstraTabPage.Text = "Dijkstra";
            this.DijkstraTabPage.UseVisualStyleBackColor = true;
            // 
            // ExecuteDijkstrasAlgorithmButton
            // 
            this.ExecuteDijkstrasAlgorithmButton.Location = new System.Drawing.Point(759, 29);
            this.ExecuteDijkstrasAlgorithmButton.Name = "ExecuteDijkstrasAlgorithmButton";
            this.ExecuteDijkstrasAlgorithmButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteDijkstrasAlgorithmButton.TabIndex = 1;
            this.ExecuteDijkstrasAlgorithmButton.Text = "Execute";
            this.ExecuteDijkstrasAlgorithmButton.UseVisualStyleBackColor = true;
            this.ExecuteDijkstrasAlgorithmButton.Click += new System.EventHandler(this.ExecuteDijkstrasAlgorithmButtonClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(840, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // GraphViewTabPage
            // 
            this.GraphViewTabPage.Controls.Add(this.DrawPrimButton);
            this.GraphViewTabPage.Controls.Add(this.textBox1);
            this.GraphViewTabPage.Controls.Add(this.DrawGraphButton);
            this.GraphViewTabPage.Controls.Add(this.pictureBox1);
            this.GraphViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.GraphViewTabPage.Name = "GraphViewTabPage";
            this.GraphViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GraphViewTabPage.Size = new System.Drawing.Size(952, 511);
            this.GraphViewTabPage.TabIndex = 2;
            this.GraphViewTabPage.Text = "Graph view";
            this.GraphViewTabPage.UseVisualStyleBackColor = true;
            // 
            // DrawPrimButton
            // 
            this.DrawPrimButton.Location = new System.Drawing.Point(871, 6);
            this.DrawPrimButton.Name = "DrawPrimButton";
            this.DrawPrimButton.Size = new System.Drawing.Size(75, 23);
            this.DrawPrimButton.TabIndex = 3;
            this.DrawPrimButton.Text = "Prim";
            this.DrawPrimButton.UseVisualStyleBackColor = true;
            this.DrawPrimButton.Click += new System.EventHandler(this.DrawPrimButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // DrawGraphButton
            // 
            this.DrawGraphButton.Location = new System.Drawing.Point(7, 7);
            this.DrawGraphButton.Name = "DrawGraphButton";
            this.DrawGraphButton.Size = new System.Drawing.Size(70, 25);
            this.DrawGraphButton.TabIndex = 1;
            this.DrawGraphButton.Text = "Draw graph";
            this.DrawGraphButton.UseVisualStyleBackColor = true;
            this.DrawGraphButton.Click += new System.EventHandler(this.DrawGraphButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(939, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MatrixOfWeightsTabPage
            // 
            this.MatrixOfWeightsTabPage.Controls.Add(this.AddNodeToMatrixButton);
            this.MatrixOfWeightsTabPage.Controls.Add(this.SaveMatrixButton);
            this.MatrixOfWeightsTabPage.Controls.Add(this.MatrixOfWeightsDataGridView);
            this.MatrixOfWeightsTabPage.Location = new System.Drawing.Point(4, 22);
            this.MatrixOfWeightsTabPage.Name = "MatrixOfWeightsTabPage";
            this.MatrixOfWeightsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MatrixOfWeightsTabPage.Size = new System.Drawing.Size(952, 511);
            this.MatrixOfWeightsTabPage.TabIndex = 1;
            this.MatrixOfWeightsTabPage.Text = "Matrix view";
            this.MatrixOfWeightsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddNodeToMatrixButton
            // 
            this.AddNodeToMatrixButton.Location = new System.Drawing.Point(871, 35);
            this.AddNodeToMatrixButton.Name = "AddNodeToMatrixButton";
            this.AddNodeToMatrixButton.Size = new System.Drawing.Size(75, 23);
            this.AddNodeToMatrixButton.TabIndex = 2;
            this.AddNodeToMatrixButton.Text = "Add vertex";
            this.AddNodeToMatrixButton.UseVisualStyleBackColor = true;
            this.AddNodeToMatrixButton.Click += new System.EventHandler(this.AddNodeToMatrixButtonClick);
            // 
            // SaveMatrixButton
            // 
            this.SaveMatrixButton.Location = new System.Drawing.Point(871, 6);
            this.SaveMatrixButton.Name = "SaveMatrixButton";
            this.SaveMatrixButton.Size = new System.Drawing.Size(75, 23);
            this.SaveMatrixButton.TabIndex = 1;
            this.SaveMatrixButton.Text = "Save";
            this.SaveMatrixButton.UseVisualStyleBackColor = true;
            this.SaveMatrixButton.Click += new System.EventHandler(this.SaveMatrixButtonClick);
            // 
            // MatrixOfWeightsDataGridView
            // 
            this.MatrixOfWeightsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.MatrixOfWeightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixOfWeightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1});
            this.MatrixOfWeightsDataGridView.Location = new System.Drawing.Point(8, 8);
            this.MatrixOfWeightsDataGridView.Name = "MatrixOfWeightsDataGridView";
            this.MatrixOfWeightsDataGridView.RowHeadersWidth = 51;
            this.MatrixOfWeightsDataGridView.Size = new System.Drawing.Size(857, 497);
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
            this.TableTabPage.BackColor = System.Drawing.Color.White;
            this.TableTabPage.Controls.Add(this.AddConnectionButton);
            this.TableTabPage.Controls.Add(this.button_Save);
            this.TableTabPage.Controls.Add(this.NodeConnectionsDataGridView);
            this.TableTabPage.Location = new System.Drawing.Point(4, 22);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TableTabPage.Size = new System.Drawing.Size(952, 511);
            this.TableTabPage.TabIndex = 0;
            this.TableTabPage.Text = "Table view";
            // 
            // AddConnectionButton
            // 
            this.AddConnectionButton.Location = new System.Drawing.Point(871, 35);
            this.AddConnectionButton.Name = "AddConnectionButton";
            this.AddConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.AddConnectionButton.TabIndex = 2;
            this.AddConnectionButton.Text = "Add edge";
            this.AddConnectionButton.UseVisualStyleBackColor = true;
            this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButtonClick);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(871, 6);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // NodeConnectionsDataGridView
            // 
            this.NodeConnectionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NodeConnectionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.NodeConnectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeConnectionsDataGridView.Location = new System.Drawing.Point(3, 0);
            this.NodeConnectionsDataGridView.Name = "NodeConnectionsDataGridView";
            this.NodeConnectionsDataGridView.RowHeadersWidth = 51;
            this.NodeConnectionsDataGridView.Size = new System.Drawing.Size(862, 505);
            this.NodeConnectionsDataGridView.TabIndex = 0;
            // 
            // TabView
            // 
            this.TabView.Controls.Add(this.TableTabPage);
            this.TabView.Controls.Add(this.MatrixOfWeightsTabPage);
            this.TabView.Controls.Add(this.DijkstraTabPage);
            this.TabView.Controls.Add(this.HamiltonTabPage);
            this.TabView.Controls.Add(this.GraphViewTabPage);
            this.TabView.Controls.Add(this.AdjacencyTabPage);
            this.TabView.Controls.Add(this.IncidencyTabPage);
            this.TabView.Location = new System.Drawing.Point(12, 12);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(960, 537);
            this.TabView.TabIndex = 0;
            // 
            // CenterSearchButton
            // 
            this.CenterSearchButton.Location = new System.Drawing.Point(770, 6);
            this.CenterSearchButton.Name = "CenterSearchButton";
            this.CenterSearchButton.Size = new System.Drawing.Size(85, 30);
            this.CenterSearchButton.TabIndex = 3;
            this.CenterSearchButton.Text = "Center";
            this.CenterSearchButton.UseVisualStyleBackColor = true;
            this.CenterSearchButton.Click += new System.EventHandler(this.CenterSearchButton_Click);
            // 
            // DijkstraMatrixDataGridView
            // 
            this.DijkstraMatrixDataGridView.AllowUserToAddRows = false;
            this.DijkstraMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DijkstraMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.DijkstraMatrixDataGridView.Location = new System.Drawing.Point(3, 66);
            this.DijkstraMatrixDataGridView.Name = "DijkstraMatrixDataGridView";
            this.DijkstraMatrixDataGridView.Size = new System.Drawing.Size(937, 431);
            this.DijkstraMatrixDataGridView.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
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
            this.GraphViewTabPage.ResumeLayout(false);
            this.GraphViewTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MatrixOfWeightsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixOfWeightsDataGridView)).EndInit();
            this.TableTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NodeConnectionsDataGridView)).EndInit();
            this.TabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DijkstraMatrixDataGridView)).EndInit();
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
    }
}

