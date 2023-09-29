using System;


namespace CSharpStudy
{
    // OOP(은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;
    }


    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    class Program
    {
        static Player FindPlayerById(int id)
        {
            // id에 해당하는 플레이어를 탐색

            // 못찾았으면

            return null;

        }

        static void EnterGame(Player player)
        {
            //bool isMage = (player is Mage);
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();


            EnterGame(mage);
        }
    }


}