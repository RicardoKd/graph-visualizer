using GraphVisualizer.Algorithms;
using GraphVisualizer.Structures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphVisualizer.Helpers
{
    public static class Convertors
    {
        public static string[,] TableToMatrixOfWeights(List<NodeConnection> nodeConnections)
        {
            var list = new List<string>();
            list.Add("0");
            foreach (var item in nodeConnections)
            {
                if (!list.Contains(item.FirstPoint))
                {
                    list.Add(item.FirstPoint);
                }

                if (!list.Contains(item.SecondPoint))
                {
                    list.Add(item.SecondPoint);
                }
            }

            list = list.OrderBy((x) => x).ToList();

            var dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                dict.Add(list[i], i);
            }

            var matrixList = new List<List<string>>();
            matrixList.Add(list);
            for (int i = 1; i < list.Count; i++)
            {
                var tempList = Enumerable.Repeat("0", list.Count).ToList();
                tempList[0] = list[i];
                matrixList.Add(tempList);
            }

            foreach (var item in nodeConnections)
            {
                int val1;
                int val2;
                dict.TryGetValue(item.FirstPoint, out val1);
                dict.TryGetValue(item.SecondPoint, out val2);
                matrixList[val1][val2] = item.Weight;
                matrixList[val2][val1] = item.Weight;
            }

            var matrix = new string[list.Count, list.Count];

            for (int i = 0; i < matrixList.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    matrix[i, j] = matrixList[i][j];
                }
            }

            return matrix;
        }

        public static string[,] MatrixOfWeightsToIncidencyMatrix(string[,] matrixOfWeights)
        {
            var nodeConnections = MatrixOfWeightsToTable(matrixOfWeights);

            var incidencyMatrix = new string[matrixOfWeights.GetLength(0), nodeConnections.Count + 1];
            var nodeIndexes = new Dictionary<string, int>();
            var edgeIndexes = new Dictionary<string, int>();

            incidencyMatrix[0, 0] = "";

            for (int i = 1; i < incidencyMatrix.GetLength(0); i++)
            {
                incidencyMatrix[i, 0] = matrixOfWeights[i, 0];
                nodeIndexes.Add(incidencyMatrix[i, 0], i);
            }
            for (int i = 1; i < incidencyMatrix.GetLength(1); i++)
            {
                incidencyMatrix[0, i] = nodeConnections[i - 1].Weight;
                edgeIndexes.Add(incidencyMatrix[0, i], i);
            }

            for (int i = 1; i < incidencyMatrix.GetLength(0); i++)
            {
                for (int j = 1; j < incidencyMatrix.GetLength(1); j++)
                {
                    incidencyMatrix[i, j] = "0";
                }
            }

            foreach (var item in nodeConnections)
            {
                int nodeIndex;
                int edgeIndex;

                nodeIndexes.TryGetValue(item.FirstPoint, out nodeIndex);
                edgeIndexes.TryGetValue(item.Weight, out edgeIndex);
                incidencyMatrix[nodeIndex, edgeIndex] = "1";

                nodeIndexes.TryGetValue(item.SecondPoint, out nodeIndex);
                incidencyMatrix[nodeIndex, edgeIndex] = "1";
            }

            return incidencyMatrix;
        }

        public static List<NodeConnection> MatrixOfWeightsToTable(string[,] matrixOfWeights)
        {
            List<NodeConnection> nodeConnections = new List<NodeConnection>();

            for (int i = 1; i < matrixOfWeights.GetLength(0); i++)
            {
                for (int j = 1; j < matrixOfWeights.GetLength(1); j++)
                {
                    if (Convert.ToInt32(matrixOfWeights[i, j]) == 0)
                    {
                        continue;
                    }
                    nodeConnections.Add(new NodeConnection(matrixOfWeights[i, 0], matrixOfWeights[0, j], matrixOfWeights[i, j]));
                }
            }

            List<int> nodesToRemoveIndexes = new List<int>();
            for (int i = 0; i < nodeConnections.Count - 1; i++)
            {
                for (int j = i + 1; j < nodeConnections.Count; j++)
                {
                    if ((nodeConnections[i].FirstPoint == nodeConnections[j].FirstPoint && nodeConnections[i].SecondPoint == nodeConnections[j].SecondPoint) ||
                        (nodeConnections[i].FirstPoint == nodeConnections[j].SecondPoint && nodeConnections[i].SecondPoint == nodeConnections[j].FirstPoint))
                    {
                        nodesToRemoveIndexes.Add(i);
                    }
                }
            }

            nodesToRemoveIndexes = nodesToRemoveIndexes.OrderByDescending(x => x).ToList();

            for (int i = 0; i < nodesToRemoveIndexes.Count; i++)
            {
                nodeConnections.RemoveAt(nodesToRemoveIndexes[i]);
            }

            return nodeConnections;
        }

        public static List<Edge> MatrixOfWeightsToEdges(string[,] matrixOfWeights)
        {
            List<Edge> nodeConnections = new List<Edge>();

            for (int i = 1; i < matrixOfWeights.GetLength(0); i++)
            {
                for (int j = 1; j < matrixOfWeights.GetLength(1); j++)
                {
                    if (Convert.ToInt32(matrixOfWeights[i, j]) == 0)
                    {
                        continue;
                    }
                    nodeConnections.Add(new Edge
                    {
                        Source = i - 1, 
                        Destination = j - 1, 
                        Weight = Convert.ToInt32(matrixOfWeights[i, j])
                    });
                }
            }

            List<int> nodesToRemoveIndexes = new List<int>();
            for (int i = 0; i < nodeConnections.Count - 1; i++)
            {
                for (int j = i + 1; j < nodeConnections.Count; j++)
                {
                    if ((nodeConnections[i].Source == nodeConnections[j].Source && nodeConnections[i].Destination == nodeConnections[j].Destination) ||
                        (nodeConnections[i].Source == nodeConnections[j].Destination && nodeConnections[i].Destination == nodeConnections[j].Source))
                    {
                        nodesToRemoveIndexes.Add(i);
                    }
                }
            }

            nodesToRemoveIndexes = nodesToRemoveIndexes.OrderByDescending(x => x).ToList();

            for (int i = 0; i < nodesToRemoveIndexes.Count; i++)
            {
                nodeConnections.RemoveAt(nodesToRemoveIndexes[i]);
            }

            return nodeConnections;
        }

        public static string[,] MatrixOfWeightsToAdjacencyMatrix(string[,] matrixOfWeights)
        {
            var adjMatrix = new string[matrixOfWeights.GetLength(0), matrixOfWeights.GetLength(1)];

            for (int i = 0; i < matrixOfWeights.GetLength(0); i++)
            {
                adjMatrix[0, i] = matrixOfWeights[0, i];
                adjMatrix[i, 0] = matrixOfWeights[i, 0];
            }

            for (int i = 1; i < matrixOfWeights.GetLength(0); i++)
            {
                for (int j = 1; j < matrixOfWeights.GetLength(1); j++)
                {
                    if (Convert.ToInt32(matrixOfWeights[i, j]) == 0)
                    {
                        adjMatrix[i, j] = "0";
                    }
                    else
                    {
                        adjMatrix[i, j] = "1";
                    }
                }
            }

            return adjMatrix;
        }

        public static string[,] TableToArray(List<NodeConnection> nodeConnections)
        {
            string[,] array = new string[3, nodeConnections.Count + 1];

            array[0, 0] = "First Node";
            array[1, 0] = "Secoond Node";
            array[2, 0] = "Weight";

            for (int i = 1; i < nodeConnections.Count + 1; i++)
            {
                array[0, i] = nodeConnections[i - 1].FirstPoint;
                array[1, i] = nodeConnections[i - 1].SecondPoint;
                array[2, i] = nodeConnections[i - 1].Weight;
            }

            return array;
        }
    }
}
