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
            this.TabView = new System.Windows.Forms.TabControl();
            this.Table = new System.Windows.Forms.TabPage();
            this.AddConnectionButton = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matrix = new System.Windows.Forms.TabPage();
            this.AddNodeToMatrixButton = new System.Windows.Forms.Button();
            this.SaveMatrixButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DrawGraphButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ExecutePrimaButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ExecuteHamiltonButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabView.SuspendLayout();
            this.Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Matrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // TabView
            // 
            this.TabView.Controls.Add(this.Table);
            this.TabView.Controls.Add(this.Matrix);
            this.TabView.Controls.Add(this.tabPage1);
            this.TabView.Controls.Add(this.tabPage4);
            this.TabView.Controls.Add(this.tabPage2);
            this.TabView.Controls.Add(this.tabPage3);
            this.TabView.Controls.Add(this.tabPage5);
            this.TabView.Controls.Add(this.tabPage6);
            this.TabView.Controls.Add(this.tabPage7);
            this.TabView.Location = new System.Drawing.Point(12, 12);
            this.TabView.Name = "TabView";
            this.TabView.SelectedIndex = 0;
            this.TabView.Size = new System.Drawing.Size(960, 537);
            this.TabView.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.White;
            this.Table.Controls.Add(this.AddConnectionButton);
            this.Table.Controls.Add(this.button_Save);
            this.Table.Controls.Add(this.dataGridView1);
            this.Table.Location = new System.Drawing.Point(4, 22);
            this.Table.Name = "Table";
            this.Table.Padding = new System.Windows.Forms.Padding(3);
            this.Table.Size = new System.Drawing.Size(952, 511);
            this.Table.TabIndex = 0;
            this.Table.Text = "Table view";
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(862, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // Matrix
            // 
            this.Matrix.Controls.Add(this.AddNodeToMatrixButton);
            this.Matrix.Controls.Add(this.SaveMatrixButton);
            this.Matrix.Controls.Add(this.dataGridView2);
            this.Matrix.Location = new System.Drawing.Point(4, 22);
            this.Matrix.Name = "Matrix";
            this.Matrix.Padding = new System.Windows.Forms.Padding(3);
            this.Matrix.Size = new System.Drawing.Size(952, 511);
            this.Matrix.TabIndex = 1;
            this.Matrix.Text = "Matrix view";
            this.Matrix.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1});
            this.dataGridView2.Location = new System.Drawing.Point(8, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(857, 497);
            this.dataGridView2.TabIndex = 0;
            // 
            // x1
            // 
            this.x1.HeaderText = "X";
            this.x1.MinimumWidth = 6;
            this.x1.Name = "x1";
            this.x1.Width = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.DrawGraphButton);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 511);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Graph view";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.pictureBox1.Size = new System.Drawing.Size(920, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ExecutePrimaButton);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(952, 511);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Minimal value";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ExecutePrimaButton
            // 
            this.ExecutePrimaButton.Location = new System.Drawing.Point(3, 3);
            this.ExecutePrimaButton.Name = "ExecutePrimaButton";
            this.ExecutePrimaButton.Size = new System.Drawing.Size(75, 23);
            this.ExecutePrimaButton.TabIndex = 0;
            this.ExecutePrimaButton.Text = "Draw";
            this.ExecutePrimaButton.UseVisualStyleBackColor = true;
            this.ExecutePrimaButton.Click += new System.EventHandler(this.ExecutePrimaButtonClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(946, 505);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(952, 511);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Dijkstra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(840, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(952, 511);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Save as";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ExecuteHamiltonButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(952, 511);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Hamilton";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ExecuteHamilton
            // 
            this.ExecuteHamiltonButton.Location = new System.Drawing.Point(861, 6);
            this.ExecuteHamiltonButton.Name = "ExecuteHamilton";
            this.ExecuteHamiltonButton.Size = new System.Drawing.Size(85, 30);
            this.ExecuteHamiltonButton.TabIndex = 0;
            this.ExecuteHamiltonButton.Text = "Hamilton";
            this.ExecuteHamiltonButton.UseVisualStyleBackColor = true;
            this.ExecuteHamiltonButton.Click += new System.EventHandler(this.ExecuteHamiltonButtonClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(952, 511);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Adjacency";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(940, 499);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView4);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(952, 511);
            this.tabPage7.TabIndex = 8;
            this.tabPage7.Text = "Incidency";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(940, 499);
            this.dataGridView4.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(985, 561);
            this.Controls.Add(this.TabView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix analyzer";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.TabView.ResumeLayout(false);
            this.Table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Matrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabView;
        private System.Windows.Forms.TabPage Table;
        private System.Windows.Forms.TabPage Matrix;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveMatrixButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button AddConnectionButton;
        private System.Windows.Forms.Button AddNodeToMatrixButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button DrawGraphButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ExecutePrimaButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button ExecuteHamiltonButton;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

