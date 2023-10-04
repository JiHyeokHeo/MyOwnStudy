using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        static int Find()
        {


            return 0;
        }

        static void Main(string[] args)
        {
            // Nullable -> Null + able
            int? number = null;


            if(number.HasValue)
            {

            }

            int a = number.Value;
            Console.WriteLine(a);
        }
    }
}


