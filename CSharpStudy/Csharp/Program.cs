using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        abstract class Monster
        {
            public abstract void Shout();
        }

        interface IFlyable
        {
            void Fly();
        }

        // 다중상속의 단점
        // C++ 에선 가능 C#에선 불가능
        // 단점의 이유
        // 다이아몬드의 문제로 인해

        class Orc : Monster, IFlyable
        {
            public override void Shout()
            {
                Console.WriteLine("록타르 오가르!");
            }

            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
             public override void Shout()
            {
                Console.WriteLine("꾸에에엑!");
            }
        }

        //class SkeletonOrc : Orc, Skeleton
        //{
        //    public override void Shout()
        //    {
        //        Console.WriteLine("꾸에에엑!");
        //    }
        //}

        static void Main(string[] args)
        {
            
        }
    }
}


