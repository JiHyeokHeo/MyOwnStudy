﻿using System;

// 프로그램을 실행하면 운영체제가 운영할수 있는 메모리를 제공한다
// 거기서 우리가 알아야할 메모리는 스택 메모리, 힙 메모리가 있다. (다른것도 더 있지만 두개가 일단 중요)

//스택 : 불안정하고 일시적으로 사용하는 메모리
//void F()
//{
// int a -> 스택영역안에 들어간 정보 ( 함수가 종료하게 되면 정보가 사라지게 된다. )
//}

// Main 문 안에 mage, mage2, knight, knight2 가 스택에 저장되어있다.
// 복사되는 타입과 참조되는 타입으로 분리해서 본다.
//
// 복사되는 타입은 실제 본체가 들어가게 된다. (Mage)
// hp, attack 즉 8바이트가 할당되게 된다.

// 참조되는 타입은 실제 본체가 가르키고 있는 주소를 나타내게 된다. (Knight) x64영역에선 8바이트, x32 4바이트
// 참조되는 타입은 힙 영역에 저장된다. (하지만 꼭 힙에 저장되는건 아니다)
// ********************* 참조되는 타입은 항상 힙을 가르킨다는 뜻은 아니다.
// void G(ref Mage mage) 이런 경우엔 주소를 넣는 방식이지만 실제 본체는 힙이 아니라 스텍에 존재할수 있다.
// Mage의 주소값을 넣는 방식이지만, Stack에 저장되어있기 때문에 실제로 가르키고 있는 곳은 Stack 영역이다.



// 프로그램이 실행되면서 new Knight()를 실행될때,
// 힙 영역에 할당되게 된다.

// 깊은 복사
// Knight k = Knight.clone();
// 얕은 복사의 개념
// Knight k = knight;

// C++ 같은 언어는 힙에 할당된 메모리를 해제해줘야한다.
// Knight* knight = new Knight();
// delete knight;
// knight = nullptr;

// C#은 자동으로 메모리 해제가 이루어진다.
// 언어차원에서 메모리 관리를 해준다.

namespace CSharpStudy
{
    // Copy
    struct Mage
    {
        public int hp;
        public int attack;
    }

    // Ref
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }
                                // 기본 생성자가 작동 후 hp 변경 생성자가 작동됨. this() 키워드
        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        // 한개짜리 버전도 호출할 수 있다.
        public Knight(int hp, int attack) : this(hp)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int int 생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight1 = new Knight(50, 50);

        }
    }
}