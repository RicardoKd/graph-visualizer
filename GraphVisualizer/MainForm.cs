using System;
using System.Collections.Generic;
using System.Drawing;
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
            //for (int i = val; i < 6; i+=2)
            //{
            //    dataGridView1.Columns.Add($"Column{i}", ">");
            //    dataGridView1.Rows[0].Cells[i].Value = i;
            //    dataGridView1.Rows[1].Cells[i].Value = i;
            //    dataGridView1.Rows[2].Cells[i].Value = i;
            //    dataGridView1.Columns.Add($"Column{i}", ">");
            //    dataGridView1.Rows[0].Cells[i + 1].Value = i;
            //    dataGridView1.Rows[1].Cells[i + 1].Value = i;
            //    dataGridView1.Rows[2].Cells[i + 1].Value = i;
            //    val = i;
            //}
            //Random random = new Random();
            //for (int i = val; i < 5; i++)
            //{
            //    dataGridView1.Columns.Add($"Column{i}", ">");
            //    dataGridView1.Rows[0].Cells[i].Value = random.Next(0, 1000);
            //    dataGridView1.Rows[1].Cells[i].Value = random.Next(0, 1000);
            //    dataGridView1.Rows[2].Cells[i].Value = random.Next(0, 1000);
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
            NodeConnectionsDataGridView.Rows[1].Cells[4].Value = "689";
            NodeConnectionsDataGridView.Rows[2].Cells[4].Value = "70";

            //dataGridView1.Columns.Add($"Column{val}", ">");
            //dataGridView1.Rows[0].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[1].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[2].Cells[val + 1].Value = 3;
            //SaveTable();
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

                    if (NodeConnectionsDataGridView[i, 0].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 0].Value.ToString()) == 0 &&
                        NodeConnectionsDataGridView[i, 1].Value.ToString().CompareTo(NodeConnectionsDataGridView[j, 1].Value.ToString()) == 0)
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

            _matrix = Convertors.TableToMatrixOfWeights(_nodeConnections);
            FillDataGridView(MatrixOfWeightsDataGridView, _matrix);

            _adjacencyMatrix = Convertors.MatrixOfWeightsToAdjacencyMatrix(_matrix);
            FillDataGridView(AdjacencyMatrixDataGridView, _adjacencyMatrix);

            _incidencyMatrix = Convertors.MatrixOfWeightsToIncidencyMatrix(_matrix);
            FillDataGridView(IncidencyMatrixDataGridView, _incidencyMatrix);
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
            MatrixOfWeightsDataGridView.Rows.Add("x" + _counter);
        }

        private void DrawGraphButtonClick(object sender, EventArgs e)
        {
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

            var drawGraph = new DrawGraphModel(pictureBox1, _primsMatrix);
            drawGraph.Render();
        }

        private void ExecuteDijkstrasAlgorithmButtonClick(object sender, EventArgs e)
        {
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

            //int[,] matrix = new int[_matrix.GetLength(0) - 1, _matrix.GetLength(1) - 1];

            //for (int i = 1; i < _matrix.GetLength(0); i++)
            //{
            //    for (int j = 1; j < _matrix.GetLength(1); j++)
            //    {
            //        matrix[i - 1, j - 1] = Convert.ToInt32(_matrix[i, j]);
            //    }
            //}

            //int[,] primsMatrix = new int[_primsMatrix.GetLength(0) - 1, _primsMatrix.GetLength(1) - 1];

            //for (int i = 1; i < _primsMatrix.GetLength(0); i++)
            //{
            //    for (int j = 1; j < _primsMatrix.GetLength(1); j++)
            //    {
            //        primsMatrix[i - 1, j - 1] = Convert.ToInt32(_primsMatrix[i, j]);
            //    }
            //}

            //new CenterSearchAlgorithm(primsMatrix, matrix).Execute();
        }

        private void Increase_Scale_Click(object sender, EventArgs e) {

        }
        private void Increase_Scale_Click_1(object sender, EventArgs e) {
            drawGraph.IncreaseScale();
        }

        private void Decrease_Scale_Click(object sender, EventArgs e) {
            drawGraph.DecreaseScale();
        }
    }
}
