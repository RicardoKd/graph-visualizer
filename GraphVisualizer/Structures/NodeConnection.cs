namespace GraphVisualizer.Structures
{
    public class NodeConnection
    {
        public string FirstPoint { get; set; }
        public string SecondPoint { get; set; }
        public string Weight { get; set; }

        public NodeConnection(string firstPoint, string secondPoint, string weight)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            Weight = weight;
        }
    }
}
