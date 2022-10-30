using GraphVisualizer.Structures;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GraphVisualizer.Algorithms
{
    public class PrimsAlgorithm
    {
        private int _verticesCount;
        private int[,] _matrix;

        public PrimsAlgorithm(int[,] matrix)
        {
            _matrix = matrix;
            _verticesCount = _matrix.GetLength(0);
        }

        private int MinKey(int[] key, bool[] set)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < _verticesCount; ++v)
            {
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public List<NodeConnection> ExecutePrimsAlgorithm()
        {
            int verticesCount = _matrix.GetLength(0);
            int[] parent = new int[verticesCount];
            int[] key = new int[verticesCount];
            bool[] mstSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinKey(key, mstSet);
                mstSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (Convert.ToBoolean(_matrix[u, v]) && mstSet[v] == false && _matrix[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = _matrix[u, v];
                    }
                }
            }

            return GetTable(parent);
        }

        private List<NodeConnection> GetTable(int[] parent)
        {
            List<NodeConnection> list = new List<NodeConnection>();
            for (int i = 1; i < _verticesCount; ++i)
                list.Add(new NodeConnection(Convert.ToString(parent[i]), Convert.ToString(i), Convert.ToString(_matrix[i, parent[i]])));
            return list;
        }
    }
}
