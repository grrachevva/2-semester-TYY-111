using System;
using System.IO;


namespace lr_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string path1 = Environment.CurrentDirectory + @"\" + "storage01.txt";
            string path2 = Environment.CurrentDirectory + @"\" + "storage02.txt";
            string path3 = Environment.CurrentDirectory + @"\" + "storage03.txt";


            string[] lines = File.ReadAllLines(path1);
            string[,] matrix = new string[lines.Length, 4];


            for (int i = 0; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split('$');
                for (int j = 0; j < elements.Length; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }
            Console.WriteLine("Наименования товаров, количество которых равно нулю:");
            StreamWriter sw = new StreamWriter(path2);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (Int32.Parse(matrix[i, 2]) == 0)
                {
                    sw.WriteLine(matrix[i, 1]);

                    Console.WriteLine(matrix[i, 1]);

                    count++;
                }
            }
            sw.Close();

            string[,] matrix2 = new string[lines.Length - count, 4];
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (Int32.Parse(matrix[i, 2]) != 0)
                {
                    matrix2[index, 0] = matrix[i, 0];
                    matrix2[index, 1] = matrix[i, 1];
                    matrix2[index, 2] = matrix[i, 2];
                    matrix2[index, 3] = matrix[i, 3];
                    index++;
                }
            }

            int n = matrix2.GetLength(0);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Int32.Parse(matrix2[j, 2]) < Int32.Parse(matrix2[j + 1, 2]))
                    {
                        for (int k = 0; k < matrix2.GetLength(1); k++)
                        {
                            string temp = matrix2[j, k];
                            matrix2[j, k] = matrix2[j + 1, k];
                            matrix2[j + 1, k] = temp;
                        }
                    }
                }
            }

            StreamWriter sw2 = new StreamWriter(path3);
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                string res = $"{matrix2[i, 0]} {matrix2[i, 1]} {matrix2[i, 2]} {matrix2[i, 3]}";
                sw2.WriteLine(res);
            }
            sw2.Close();
            Console.ReadKey(true);
        }
    }
}
