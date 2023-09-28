using System;

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
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }

        static void Main(string[] args)
        {
            Mage mage;
            mage.hp = 100;
            mage.attack = 50;

            Mage mage2 = mage;

            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            // KillKnight(knight);

            Knight knight2 = knight.Clone();
            knight2.hp = 0;
        }
    }
}