using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace drugi
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random random;
        private MatrixGenerator()
        {
            this.random = new Random();
        }
        private static MatrixGenerator GetInstance()
        {
            if (instance == null)
                instance = new MatrixGenerator();
            return instance;
        }
        public double[][] GenerateMatrix(int rows, int columns)
        {
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
                matrix[i] = new double[columns];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i][j] = random.NextDouble();
            return matrix;
        }
    }
       
}
