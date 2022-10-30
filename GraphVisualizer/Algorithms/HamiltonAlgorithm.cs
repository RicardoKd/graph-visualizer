namespace GraphVisualizer.Algorithms
{
    public class HamiltonAlgorithm
    {
        private int _quantityOfVertices;
        private int[,] _adjacencyMatrix;
        private int[] _path;

        public HamiltonAlgorithm(int[,] adjacencyMatrix)
        {
            _adjacencyMatrix = adjacencyMatrix;
            _quantityOfVertices = adjacencyMatrix.GetLength(0) - 1;
            _path = new int[_quantityOfVertices];

            for (int i = 0; i < _quantityOfVertices; i++)
            {
                _path[i] = -1;
            }

            _path[0] = 0;
        }

        public bool Calculate(out int[] path)
        {
            path = new int[_quantityOfVertices];

            if (HamiltonCycle())
            {
                path = _path;
                return true;
            }

            return false;
        }

        private bool HamiltonCycle(int pos = 1)
        {
            if (pos == _quantityOfVertices)
            {
                if (_adjacencyMatrix[_path[pos - 1], _path[0]] == 1)
                {
                    return true;
                }

                return false;
            }

            for (int i = 1; i < _quantityOfVertices; i++)
            {
                if (IsSafe(i, pos))
                {
                    _path[pos] = i;

                    if (HamiltonCycle(pos + 1))
                    {
                        return true;
                    }

                    _path[pos] = -1;
                }
            }

            return false;
        }

        private bool IsSafe(int v, int pos)
        {
            if (_adjacencyMatrix[_path[pos - 1], v] == 0)
            {
                return false;
            }

            for (int i = 0; i < pos; i++)
                if (_path[i] == v)
                    return false;

            return true;
        }
    }
}
