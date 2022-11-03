using GraphVisualizer.Structures;
using System;
using System.Collections.Generic;

namespace GraphVisualizer.Algorithms
{
    public struct Edge
    {
        public int Source;
        public int Destination;
        public int Weight;
    }

    public struct Subset
    {
        public int Parent;
        public int Rank;
    }

    public class SpanningTreeAlgorithm
    {
        private Edge[] _edges;
        private int _verticesCount;

        public SpanningTreeAlgorithm(int verticesCount, List<Edge> edges)
        {
            _verticesCount = verticesCount;
            _edges = edges.ToArray();
        }

        private int Find(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        private void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else
            {
                subsets[yroot].Parent = xroot;
                ++subsets[xroot].Rank;
            }
        }

        public Edge[] Calculate()
        {
            Edge[] result = new Edge[_verticesCount];
            int i = 0;
            int e = 0;

            Array.Sort(_edges, delegate (Edge a, Edge b)
            {
                return a.Weight.CompareTo(b.Weight);
            });

            Subset[] subsets = new Subset[_verticesCount];

            for (int v = 0; v < _verticesCount; ++v)
            {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }

            while (e < _verticesCount - 1)
            {
                Edge nextEdge = _edges[i++];
                int x = Find(subsets, nextEdge.Source);
                int y = Find(subsets, nextEdge.Destination);

                if (x != y)
                {
                    result[e++] = nextEdge;
                    Union(subsets, x, y);
                }
            }

            return result;
        }
    }
}
