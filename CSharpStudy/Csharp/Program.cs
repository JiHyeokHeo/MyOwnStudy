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
        static int GetHighestScore(int[] scores)
        {
            int maxValue = 0;
            foreach (int score in scores)
            {
                if(maxValue <= score)
                {
                    maxValue = score;
                }
            }

            return maxValue;
        }



        static int GetAverageScore(int[] scores)
        {
            int average = 0;

            foreach (int score in scores) 
            {
                average += score;
            }

            if (scores.Length == 0)
                return 0;

            return average /= scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            if (value > scores.Length - 1)
                return -1;

            return scores[value];
        }

        static void Sort(int[] scores)
        {
            for(int i=0; i<scores.Length; i++)
            {
                int minindex = i;
                for(int j= i; j<scores.Length; j++)
                {
                    if (scores[j] < scores[minindex])
                        minindex = j;
                }

                int temp = scores[i];
                scores[i] = scores[minindex];
                scores[minindex] = temp;
            }
        }


        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            Sort(scores);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}

