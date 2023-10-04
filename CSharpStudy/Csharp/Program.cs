using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();

            // 콜백방식
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
        }

    }
}


