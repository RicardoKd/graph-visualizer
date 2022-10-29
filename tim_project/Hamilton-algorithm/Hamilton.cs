using System.Diagnostics;
using tim_project.GraphStructure;

namespace tim_project.Hamilton_algorithm {
  public class AdjacencyMatrix {
    private int[,] adjacencyMatrix;

    public AdjacencyMatrix(Graph graph) {
      int quantityOfVertices = graph.Vertices.Count;

      int[,] adjacencyMatrix = new int[quantityOfVertices, quantityOfVertices];

      if (quantityOfVertices < 2) {
        return;
      }

      for (int i = 0; i < adjacencyMatrix.GetLength(0); i++) {
        for (int j = 0; j < adjacencyMatrix.GetLength(1); j++) {
          adjacencyMatrix[i, j] = 0;
        }
      }

      int counter = 0;
      graph.Vertices.ForEach(x => {
        for (int i = 0; i < x.Edges.Count; i++) {
          int index = graph.Vertices.FindIndex(v => v == x.Edges[i].ConnectedVertex);
          adjacencyMatrix[counter, index] = 1;
        }
        counter += 1;
      });

    }

    public int[,] GetAdjacencyMatrix() {
      return adjacencyMatrix;
    }
  }

  public class HamiltonianCycle {
    readonly int quantityOfVertices;
    int[] path;

    public HamiltonianCycle(int quantityOfVertices) {
      this.quantityOfVertices = quantityOfVertices;
    }

    public bool IsSafe(int v, int[,] graph, int[] path, int pos) {
      if (graph[path[pos - 1], v] == 0)
        return false;

      for (int i = 0; i < pos; i++)
        if (path[i] == v)
          return false;

      return true;
    }

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

    public int HamiltonCycle(int[,] graph) {
      path = new int[quantityOfVertices];
      for (int i = 0; i < quantityOfVertices; i++)
        path[i] = -1;

      path[0] = 0;

      if (HamiltonCycleUtil(graph, path, 1) == false) {
        Debug.WriteLine("\nSolution does not exist");

        return 0;
      }

      return 1;
    }

    /* Print Function*/
    public string ResultToString(int[] path) {
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
    private Graph graph;

    public Hamilton(Graph graph) {
      this.graph = graph;
      HamiltonMethod();
    }

    int[,] CreateAdjacencyMatrix() {
      int quantityOfVertices = graph.Vertices.Count;

      int[,] adjacencyMatrix = new int[quantityOfVertices, quantityOfVertices];

      if (quantityOfVertices >= 3) {
        for (int i = 0; i < adjacencyMatrix.GetLength(0); i++) {
          for (int j = 0; j < adjacencyMatrix.GetLength(1); j++) {
            adjacencyMatrix[i, j] = 0;
          }
        }

        int counter = 0;
        graph.Vertices.ForEach(x => {
          for (int i = 0; i < x.Edges.Count; i++) {
            int index = graph.Vertices.FindIndex(v => v == x.Edges[i].ConnectedVertex);
            adjacencyMatrix[counter, index] = 1;
          }
          counter += 1;
        });

        return adjacencyMatrix;
      }

      return null;
    }

    public void HamiltonMethod() {
      var test = CreateAdjacencyMatrix();
      if (test != null) {

        HamiltonianCycle hamiltonian = new HamiltonianCycle(graph.Vertices.Count);

        int[,] graph1 = test;

        // Print the solution
        hamiltonian.HamiltonCycle(graph1);
      }
    }
  }
}
