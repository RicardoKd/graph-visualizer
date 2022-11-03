using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GraphVisualizer.Algorithms;
using GraphVisualizer.Helpers;
using GraphVisualizer.Models;
using GraphVisualizer.Structures;

namespace GraphVisualizer
{
    public partial class MainForm : Form
    {
        private int _counter = 0;
        private string[,] _matrix;
        private string[,] _adjacencyMatrix;
        private string[,] _incidencyMatrix;
        private string[,] _primsMatrix;
        private string[,] _dijkstraMatrix;
        private List<NodeConnection> _nodeConnections = new List<NodeConnection>();
        private DrawGraphModel drawGraph;
        private bool _canCalculateAlgorithms = true;
        private bool _isPrim = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            NodeConnectionsDataGridView.AllowUserToAddRows = false;
            NodeConnectionsDataGridView.AllowUserToOrderColumns = false;

            NodeConnectionsDataGridView.Columns.Add("Column0", ">");
            NodeConnectionsDataGridView.Rows.Add("First point");
            NodeConnectionsDataGridView.Rows.Add("Second point");
            NodeConnectionsDataGridView.Rows.Add("Weight");

            MatrixOfWeightsDataGridView.AllowUserToAddRows = false;

            int val = 1;
            //for (int i = val; i < 6; i += 2)
            //{
            //    NodeConnectionsDataGridView.Columns.Add($"Column{i}", ">");
            //    NodeConnectionsDataGridView.Rows[0].Cells[i].Value = i;
            //    NodeConnectionsDataGridView.Rows[1].Cells[i].Value = i;
            //    NodeConnectionsDataGridView.Rows[2].Cells[i].Value = i;
            //    NodeConnectionsDataGridView.Columns.Add($"Column{i}", ">");
            //    NodeConnectionsDataGridView.Rows[0].Cells[i + 1].Value = i;
            //    NodeConnectionsDataGridView.Rows[1].Cells[i + 1].Value = i;
            //    NodeConnectionsDataGridView.Rows[2].Cells[i + 1].Value = i;
            //    val = i;
            //}
            //Random random = new Random();
            //for (int i = val; i < 15; i++)
            //{
            //    NodeConnectionsDataGridView.Columns.Add($"Column{i}", ">");
            //    NodeConnectionsDataGridView.Rows[0].Cells[i].Value = random.Next(0, 1000);
            //    NodeConnectionsDataGridView.Rows[1].Cells[i].Value = random.Next(0, 1000);
            //    NodeConnectionsDataGridView.Rows[2].Cells[i].Value = random.Next(0, 1000);
            //    val = i;
            //}

