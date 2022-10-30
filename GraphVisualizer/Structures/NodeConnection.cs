namespace GraphVisualizer.Structures
{
    public struct NodeConnection
    {
        public string FirstPoint;
        public string SecondPoint;
        public string Weight;

        public NodeConnection(string firstPoint, string secondPoint, string weight)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            Weight = weight;
        }
    }
}
