using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tim_project.Dijkstra_algorithm;
using tim_project.GraphStructure;
using tim_project.Hamilton_algorithm;

namespace tim_project {
    public partial class Form1 : Form {
        private int _counter = 0;
        private string[,] _matrix;
        private string[,] _adjacencyMatrix;
        private List<NodeConnection> _nodeConnections = new List<NodeConnection>();
        private Graph _graph = new Graph();

        public struct NodeConnection {
            public string FirstPoint;
            public string SecondPoint;
            public string Weight;

            public NodeConnection(string firstPoint, string secondPoint, string weight) {
                FirstPoint = firstPoint;
                SecondPoint = secondPoint;
                Weight = weight;
            }
        }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = false;

            dataGridView1.Columns.Add("Column0", ">");
            dataGridView1.Rows.Add("First point");
            dataGridView1.Rows.Add("Second point");
            dataGridView1.Rows.Add("Weight");

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
            Random random = new Random();
            for (int i = val; i < 5; i++) {
                dataGridView1.Columns.Add($"Column{i}", ">");
                dataGridView1.Rows[0].Cells[i].Value = random.Next(0, 1000);
                dataGridView1.Rows[1].Cells[i].Value = random.Next(0, 1000);
                dataGridView1.Rows[2].Cells[i].Value = random.Next(0, 1000);
                val = i;
            }

            //dataGridView1.Columns.Add($"Column{val}", ">");
            //dataGridView1.Rows[0].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[1].Cells[val + 1].Value = 3;
            //dataGridView1.Rows[2].Cells[val + 1].Value = 3;
            //SaveTable();
        }

        private void button_Save_Click(object sender, EventArgs e) {
            SaveTable();
        }

        private void SaveTable() {
            int quantityOfRows = dataGridView1.Rows.Count;
            int quantityOfColumns = dataGridView1.Columns.Count;
            bool hasDuplicates = false;

            PaintToWhite();

            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                for (int j = i + 1; j < dataGridView1.ColumnCount; j++) {
                    if (dataGridView1[i, 0].Value == null || dataGridView1[i, 1].Value == null || dataGridView1[i, 2].Value == null ||
                        dataGridView1[j, 0].Value == null || dataGridView1[j, 1].Value == null || dataGridView1[j, 2].Value == null) {
                        continue;
                    }

                    if (dataGridView1[i, 0].Value.ToString().CompareTo(dataGridView1[j, 0].Value.ToString()) == 0 &&
                        dataGridView1[i, 1].Value.ToString().CompareTo(dataGridView1[j, 1].Value.ToString()) == 0) {
                        hasDuplicates = true;
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                        dataGridView1.Rows[0].Cells[j].Style.BackColor = Color.Red;
                        dataGridView1.Rows[1].Cells[i].Style.BackColor = Color.Red;
                        dataGridView1.Rows[1].Cells[j].Style.BackColor = Color.Red;
                    }
                }
            }

            if (hasDuplicates) {
                MessageBox.Show("Would you be so kind to remove duplicates from your table?");
                return;
            }

