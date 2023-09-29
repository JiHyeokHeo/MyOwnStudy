using System;


namespace CSharpStudy
{
    // OOP(은닉성/상속석/다형성)

    // 자동차
    // 핸들 페달 차문을 열고
        // 전기장치 엔진 기름 <-> 외부 노출
    
    class Knight
    {
        // 접근 한정자
        // public protected private

        private int hp;
        protected int mp;

        public void SetHp(int hp)
        {
            this.hp = hp;
        }

        private void SecretFunction()
        {
            hp = 20;
        }
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            mp = 20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            
            
        }
    }


}