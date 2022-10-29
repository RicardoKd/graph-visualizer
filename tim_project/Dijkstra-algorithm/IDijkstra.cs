using tim_project.GraphStructure;

namespace tim_project.Dijkstra_algorithm
{
    public interface IDijkstra
    {
        Graph graph_of_min_cost(Graph graph); //graph of minimal cost
        string[][] Dijkstra_algorithm(Graph graph); //Dijkstra's algorithm
    }
}