            for (int i = 1; i < quantityOfColumns; i++) {
                if (dataGridView1[i, 0].Value == null || dataGridView1[i, 1].Value == null || dataGridView1[i, 2].Value == null)
                    continue;

                _nodeConnections.Add(new NodeConnection(dataGridView1[i, 0].Value.ToString(), dataGridView1[i, 1].Value.ToString(), dataGridView1[i, 2].Value.ToString()));
            }
            CreateMatrix();
            CreateAdjacencyMatrix();
            CreateIncidencyMatrix();
        }

        private void CreateIncidencyMatrix() {
            var incMatrix = new string[_matrix.GetLength(0), _nodeConnections.Count + 1];
            var nodeIndexes = new Dictionary<string, int>();
            var edgeIndexes = new Dictionary<string, int>();

            incMatrix[0, 0] = "";

            for (int i = 1; i < incMatrix.GetLength(0); i++) {
                incMatrix[i, 0] = _matrix[i, 0];
                nodeIndexes.Add(incMatrix[i, 0], i);
            }
            for (int i = 1; i < incMatrix.GetLength(1); i++) {
                incMatrix[0, i] = _nodeConnections[i - 1].Weight;
                edgeIndexes.Add(incMatrix[0, i], i);
            }

            for (int i = 1; i < incMatrix.GetLength(0); i++) {
                for (int j = 1; j < incMatrix.GetLength(1); j++) {
                    incMatrix[i, j] = "0";
                }
            }

            foreach (var item in _nodeConnections) {
                int nodeIndex;
                int edgeIndex;

                nodeIndexes.TryGetValue(item.FirstPoint, out nodeIndex);
                edgeIndexes.TryGetValue(item.Weight, out edgeIndex);
                incMatrix[nodeIndex, edgeIndex] = "1";

                nodeIndexes.TryGetValue(item.SecondPoint, out nodeIndex);
                incMatrix[nodeIndex, edgeIndex] = "1";
            }

            for (int i = 0; i < incMatrix.GetLength(0) - 1; i++) {
                dataGridView4.Columns.Add($"Column{i}", ">");
            }

            for (int i = 0; i < incMatrix.GetLength(1) - 1; i++) {
                dataGridView4.Rows.Add();
            }

            for (int i = 0; i < incMatrix.GetLength(0); i++) {
                for (int j = 0; j < incMatrix.GetLength(1); j++) {
                    dataGridView4[i, j].Value = incMatrix[i, j];
                }
            }
        }

        private void CreateAdjacencyMatrix() {
            var adjMatrix = new string[_matrix.GetLength(0), _matrix.GetLength(1)];

            for (int i = 0; i < _matrix.GetLength(0); i++) {
                adjMatrix[0, i] = _matrix[0, i];
                adjMatrix[i, 0] = _matrix[i, 0];
            }

            for (int i = 1; i < _matrix.GetLength(0); i++) {
                for (int j = 1; j < _matrix.GetLength(1); j++) {
                    if (Convert.ToInt32(_matrix[i, j]) == 0) {
                        adjMatrix[i, j] = "0";
                    } else {
                        adjMatrix[i, j] = "1";
                    }
                }
            }

            _adjacencyMatrix = adjMatrix;

            for (int i = 0; i < _matrix.GetLength(0) - 1; i++) {
                dataGridView3.Columns.Add($"Column{i}", ">");
                dataGridView3.Rows.Add();
            }

            for (int i = 0; i < adjMatrix.GetLength(0); i++) {
                for (int j = 0; j < adjMatrix.GetLength(1); j++) {
                    dataGridView3[i, j].Value = adjMatrix[i, j];
                }
            }
        }

        void CreateMatrix() {
            var list = new List<string>();
            list.Add("0");
            foreach (var item in _nodeConnections) {
                if (!list.Contains(item.FirstPoint)) {
                    list.Add(item.FirstPoint);
                }

                if (!list.Contains(item.SecondPoint)) {
                    list.Add(item.SecondPoint);
                }
            }

            list = list.OrderBy((x) => x).ToList();

            var dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++) {
                dict.Add(list[i], i);
            }

            for (int i = 1; i < list.Count; i++) {
                _graph.AddVertex(list[i]);
            }
            foreach (var item in _nodeConnections) {
                _graph.AddEdge(item.FirstPoint, item.SecondPoint, Convert.ToInt32(item.Weight));
            }
            var matrixList = new List<List<string>>();
            matrixList.Add(list);
            for (int i = 1; i < list.Count; i++) {
                var tempList = Enumerable.Repeat("0", list.Count).ToList();
                tempList[0] = list[i];
                matrixList.Add(tempList);
            }

            foreach (var item in _nodeConnections) {
                int val1;
                int val2;
                dict.TryGetValue(item.FirstPoint, out val1);
                dict.TryGetValue(item.SecondPoint, out val2);
                matrixList[val1][val2] = item.Weight;
                matrixList[val2][val1] = item.Weight;
            }

            for (int i = 0; i < matrixList.Count - 1; i++) {
                dataGridView2.Columns.Add($"Column{i}", ">");
                dataGridView2.Rows.Add();
            }

            var matrix = new string[list.Count, list.Count];

            for (int i = 0; i < matrixList.Count; i++) {
                for (int j = 0; j < list.Count; j++) {
                    dataGridView2[i, j].Value = matrixList[i][j];
                    matrix[i, j] = matrixList[i][j];
                }
            }

            _matrix = matrix;
        }

        void PaintToWhite() {
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                for (int j = 0; j < dataGridView1.RowCount; j++) {
                    dataGridView1[i, j].Style.BackColor = Color.Empty;
                }
            }
        }

        private void button_add_Rows_Click(object sender, EventArgs e) {
            _counter++;
            dataGridView1.Columns.Add("Column", "x" + _counter);
        }

        private void button_Add_Row_Colum_Click(object sender, EventArgs e) {
            dataGridView2.Rows.Add("x" + _counter);
        }

        private void DrawGraphButton_Click(object sender, EventArgs e) {
            var drawGraph = new DrawGraph(pictureBox1, _matrix);
            drawGraph.button1_Click(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e) {
            var minimalValGraph = Dijkstra.graph_of_min_cost(_graph);
        }

        private void ExecuteHamilton_Click(object sender, EventArgs e) {
            int[] path;

            int[,] matrix = new int[_adjacencyMatrix.GetLength(0), _adjacencyMatrix.GetLength(1)];

            for (int i = 0; i < _adjacencyMatrix.GetLength(0); i++) {
                for (int j = 0; j < _adjacencyMatrix.GetLength(1); j++) {
                    matrix[i, j] = Convert.ToInt32(_adjacencyMatrix[i, j]);
                }
            }

            new Hamilton(matrix).Calculate(out path);
        }

        private void button_Save_Mutrix_Click(object sender, EventArgs e) {
            string output = string.Empty;
            string[,] matrix = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];
            List<NodeConnection> nodeConnections = new List<NodeConnection>();

            if (dataGridView2.RowCount != dataGridView2.ColumnCount) {
                MessageBox.Show("Rows != Columns");
                return;
            }

            for (int i = 0; i < dataGridView2.RowCount; i++) {
                for (int j = 0; j < dataGridView2.ColumnCount; j++) {
                    if (dataGridView2[i, j].Value.ToString() == null) {
                        matrix[i, j] = "";
                        continue;
                    }
                    matrix[i, j] = dataGridView2[i, j].Value.ToString();
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    output += matrix[i, j].ToString() + " ";
                }
                output += "\n";
            }

            for (int i = 1; i < matrix.GetLength(0); i++) {
                for (int j = 1; j < matrix.GetLength(1); j++) {
                    if (Convert.ToInt32(matrix[i, j]) == 0) {
                        continue;
                    }
                    nodeConnections.Add(new NodeConnection() {
                        FirstPoint = matrix[i, 0],
                        SecondPoint = matrix[0, j],
                        Weight = matrix[i, j]
                    });
                }
            }

            List<int> nodesToRemoveIndexes = new List<int>();
            for (int i = 0; i < nodeConnections.Count - 1; i++) {
                for (int j = i + 1; j < nodeConnections.Count; j++) {
                    if ((nodeConnections[i].FirstPoint == nodeConnections[j].FirstPoint && nodeConnections[i].SecondPoint == nodeConnections[j].SecondPoint) ||
                        (nodeConnections[i].FirstPoint == nodeConnections[j].SecondPoint && nodeConnections[i].SecondPoint == nodeConnections[j].FirstPoint)) {
                        nodesToRemoveIndexes.Add(i);
                    }
                }
            }

            nodesToRemoveIndexes = nodesToRemoveIndexes.OrderByDescending(x => x).ToList();

            for (int i = 0; i < nodesToRemoveIndexes.Count; i++) {
                nodeConnections.RemoveAt(nodesToRemoveIndexes[i]);
            }

            MessageBox.Show(output);
        }

        private void tabPage6_Click(object sender, EventArgs e) {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
