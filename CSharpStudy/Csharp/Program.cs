namespace Csharp
{
    class Player
    {

    }

    class Monster
    {

    }

    class Program
    {
        Player player;

        // 상당히 비효율적이다
        Monster monster;
        Monster monster1;
        Monster monster2;

        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10, 20, 30, 40, 50 };
            int[] scores2 = scores;

            // 0 1 2 3 4
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            for(int i =0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach(int score in scores)
            {
                Console.WriteLine(score); 
            }


        }
    }
}

