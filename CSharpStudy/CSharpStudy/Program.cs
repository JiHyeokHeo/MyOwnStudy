using System;


namespace CSharpStudy
{
    // OOP(은닉성/상속성/다형성)
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동");
        }
    }

    // 오버로딩 함수 이름의 재사용 (파라미터의 다양성)
    // 오버라이드 다형성을 활용한 것

    class Knight : Player
    {
        public override void Move()       
        {
            base.Move();

            Console.WriteLine("Knight 이동");
        }
    }

    class Mage : Player
    {
        public override void Move()
        {
            Console.WriteLine("Mage 이동");
        }
        public int mp;
    }

    class SuperKnight : Knight
    {
        public override void Move() 
        {
            base.Move();

            Console.WriteLine("SuperKnight 이동!");
        }
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
            player.Move();
         
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();

            //EnterGame(mage);
        }
    }


}