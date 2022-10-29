using System;
using System.Diagnostics;
using tim_project.GraphStructure;

namespace tim_project.Hamilton_algorithm {
  public class HamiltonianCycle {
    readonly int quantityOfVertices;
    int[] path;

    public HamiltonianCycle(int quantityOfVertices) {
      this.quantityOfVertices = quantityOfVertices;
    }

    /* Main function */
    public bool IsSafe(int v, int[,] graph, int[] path, int pos) {
      if (graph[path[pos - 1], v] == 0)
        return false;

      for (int i = 0; i < pos; i++)
        if (path[i] == v)
          return false;

      return true;
    }

    /* checker for Hamiltonian cycle */
    public bool HamiltonCycleUtil(int[,] graph, int[] path, int pos) {
      if (pos == quantityOfVertices) {
        if (graph[path[pos - 1], path[0]] == 1)
          return true;
        else
          return false;
      }

      for (int v = 1; v < quantityOfVertices; v++) {
        if (IsSafe(v, graph, path, pos)) {
          path[pos] = v;

          if (HamiltonCycleUtil(graph, path, pos + 1) == true)
            return true;

          path[pos] = -1;
        }
      }

      return false;
    }

    /* Hamiltonian Cycle algorithm. It
    uses hamCycleUtil() function. 

    It returns false if there
    is no Hamiltonian Cycle possible,
    otherwise return true and prints the path.*/
    public int HamiltonCycle(int[,] graph) {
      path = new int[quantityOfVertices];
      for (int i = 0; i < quantityOfVertices; i++)
        path[i] = -1;

      path[0] = 0;

      if (HamiltonCycleUtil(graph, path, 1) == false) {
        Debug.WriteLine("\nSolution does not exist");

        return 0;
      }

      string endResult = PrintSolution(path);

      return 1;
    }

    /* Print Function*/
    public string PrintSolution(int[] path) {
      string result = "";

      Debug.WriteLine("Solution Exists:");
      for (int i = 0; i < quantityOfVertices; i++) {
        Debug.Write("-" + path[i] + "-");
        result += "-" + path[i] + "-";
      }
      // show the complete cycle from start to start
      Debug.WriteLine("-" + path[0] + "-");

      return result;
    }
  }

  public class Hamilton {
    static Graph graph = new Graph();

    public static void Run() {
      ///
      /// Just fill graph with values to test Hamilton algorithm
      ///
      for (int i = 0; i < 5; i++) {
        string vertex_name = i.ToString();
        graph.AddVertex(vertex_name);
      }

      Debug.WriteLine("Vertices:");
      graph.Vertices.ForEach(v => {
        Debug.WriteLine(v.Name);
      });

      string vertex1_name = "0", vertex2_name = "1";
      int e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "1"; vertex2_name = "2";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "2"; vertex2_name = "4";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "1"; vertex2_name = "4";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "1"; vertex2_name = "3";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "3"; vertex2_name = "0";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      vertex1_name = "3"; vertex2_name = "4";
      e_weight = Int32.Parse("1");
      graph.AddEdge(vertex1_name, vertex2_name, e_weight);
      Debug.WriteLine($"\nEDGE with weight {e_weight} connects Vertex {vertex1_name} and Vertex {vertex2_name}");

      ///
      /// Perform Hamilton Algo
      ///
      HamiltonMethod();

      Debug.WriteLine("");
    }

    static int[,] AdjacencyMatrix() {
      int quantityOfVertices = graph.Vertices.Count;
      int[,] AM = new int[quantityOfVertices, quantityOfVertices];

      if (quantityOfVertices >= 3) {


        for (int i = 0; i < AM.GetLength(0); i++) {
          for (int j = 0; j < AM.GetLength(1); j++) {
            AM[i, j] = 0;
          }
        }

        int counter = 0;
        graph.Vertices.ForEach(x => {
          for (int i = 0; i < x.Edges.Count; i++) {
            int index = graph.Vertices.FindIndex(v => v == x.Edges[i].ConnectedVertex);
            AM[counter, index] = 1;
          }
          counter += 1;
        });

        for (int i = 0; i < AM.GetLength(0); i++) {
          for (int j = 0; j < AM.GetLength(1); j++) {
            Debug.Write(' ' + AM[i, j].ToString() + ' ');
          }
          Debug.WriteLine("");
        }

        return AM;
      } else {
        return null;
      }
    }

    public static void HamiltonMethod() {
      var test = AdjacencyMatrix();
      if (test != null) {
        int Vertices_Count = graph.Vertices.Count;

        HamiltonianCycle hamiltonian = new HamiltonianCycle(Vertices_Count);

        int[,] graph1 = test;

        // Print the solution
        hamiltonian.HamiltonCycle(graph1);
      }
    }
  }
}
