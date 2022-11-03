using GraphVisualizer.Structures;
using System;
using System.Collections.Generic;

namespace GraphVisualizer.Algorithms {
    public struct Edge {
        public int Source;
        public int Destination;
        public int Weight;
    }

    public struct Subset {
        public int Parent;
        public int Rank;
    }

    public class SpanningTreeAlgorithm {
        private List<NodeConnection> Edges;
        private int verticesCount;
        private Edge[] edges;

        public SpanningTreeAlgorithm (int verticesCount, List<NodeConnection> edges) {
            this.verticesCount = verticesCount;
            Edges = new List<NodeConnection>(edges);
            // edges = new Edge[edgesCount];
        }

        private int Find(Subset[] subsets, int i) {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        private void Union(Subset[] subsets, int x, int y) {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else {
                subsets[yroot].Parent = xroot;
                ++subsets[xroot].Rank;
            }
        }

        private void Print(Edge[] result, int e) {
            for (int i = 0; i < e; ++i)
                Console.WriteLine("{0} -- {1} == {2}", result[i].Source, result[i].Destination, result[i].Weight);
        }

        public void Calculate() {
            Edge[] result = new Edge[verticesCount];
            int i = 0;
            int e = 0;

            Array.Sort(edges, delegate (Edge a, Edge b)
            {
                return a.Weight.CompareTo(b.Weight);
            });

            Subset[] subsets = new Subset[verticesCount];

            for (int v = 0; v < verticesCount; ++v) {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }

            while (e < verticesCount - 1) {
                Edge nextEdge = edges[i++];
                int x = Find(subsets, nextEdge.Source);
                int y = Find(subsets, nextEdge.Destination);

                if (x != y) {
                    result[e++] = nextEdge;
                    Union(subsets, x, y);
                }
            }

            Print(result, e);
        }
    }
}
