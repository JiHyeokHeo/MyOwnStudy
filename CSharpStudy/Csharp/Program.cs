using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        // 객체지향 -> 은닉성
        class Knight
        {
            // C#에서만 더 좋은 문법이 있는거다.
            // C++에선 안된다.

            // 자동 구현 프로퍼티  // C# 7.0 부터는 초기화까지 가능
            public int Hp { get; set; } = 100;

            //// Getter Get 함수
            //public int GetHp() { return hp; }

            //// Setter Set 함수
            //public void SetHp(int hp) { this.hp = hp; }
        }
       
        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            //knight.Hp = 100;

            knight.Hp = 200;

            int hp = knight.Hp;
        }

    }
}


