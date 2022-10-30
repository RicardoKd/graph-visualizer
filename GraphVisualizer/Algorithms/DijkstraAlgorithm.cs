using System.Collections.Generic;
using GraphVisualizer.GraphStructure;

namespace GraphVisualizer.Algorithms
{
    class dij_element //element_for_Dijkstra
    {
        public string v;
        public int weight;
        public bool check;

        public dij_element(int weight, string v, bool check)
        {
            this.weight = weight;
            this.v = v;
            this.check = check;
        }
    }

    class Edge //element for graph of minimal cost
    {
        public string v1, v2;
        public int weight;
        public Edge(string v1, string v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }

    }

    public static class DijkstraAlgorithm
    { //: IDijkstra {

        public static string[][] Dijkstra_algorithm(Graph graph) //Dijkstra's algorithm
        {
            string[][] result = new string[graph.Vertices.Count][];
            for (int i = 0; i < graph.Vertices.Count; i++)
            {
                result[i] = Dijkstra_algorithm_for_one_element(graph, graph.Vertices[i]);
            }
            return result;
        }

        public static string[] Dijkstra_algorithm_for_one_element(Graph graph, GraphVertex start)//Dijkstra's algorithm for one vertex
        {
            string[] result = new string[graph.Vertices.Count];
            dij_element[] arr = new dij_element[graph.Vertices.Count];
            int ind_start = graph.Vertices.IndexOf(start);
            int connectedVer;
            int kolvo_true = 0, k = 0;
            int minweight = -1, prev = -1;
            for (int i = 0; i < graph.Vertices.Count; i++)
            {
                if (i == ind_start) { arr[i] = new dij_element(0, start.Name, true); kolvo_true++; prev = 0; }
                else
                    arr[i] = new dij_element(-1, start.Name, false);
            }
            int now_ind = ind_start;

            while (kolvo_true <= graph.Vertices.Count)
            {
                for (int i = 0; i < graph.Vertices[now_ind].Edges.Count; i++)
                {
                    connectedVer = graph.Vertices.IndexOf(graph.Vertices[now_ind].Edges[i].ConnectedVertex);
                    if ((arr[connectedVer].weight == -1 || arr[connectedVer].weight > (graph.Vertices[now_ind].Edges[i].EdgeWeight) + prev)
                        && arr[connectedVer].check == false)
                    {
                        arr[connectedVer] = new dij_element(graph.Vertices[now_ind].Edges[i].EdgeWeight + prev, graph.Vertices[now_ind].Name, false);
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i].check == false)
                    {
                        if (k == 0 && arr[i].weight != -1) { minweight = arr[i].weight; now_ind = i; }
                        k++;
                        if (arr[i].weight == -1) k--;
                        if (arr[i].weight > 0 && minweight > arr[i].weight)
                        {
                            minweight = arr[i].weight;
                            now_ind = i;
                        }
                    }

                }
                arr[now_ind].check = true;
                kolvo_true++;
                prev = arr[now_ind].weight;
                k = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = "(" + arr[i].weight + ", " + arr[i].v + ")";
            }
            return result;
        }
    }
}