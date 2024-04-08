using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace ConsoleApp3
{
    public class Program
    {

        /// <summary>   
        /// <summary>   
        /// 矩阵乘法   
        /// </summary>   
        /// <param name=”matrix1″>矩阵1</param>   
        /// <param name=”matrix2″>矩阵2</param>   
        /// <returns>积</returns>   
        private static double[][] MatrixMult(double[][] matrix1, double[][] matrix2)
        {
            //matrix1是m*n矩阵，matrix2是n*p矩阵，则result是m*p矩阵   
            int m = matrix1.Length, n = matrix2.Length, p = matrix2[0].Length;
            double[][] result = new double[m][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new double[p];
            }
            //矩阵乘法：c[i,j]=Sigma(k=1→n,a[i,k]*b[k,j])   
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    //对乘加法则   
                    for (int k = 0; k < n; k++)
                    {
                        result[i][j] += (matrix1[i][k] * matrix2[k][j]);
                    }
                }
            }
            return result;
        }

        public static double[,] MatrixMN(double[,] matrix1, double[,] matrix2)
        {
            int n1 = matrix1.GetLength(0);
            int m1 = matrix1.GetLength(1);
            int n2 = matrix2.GetLength(0);
            int m2 = matrix2.GetLength(1);

            if (m1 != n2)
            {
                throw new ArgumentException("矩阵的维度不匹配，无法相乘。");
            }

            double[,] result = new double[n1, m2];

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < m1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
        public static void PrintMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] InverseMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n != m)
            {
                throw new ArgumentException("输入的矩阵必须是方阵。");
            }

            int size = n;

            double[,] inverseMatrix = new double[size, size];

            // 计算矩阵的伴随矩阵
            double[,] adjointMatrix = AdjointMatrix(matrix);

            // 计算矩阵的行列式
            double determinant = Determinant(matrix);

            if (determinant == 0)
            {
                throw new ArgumentException("矩阵的行列式为0，无法计算逆矩阵。");
            }

            // 计算逆矩阵
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    inverseMatrix[i, j] = adjointMatrix[i, j] / determinant;
                }
            }

            return inverseMatrix;
        }

        // 计算矩阵的伴随矩阵
        private static double[,] AdjointMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int size = n;

            double[,] adjointMatrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double[,] subMatrix = GetSubMatrix(matrix, i, j);
                    double cofactor = Math.Pow(-1, i + j) * Determinant(subMatrix);
                    adjointMatrix[j, i] = cofactor;
                }
            }

            return adjointMatrix;
        }

        // 计算矩阵的行列式
        private static double Determinant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n != m)
            {
                throw new ArgumentException("输入的矩阵必须是方阵。");
            }

            int size = n;

            if (size == 1)
            {
                return matrix[0, 0];
            }
            else if (size == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                for (int j = 0; j < size; j++)
                {
                    double[,] subMatrix = GetSubMatrix(matrix, 0, j);
                    double cofactor = Math.Pow(-1, 0 + j) * Determinant(subMatrix);
                    determinant += matrix[0, j] * cofactor;
                }
                return determinant;
            }
        }

        // 获取矩阵的子矩阵（去掉指定行和列）
        private static double[,] GetSubMatrix(double[,] matrix, int rowToRemove, int columnToRemove)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int size = n - 1;

            double[,] subMatrix = new double[size, size];

            int rowIndex = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == rowToRemove)
                {
                    continue;
                }

                int columnIndex = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == columnToRemove)
                    {
                        continue;
                    }

                    subMatrix[rowIndex, columnIndex] = matrix[i, j];
                    columnIndex++;
                }

                rowIndex++;
            }

            return subMatrix;
        }


        static void Main(string[] args)
        {
            double[,] a = {
                { 1, 1, 1, 0 },
                { 0, 0, 1, 1 }
            };
            double[,] b = {
                { 1, 0 },
                { 1, 0 },
                { 1, 1 },
                { 0, 1 }
            };

            double[,] res = MatrixMN(a, b);
            //Console.WriteLine(res);
            PrintMatrix(res);
            res = InverseMatrix(res);
            PrintMatrix(res);

        }
    }
}
