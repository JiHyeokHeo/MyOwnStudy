using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board();
            Player player = new Player();
            board.Initialize(25, player);
            player.Initialize(1, 1, board);

            Console.CursorVisible = false;

            const int WALL_TICK = 1000 / 30;

            int lastTick = 0;
            while(true)
            {
                #region 프레임관리
                // 만약에 경과된 시간이 1 / 30초보다 작다면
                int currentTick = System.Environment.TickCount & Int32.MaxValue;
                // ms 이므로
                if (currentTick - lastTick < WALL_TICK)
                    continue;
                int deltaTick = currentTick - lastTick; 
                lastTick = currentTick;
                #endregion

                // 입력 


                // 로직
                player.Update(deltaTick);

                // 렌더링
                Console.SetCursorPosition(0, 0);
                board.Render();
            }

        }
    }
}


