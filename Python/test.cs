using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp3
{
    class Matrix
    {
        //public static List<List<double>> V;

        public static List<List<double>> GetMatrixV(MatrixM m, MatrixN n)
        {
            List<List<double>> v = new List<List<double>>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    List<double> r = new List<double>();
                    if ()
                    // [i][j] * n[I - i - 1][J - j - 1];
                }
            }
            return v;
        }
    }
    class MatrixN
    {
        //public List<List<double>> N;


        /// <summary>
        /// 读取矩阵N
        /// </summary>
        /// <param name="sr">StreamReader对象</param>
        public List<List<double>> Read(StreamReader sr)
        {
            List<List<double>> N = new List<List<double>>();
            for (int i = 0; i < 10; i++)
            {
                List<double> r = new List<double>();
                string[] line = sr.ReadLine().Split('\t');
                for (int j = 0; j < 10; j++)
                {
                    r.Add(double.Parse(line[j]));
                }
                N.Add(r);
            }
            return N;
        }
    }

    class MatrixM
    {
        //public List<List<double>> M;


        /// <summary>
        /// 读取矩阵M
        /// </summary>
        /// <param name="sr">StreamReader对象</param>
        public List<List<double>> Read(StreamReader sr)
        {
            List<List<double>> M = new List<List<double>>();
            for (int i = 0; i < 3; i++)
            {
                List<double> r = new List<double>();
                string[] line = sr.ReadLine().Split('\t');
                for (int j = 0; j < 3; j++)
                {
                    r.Add(double.Parse(line[j]));
                }
                M.Add(r);
            }
            return M;
        }
    }
}
