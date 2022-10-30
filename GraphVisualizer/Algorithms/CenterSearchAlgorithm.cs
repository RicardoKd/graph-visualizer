using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace GraphVisualizer.Algorithms
{
    public class CenterSearchAlgorithm
    {
        int[,] _primMatrix =
        {
            { 1, 2, 5, 8 },
            { 2, 8, 1, 7 },
            { 2, 1, 7, 3 },
            { 3, 1, 8, 4 } 
        };

        int[,] _weightMatrix =
        {
            { 2, 3, 1, 5 }, 
            { 2, 2, 2, 2 }, 
            { 65, 1, 3, 3 }, 
            { 5, 9, 3, 1 } 
        };

        int _amountOfVertices = 4;
        int _amountOfEdges = 4;

        List<int> vertices = new List<int>();

        public CenterSearchAlgorithm(int[,] primMatrix, int[,] weightMatrix)
        {
            _primMatrix = primMatrix;
            _weightMatrix = weightMatrix;
        }

        public void Execute()
        {
            Center(Maxrow(Multiplication(_primMatrix, _weightMatrix, _amountOfVertices, _amountOfEdges), _amountOfVertices, _amountOfEdges), vertices);
            Center(Maxrow(Addition(_primMatrix, _weightMatrix, _amountOfVertices, _amountOfEdges), _amountOfVertices, _amountOfEdges), vertices);
        }

        static int[,] Addition(int[,] a, int[,] b, int Amountofvertices, int Amountofedges)
        {
            int[,] c = new int[Amountofvertices, Amountofedges];

            for (int i = 0; i < Amountofvertices; i++)
            {
                Debug.WriteLine("");
                for (int j = 0; j < Amountofedges; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }


        static int[,] Multiplication(int[,] a, int[,] b, int Amountofvertices, int Amountofedges)
        {
            int[,] c = new int[Amountofvertices, Amountofedges];

            for (int i = 0; i < Amountofvertices; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Amountofedges; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                }
            }

            return c;
        }


        static int[] Maxrow(int[,] c, int Amountofvertices, int Amountofedges)
        {
            int max = 0;
            int[] d = { 0, 0, 0, 0 };
            for (int i = 0; i < Amountofvertices; i++)
            {
                max = 0;
                for (int j = 0; j < Amountofedges; j++)
                {
                    if (c[i, j] > max) max = c[i, j];
                }
                d[i] = max;

            }
            return d;
        }

        static void Center(int[] d, List<int> vertices)
        {
            int min = 99999;
            int count = 0;
            for (int i = 0; i < d.Length; i++)
            {

                Debug.WriteLine(d[i]);
                if (min > d[i])
                {
                    min = d[i];
                    count = 0;
                }
                if (min == d[i]) count++;
            }

            if (count >= 1)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    if (min == d[i])
                    {
                        vertices.Add(i + 1);
                    }
                }
            }
            Debug.WriteLine("");
            foreach (var v in vertices) Debug.WriteLine(v + " with " + min);

        }
    }
}
