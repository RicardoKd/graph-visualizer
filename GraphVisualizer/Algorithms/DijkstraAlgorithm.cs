using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GraphVisualizer.Algorithms
{
    public class DijkstraAlgorithm
    {
        private int _verticesCount;
        private int[,] _matrix;

        public DijkstraAlgorithm(int[,] matrix)
        {
            _matrix = matrix;
            _verticesCount = matrix.GetLength(0);
        }

        public List<List<string>> Calculate()
        {
            List<List<string>> result = new List<List<string>>();
            for (int i = 0; i < _verticesCount; i++)
            {
                result.Add(Dijkstra(i));
            }
            return result;
        }

        private int MinimumDistance(int[] distance, bool[] shortestPathTreeSet)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < _verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private List<string> Dijkstra(int source)
        {
            int[] distance = new int[_verticesCount];
            bool[] shortestPathTreeSet = new bool[_verticesCount];

            for (int i = 0; i < _verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < _verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < _verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(_matrix[u, v]) && distance[u] != int.MaxValue && distance[u] + _matrix[u, v] < distance[v])
                        distance[v] = distance[u] + _matrix[u, v];
            }

            var list = new List<string>();
            for (int i = 0; i < _verticesCount; ++i)
            {
                list.Add(Convert.ToString(i));
                list.Add(Convert.ToString(distance[i]));
            }

            return list;
        }
    }
}