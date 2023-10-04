using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize(25);

            Console.CursorVisible = false;

            int lastTick = 0;
            while(true)
            {
                Console.SetCursorPosition(0, 0);
                board.Render();
            }

        }
    }
}


