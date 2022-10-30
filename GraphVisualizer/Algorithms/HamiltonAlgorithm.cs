namespace GraphVisualizer.Algorithms
{
    public class HamiltonAlgorithm
    {
        private int _numberOfVertices;
        private int[] _path;
        private int[,] _matrix;

        public HamiltonAlgorithm(int[,] matrix)
        {
            _matrix = matrix;
            _numberOfVertices = _matrix.GetLength(0);
        }

        public bool Calculate(out int[] path)
        {
            path = new int[_numberOfVertices];
            
            _path = new int[_numberOfVertices];
            for (int i = 0; i < _numberOfVertices; i++)
                _path[i] = -1;

            _path[0] = 0;
            if (ProcessHamCycle())
            {
                path = _path;
                return true;
            }

            return false;
        }

        private bool IsSafe(int v, int pos)
        {
            if (_matrix[_path[pos - 1], v] == 0)
                return false;

            for (int i = 0; i < pos; i++)
                if (_path[i] == v)
                    return false;

            return true;
        }

        private bool ProcessHamCycle(int pos = 1)
        {
            if (pos == _numberOfVertices)
            {
                if (_matrix[_path[pos - 1], _path[0]] == 1)
                    return true;
                else
                    return false;
            }

            for (int v = 1; v < _numberOfVertices; v++)
            {
                if (IsSafe(v, pos))
                {
                    _path[pos] = v;

                    if (ProcessHamCycle(pos + 1) == true)
                        return true;

                    _path[pos] = -1;
                }
            }

            return false;
        }
    }
}