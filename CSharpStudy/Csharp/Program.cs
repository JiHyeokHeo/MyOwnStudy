using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        // 업체 사장 - 사장님의 비서
        // 우리의 연락처/용건
        // 거꾸로 -> 연락을 달라고

        // 함수 자체를 인자로 넘기는 방식 = 대리자

        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
        // 반환: int 입력: void
        // OnClicked 이 delegate 형식의 이름이다.

        // UI
        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
        {
            clickedFunction();
        }

        // [ 10 20 40 30 50 ]

        // 게임 관련 로직
        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate 2");
            return 0;
        }

        static void Main(string[] args)
        {
            // delegate (대리자)
            Console.WriteLine();

            // 이런식으로 채이닝 기법도 사용이 가능하다
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2;


            // C++ 함수 포인터랑 비슷하다
            ButtonPressed(clicked);
        }

    }
}


