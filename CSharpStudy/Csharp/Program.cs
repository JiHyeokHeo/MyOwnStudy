using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            // List <- 동적 배열
            List<int> list = new List<int>();
            for(int i=0; i<5; i++)
                list.Add(i);

            // 삽입 삭제
            list.Insert(2, 10);

            bool isSuccess = list.Remove(3);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(list[i]);

            foreach(int num in list)
                Console.WriteLine(num);
            
        }
    }
}