            NodeConnectionsDataGridView.Columns.Add($"Column{1}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[1].Value = "689";
            NodeConnectionsDataGridView.Rows[1].Cells[1].Value = "721";
            NodeConnectionsDataGridView.Rows[2].Cells[1].Value = "40";

            NodeConnectionsDataGridView.Columns.Add($"Column{2}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[2].Value = "721";
            NodeConnectionsDataGridView.Rows[1].Cells[2].Value = "555";
            NodeConnectionsDataGridView.Rows[2].Cells[2].Value = "50";

            NodeConnectionsDataGridView.Columns.Add($"Column{3}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[3].Value = "555";
            NodeConnectionsDataGridView.Rows[1].Cells[3].Value = "843";
            NodeConnectionsDataGridView.Rows[2].Cells[3].Value = "60";

            NodeConnectionsDataGridView.Columns.Add($"Column{4}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[4].Value = "843";
            NodeConnectionsDataGridView.Rows[1].Cells[4].Value = "999";
            NodeConnectionsDataGridView.Rows[2].Cells[4].Value = "70";            
            
            NodeConnectionsDataGridView.Columns.Add($"Column{5}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[5].Value = "843";
            NodeConnectionsDataGridView.Rows[1].Cells[5].Value = "689";
            NodeConnectionsDataGridView.Rows[2].Cells[5].Value = "10";
            
            NodeConnectionsDataGridView.Columns.Add($"Column{6}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[6].Value = "555";
            NodeConnectionsDataGridView.Rows[1].Cells[6].Value = "689";
            NodeConnectionsDataGridView.Rows[2].Cells[6].Value = "20";
            NodeConnectionsDataGridView.Columns.Add($"Column{7}", ">");
            NodeConnectionsDataGridView.Rows[0].Cells[7].Value = "999";
            NodeConnectionsDataGridView.Rows[1].Cells[7].Value = "555";
            NodeConnectionsDataGridView.Rows[2].Cells[7].Value = "35";

            //dataGridView1.Columns.Add($"Column{val}", ">");
            //dataGridView1.Rows[0].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[1].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[2].Cells[val + 1].Value = 3;
            SaveTable();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveTable();
        }

        private void SaveTable()
        {
            _nodeConnections = new List<NodeConnection>();
            int quantityOfColumns = NodeConnectionsDataGridView.Columns.Count;
            bool hasDuplicates = false;

            PaintToWhite();

            for (int i = 0; i < NodeConnectionsDataGridView.ColumnCount; i++)
            {
                for (int j = i + 1; j < NodeConnectionsDataGridView.ColumnCount; j++)
                {
                    if (NodeConnectionsDataGridView[i, 0].Value == null || NodeConnectionsDataGridView[i, 1].Value == null || NodeConnectionsDataGridView[i, 2].Value == null ||
                        NodeConnectionsDataGridView[j, 0].Value == null || NodeConnectionsDataGridView[j, 1].Value == null || NodeConnectionsDataGridView[j, 2].Value == null)
                    {
                        continue;
                    }

                    if ((NodeConnectionsDataGridView[i, 0].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 0].Value.ToString()) == 0 &&
                        NodeConnectionsDataGridView[i, 1].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 1].Value.ToString()) == 0) ||
                        (NodeConnectionsDataGridView[i, 0].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 1].Value.ToString()) == 0 &&
                        NodeConnectionsDataGridView[i, 1].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 0].Value.ToString()) == 0))
                    {
                        hasDuplicates = true;
                        NodeConnectionsDataGridView.Rows[0].Cells[i].Style.BackColor = Color.Red;
                        NodeConnectionsDataGridView.Rows[0].Cells[j].Style.BackColor = Color.Red;
                        NodeConnectionsDataGridView.Rows[1].Cells[i].Style.BackColor = Color.Red;
                        NodeConnectionsDataGridView.Rows[1].Cells[j].Style.BackColor = Color.Red;
                    }
                }
            }

            if (hasDuplicates)
            {
                MessageBox.Show("Would you be so kind to remove duplicates from your table?");
                return;
            }

            for (int i = 1; i < quantityOfColumns; i++)
            {
                if (NodeConnectionsDataGridView[i, 0].Value == null || NodeConnectionsDataGridView[i, 1].Value == null || NodeConnectionsDataGridView[i, 2].Value == null)
                    continue;

                _nodeConnections.Add(new NodeConnection(NodeConnectionsDataGridView[i, 0].Value.ToString(), NodeConnectionsDataGridView[i, 1].Value.ToString(), NodeConnectionsDataGridView[i, 2].Value.ToString()));
            }

            if (_nodeConnections.Count == 0)
            {
                MessageBox.Show("Number of inputted nodes is 0");
                return;
            }

            _matrix = Convertors.TableToMatrixOfWeights(_nodeConnections);
            FillDataGridView(MatrixOfWeightsDataGridView, _matrix);

            _adjacencyMatrix = Convertors.MatrixOfWeightsToAdjacencyMatrix(_matrix);
            FillDataGridView(AdjacencyMatrixDataGridView, _adjacencyMatrix);

            _incidencyMatrix = Convertors.MatrixOfWeightsToIncidencyMatrix(_matrix);
            FillDataGridView(IncidencyMatrixDataGridView, _incidencyMatrix);

            int[] path;

            int[,] matrix = new int[_adjacencyMatrix.GetLength(0) - 1, _adjacencyMatrix.GetLength(1) - 1];

            for (int i = 1; i < _adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < _adjacencyMatrix.GetLength(1); j++)
                {
                    matrix[i - 1, j - 1] = Convert.ToInt32(_adjacencyMatrix[i, j]);
                }
            }

            var hamiltonCycle = new HamiltonAlgorithm(matrix);
            if (!hamiltonCycle.Calculate(out path))
            {
                _canCalculateAlgorithms = false;
                return;
            }

            int[,] matrix1 = new int[_matrix.GetLength(0) - 1, _matrix.GetLength(1) - 1];

            for (int i = 1; i < _matrix.GetLength(0); i++)
            {
                for (int j = 1; j < _matrix.GetLength(1); j++)
                {
                    matrix1[i - 1, j - 1] = Convert.ToInt32(_matrix[i, j]);
                }
            }

            var result = new DijkstraAlgorithm(matrix1).Calculate();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j += 2)
                {
                    result[i][j] = _matrix[0, Convert.ToInt32(result[i][j]) + 1];
                }
            }

            var dijkstraMatrix = new string[_matrix.GetLength(0), _matrix.GetLength(0)];

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                dijkstraMatrix[0, i] = _matrix[0, i];
                dijkstraMatrix[i, 0] = _matrix[i, 0];
            }

            for (int i = 0; i < result.Count; i++)
            {
                //_matrix[0, i + 1];
                for (int j = 0; j < result[i].Count; j += 2)
                {
                    dijkstraMatrix[i + 1, j / 2 + 1] = result[i][j + 1];
                }
                //output += "\n";
            }

            _dijkstraMatrix = dijkstraMatrix;
            FillDataGridView(DijkstraMatrixDataGridView, dijkstraMatrix);

            var output = string.Empty;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    output += _matrix[i, j] + " ";
                }
                output += "\n";
            }

            File.WriteAllText("Matix.txt", output);

        }

        private void FillDataGridView(DataGridView dataGridView, string[,] listOfElements)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Refresh();

            for (int i = 0; i < listOfElements.GetLength(1); i++)
            {
                dataGridView.Columns.Add($"Column{i}", ">");
            }

            for (int i = 0; i < listOfElements.GetLength(0); i++)
            {
                dataGridView.Rows.Add();
            }

            for (int i = 0; i < listOfElements.GetLength(0); i++)
            {
                for (int j = 0; j < listOfElements.GetLength(1); j++)
                {
                    dataGridView[j, i].Value = listOfElements[i, j];
                }
            }
        }

        void PaintToWhite()
        {
            for (int i = 0; i < NodeConnectionsDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < NodeConnectionsDataGridView.RowCount; j++)
                {
                    NodeConnectionsDataGridView[i, j].Style.BackColor = Color.Empty;
                }
            }
        }

        private void AddConnectionButtonClick(object sender, EventArgs e)
        {
            _counter++;
            NodeConnectionsDataGridView.Columns.Add("Column", "x" + _counter);
        }

        private void AddNodeToMatrixButtonClick(object sender, EventArgs e)
        {
            MatrixOfWeightsDataGridView.Columns.Add("x" + _counter, "");
            MatrixOfWeightsDataGridView.Rows.Add("x" + _counter);
        }

        private void DrawGraphButtonClick(object sender, EventArgs e)
        {
            _isPrim = false;
            drawGraph = new DrawGraphModel(pictureBox1, _matrix);
            
            drawGraph.Render();
            
        }

        private void ExecuteHamiltonButtonClick(object sender, EventArgs e)
        {
            int[] path;

            int[,] matrix = new int[_adjacencyMatrix.GetLength(0) - 1, _adjacencyMatrix.GetLength(1) - 1];

            for (int i = 1; i < _adjacencyMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < _adjacencyMatrix.GetLength(1); j++)
                {
                    matrix[i - 1, j - 1] = Convert.ToInt32(_adjacencyMatrix[i, j]);
                }
            }

            var hamiltonCycle = new HamiltonAlgorithm(matrix);
            if (!hamiltonCycle.Calculate(out path))
            {
                MessageBox.Show("There is no Hamiltonian path in the given graph");
                return;
            }

            string output = string.Empty;
            for (int i = 0; i < path.Length; i++)
            {
                output += _adjacencyMatrix[path[i] + 1, 0] + "->";
            }
            output += _adjacencyMatrix[path[0] + 1, 0];
            HamiltonResultLabel.Text = "Cycle: " + output;
            HamiltonLengthLabel.Text = "Length: " + path.Length;
        }

        private void SaveMatrixButtonClick(object sender, EventArgs e)
        {
            SaveMatrix();
        }

        private void SaveMatrix()
        {
            string[,] matrix = new string[MatrixOfWeightsDataGridView.RowCount, MatrixOfWeightsDataGridView.ColumnCount];

            if (MatrixOfWeightsDataGridView.RowCount != MatrixOfWeightsDataGridView.ColumnCount)
            {
                MessageBox.Show("Rows != Columns");
                return;
            }

            for (int i = 0; i < MatrixOfWeightsDataGridView.RowCount; i++)
            {
                for (int j = 0; j < MatrixOfWeightsDataGridView.ColumnCount; j++)
                {
                    if (MatrixOfWeightsDataGridView[i, j].Value.ToString() == null)
                    {
                        matrix[i, j] = "";
                        continue;
                    }
                    matrix[i, j] = MatrixOfWeightsDataGridView[i, j].Value.ToString();
                }
            }

            _matrix = matrix;

            _nodeConnections = Convertors.MatrixOfWeightsToTable(_matrix);
            FillDataGridView(NodeConnectionsDataGridView, Convertors.TableToArray(_nodeConnections));

            _adjacencyMatrix = Convertors.MatrixOfWeightsToAdjacencyMatrix(_matrix);
            FillDataGridView(AdjacencyMatrixDataGridView, _adjacencyMatrix);

            _incidencyMatrix = Convertors.MatrixOfWeightsToIncidencyMatrix(_matrix);
            FillDataGridView(IncidencyMatrixDataGridView, _incidencyMatrix);
        }

        private void DrawPrimButtonClick(object sender, EventArgs e)
        {
            if (!_canCalculateAlgorithms)
            {
                MessageBox.Show("Cannot calculate Prims algorithm");
                return;
            }

            _isPrim = true;

            int[,] matrix = new int[_matrix.GetLength(0) - 1, _matrix.GetLength(1) - 1];

            for (int i = 1; i < _matrix.GetLength(0); i++)
            {
                for (int j = 1; j < _matrix.GetLength(1); j++)
                {
                    matrix[i - 1, j - 1] = Convert.ToInt32(_matrix[i, j]);
                }
            }

            var table = new PrimsAlgorithm(matrix).ExecutePrimsAlgorithm();

            for (int i = 0; i < table.Count; i++)
            {
                table[i].FirstPoint = Convert.ToString(_matrix[0, Convert.ToInt32(table[i].FirstPoint) + 1]);
                table[i].SecondPoint = Convert.ToString(_matrix[0, Convert.ToInt32(table[i].SecondPoint) + 1]);
            }

            _primsMatrix = Convertors.TableToMatrixOfWeights(table);

            drawGraph = new DrawGraphModel(pictureBox1, _primsMatrix);
            drawGraph.Render();
        }

        private void ExecuteDijkstrasAlgorithmButtonClick(object sender, EventArgs e)
        {
            if (!_canCalculateAlgorithms)
            {
                MessageBox.Show("Cannot calculate Dijkstras algorithm");
                return;
            }

            int[,] matrix = new int[_matrix.GetLength(0) - 1, _matrix.GetLength(1) - 1];

            for (int i = 1; i < _matrix.GetLength(0); i++)
            {
                for (int j = 1; j < _matrix.GetLength(1); j++)
                {
                    matrix[i - 1, j - 1] = Convert.ToInt32(_matrix[i, j]);
                }
            }

            var result = new DijkstraAlgorithm(matrix).Calculate();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j += 2)
                {
                    result[i][j] = _matrix[0, Convert.ToInt32(result[i][j]) + 1];
                }
            }

            var dijkstraMatrix = new string[_matrix.GetLength(0), _matrix.GetLength(0)];

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                dijkstraMatrix[0, i] = _matrix[0, i];
                dijkstraMatrix[i, 0] = _matrix[i, 0];
            }

            for (int i = 0; i < result.Count; i++)
            {
                //_matrix[0, i + 1];
                for (int j = 0; j < result[i].Count; j += 2)
                {
                    dijkstraMatrix[i + 1, j / 2 + 1] = result[i][j + 1];
                }
                //output += "\n";
            }

            _dijkstraMatrix = dijkstraMatrix;
            FillDataGridView(DijkstraMatrixDataGridView, dijkstraMatrix);



            string output = "";

            for (int i = 0; i < result.Count; i++)
            {
                output += $"Node {_matrix[0, i + 1]}:->";
                for (int j = 0; j < result[i].Count; j += 2)
                {
                    output += $"({result[i][j]}, {result[i][j + 1]}) ";
                }
                output += "\n";
            }

            MessageBox.Show(output);
        }

        private void CenterSearchButton_Click(object sender, EventArgs e)
        {
            if (!_canCalculateAlgorithms)
            {
                MessageBox.Show("Cannot calculate center algorithm");
                return;
            }

            int max = 0;
            int min = 0;
            var listOfMaxes = new List<int>();
            var listOfMins = new List<int>();
            for (int i = 1; i < _dijkstraMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < _dijkstraMatrix.GetLength(0); j++)
                {
                    if (Convert.ToInt32(_dijkstraMatrix[i, j]) > max)
                    {
                        max = Convert.ToInt32(_dijkstraMatrix[i, j]);
                    }
                }
                listOfMaxes.Add(max);
            }

            min = listOfMaxes[0];
            for (int i = 1; i < listOfMaxes.Count; i++)
            {
                if (listOfMaxes[i] < min)
                {
                    min = listOfMaxes[i];
                }
            }

            listOfMins.Add(min);

            for (int i = 1; i < listOfMaxes.Count; i++)
            {
                if (listOfMaxes[i] == min)
                {
                    listOfMins.Add(min);
                }
            }


            string node1 = string.Empty;
            string node2 = string.Empty;

            for (int i = 1; i < _dijkstraMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < _dijkstraMatrix.GetLength(1); j++)
                {
                    if (Convert.ToInt32(_dijkstraMatrix[i, j]) == min)
                    {
                        if (node1 == string.Empty)
                        {
                            node1 = _dijkstraMatrix[i, 0];
                        }
                        else
                        {
                            if (node2 == string.Empty)
                            {
                                node2 = _dijkstraMatrix[i, 0];
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Center is " + node1 + " " + min + " " + node2);
        }

        private void MedianSearchButton_Click(object sender, EventArgs e)
        {
            if (!_canCalculateAlgorithms)
            {
                MessageBox.Show("Cannot calculate median algorithm");
                return;
            }

            int sum = 0;
            int min = 0;
            var listOfSums = new List<int>();
            var listOfMins = new List<int>();
            for (int i = 1; i < _dijkstraMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < _dijkstraMatrix.GetLength(0); j++)
                {
                    sum += Convert.ToInt32(_dijkstraMatrix[i, j]);
                }
                listOfSums.Add(sum);
            }

            min = listOfSums[0];
            for (int i = 1; i < listOfSums.Count; i++)
            {
                if (listOfSums[i] < min)
                {
                    min = listOfSums[i];
                }
            }

            listOfMins.Add(min);

            for (int i = 1; i < listOfSums.Count; i++)
            {
                if (listOfSums[i] == min)
                {
                    listOfMins.Add(min);
                }
            }

            string node1 = string.Empty;
            string node2 = string.Empty;

            for (int i = 0; i < listOfSums.Count; i++)
            {
                if (listOfSums[i] == min)
                {
                    node1 = _dijkstraMatrix[i + 1, 0];
                }
            }

            MessageBox.Show("Median is " + node1);
        }

        private void Increase_Scale_Click_1(object sender, EventArgs e) {
            drawGraph.IncreaseScale();
        }

        private void Decrease_Scale_Click(object sender, EventArgs e) {
            drawGraph.DecreaseScale();
        }

        private void MoveRightBtn_Click(object sender, EventArgs e) {
            drawGraph.MoveGraphRight();
        }

        private void MoveLeft_Click(object sender, EventArgs e) {
            drawGraph.MoveGraphLeft();
        }

        private void MoveUp_Click(object sender, EventArgs e) {
            drawGraph.MoveGraphUp();
        }

        private void MoveDown_Click(object sender, EventArgs e) {
            drawGraph.MoveGraphDown();
        }

        private void ExecuteSpanningTreeAlgorithmButton_Click(object sender, EventArgs e) {
            int quantityOfVertices = (int)Math.Sqrt(_matrix.Length) - 1;

            SpanningTreeAlgorithm spanningTree = new SpanningTreeAlgorithm(quantityOfVertices, Convertors.MatrixOfWeightsToEdges(_matrix));
            spanningTree.Calculate();
        }

        /*const int m_nRadius = 20;
        const int m_nHalfRadius = (m_nRadius / 2);

        Color m_colVertex = Color.Aqua;
        Color m_colEdge = Color.Red;

        List<SpanningNode> m_lstVertices;
        List<Link> m_lstEdgesInitial, m_lstEdgesFinal;

        SpanningNode m_vFirstVertex, m_vSecondVertex;

        bool m_bDrawEdge, m_bSolved;


        private void ExecuteSpanningTreeAlgorithmButton_Click(object sender, EventArgs e) {
            int quantityOfVertices = (int)Math.Sqrt(_adjacencyMatrix.Length) - 1;

            SpanningNode[] vertices = new SpanningNode[quantityOfVertices];

            for (int i = 1; i < quantityOfVertices + 1; i++) {
                vertices[i - 1] = new SpanningNode(Convert.ToInt32(_adjacencyMatrix[0, i]), new Point(10 * i, 10));
                m_lstVertices.Add(vertices[i - 1]);
            }

            foreach (var edge in _nodeConnections) {
                SpanningNode firstVertex = new SpanningNode(404, new Point(0, 0));
                SpanningNode secondVertex = new SpanningNode(404, new Point(0, 0));

                foreach (var vertex in vertices) {
                    if (edge.FirstPoint.Equals(Convert.ToString(vertex.Name))){
                        firstVertex = vertex;
                    }
                }

                foreach (var vertex in vertices) {
                    if (edge.SecondPoint.Equals(Convert.ToString(vertex.Name))) {
                        secondVertex = vertex;
                    }
                }

                // parse connections
                m_lstEdgesInitial.Add(new Link(
                    firstVertex,
                    secondVertex,
                    Convert.ToInt32(edge.Weight),
                    new Point(10, 10)));
            }


            // private void Solve_Click(object sender, EventArgs e) {}
            // Find Minimal spanning tree using Kruskal

            //if (m_lstVertices.Count > 2) {
            if (m_lstEdgesInitial.Count < m_lstVertices.Count - 1) {
                    MessageBox.Show("Missing Edges", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {
                    ExecuteSpanningTreeAlgorithmButton.Enabled = false;
                    int nTotalCost = 0;
                    m_lstEdgesFinal = SolveGraph(ref nTotalCost);
                    m_bSolved = true;
                    panel1.Invalidate();
                    MessageBox.Show("Total Cost:" + nTotalCost.ToString(), "Solution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // private void panel1_Paint(object sender, PaintEventArgs e) {}
                    // Drawing graph
                    Graphics g = panel1.CreateGraphics();
                    DrawVertices(g);
                    DrawEdges(g);
                    g.Dispose();
                }
            //}
        }

        private void DrawEdges(Graphics g) {
            Pen P = new Pen(m_colEdge);
            List<Link> lstEdges = m_bSolved ? m_lstEdgesFinal : m_lstEdgesInitial;

            foreach (Link e in lstEdges) {
                Point pV1 = new Point(e.V1.pPosition.X + m_nHalfRadius, e.V1.pPosition.Y + m_nHalfRadius);
                Point pV2 = new Point(e.V2.pPosition.X + m_nHalfRadius, e.V2.pPosition.Y + m_nHalfRadius);
                g.DrawLine(P, pV1, pV2);
                DrawString(e.Weight.ToString(), e.StringPosition, g);
            }
        }

        private void DrawString(string strText, Point pDrawPoint, Graphics g) {
            Font drawFont = new Font("Arial", 15);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.DrawString(strText, drawFont, drawBrush, pDrawPoint);
        }

        private void DrawVertices(Graphics g) {
            Pen P = new Pen(m_colVertex);
            Brush B = new SolidBrush(m_colVertex);
            foreach (SpanningNode v in m_lstVertices) {
                g.DrawEllipse(P, v.pPosition.X, v.pPosition.Y, m_nRadius, m_nRadius);
                g.FillEllipse(B, v.pPosition.X, v.pPosition.Y, m_nRadius, m_nRadius);
                DrawString(v.Name.ToString(), v.pPosition, g);
            }
        }

        private List<Link> SolveGraph(ref int nTotalCost) {
            Link.QuickSort(m_lstEdgesInitial, 0, m_lstEdgesInitial.Count - 1);
            List<Link> lstEdgesRetun = new List<Link>(m_lstEdgesInitial.Count);
            foreach (Link ed in m_lstEdgesInitial) {
                SpanningNode vRoot1, vRoot2;
                vRoot1 = ed.V1.GetRoot();
                vRoot2 = ed.V2.GetRoot();
                if (vRoot1.Name != vRoot2.Name) {
                    nTotalCost += ed.Weight;
                    SpanningNode.Join(vRoot1, vRoot2);
                    lstEdgesRetun.Add(new Link(ed.V1, ed.V2, ed.Weight, ed.StringPosition));
                }
            }
            return lstEdgesRetun;
        }

        private Point GetStringPoint(Point pStart, Point pFinish) {
            int X = (pStart.X + pFinish.X) / 2;
            int Y = (pStart.Y + pFinish.Y) / 2;
            return new Point(X, Y);
        }*/

        // Clear the drawing area
        /*private void Clear_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("Clear form ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes) {
                ExecuteSpanningTreeAlgorithmButton.Enabled = true;
                Graphics g = panel1.CreateGraphics();
                g.Clear(panel1.BackColor);
                Reset();
            }
        }*/

        /*private void Reset() {
            m_lstVertices = new List<SpanningNode>();
            m_lstEdgesInitial = new List<Link>();
            m_bSolved = false;
            m_vFirstVertex = m_vSecondVertex = null;
        }*/

        /*private SpanningNode GetSelectedVertex(Point pClicked) {
            SpanningNode vReturn = null;
            double dDistance;
            foreach (SpanningNode v in m_lstVertices) {
                dDistance = GetDistance(v.pPosition, pClicked);
                if (dDistance <= m_nRadius) {
                    vReturn = v;
                    break;
                }
            }
            return vReturn;
        }*/

        /*private double GetDistance(Point pStart, Point pFinish) {
            return Math.Sqrt(Math.Pow(pStart.X - pFinish.X, 2) + Math.Pow(pStart.Y - pFinish.Y, 2));
        }*/

        /*private void panel1_MouseClick(object sender, MouseEventArgs e) {
            Point pClicked = new Point(e.X - m_nHalfRadius, e.Y - m_nHalfRadius);
            if (Control.ModifierKeys == Keys.Control)//if Ctrl is pressed
            {
                if (!m_bDrawEdge) {
                    m_vFirstVertex = GetSelectedVertex(pClicked);
                    m_bDrawEdge = true;
                } else {
                    m_vSecondVertex = GetSelectedVertex(pClicked);
                    m_bDrawEdge = false;
                    if (m_vFirstVertex != null && m_vSecondVertex != null && m_vFirstVertex.Name != m_vSecondVertex.Name) {
                        Cost formCost = new Cost();
                        formCost.ShowDialog();

                        Point pStringPoint = GetStringPoint(m_vFirstVertex.pPosition, m_vSecondVertex.pPosition);
                        m_lstEdgesInitial.Add(new Link(m_vFirstVertex, m_vSecondVertex, formCost.m_nCost, pStringPoint));
                        panel1.Invalidate();
                    }
                }
            } else {
                m_lstVertices.Add(new SpanningNode(m_lstVertices.Count, pClicked));
                panel1.Invalidate();
            }
        }*/
    }
}
