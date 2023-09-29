using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[2, 3];

            // 가변배열
            int[][] a = new int[3][];
            a[0] = new int[5];
            a[1] = new int[12];
            a[2] = new int[3];

            for(int y=0; y < a.Length; y++)
            {
                for(int x=0; x<a[y].Length; x++)
                {
                    Console.Write(a[y][x]);
                }
                Console.WriteLine();
            }
        }
    }
}

