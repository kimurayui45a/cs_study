using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Ctrl+K → Ctrl+D で自動整形


namespace CsStudy
{
    internal class SuperBasic
    {


        public static void Run()
        {
            // 練習問題3-5
            Console.WriteLine("練習問題3-5");
            int a = 15;
            int b = 2;
            float answer = (float)a / b;
            Console.WriteLine(answer);


            // 後置インクリメント演算子
            //今の値を使ってから、あとで1増やす
            int c = 2;
            Console.WriteLine(c++);  // 出力：2（使ってから増える）
            Console.WriteLine(c);    // 出力：3（1増えてる）

            // 節目の表示
            LineBorder.Line();

            // 練習問題3-6
            Console.WriteLine("練習問題3-6");
            int d = 10;
            for (int i = 1; i <= 2; i++)
            {
                d--;
            }
            Console.WriteLine(d);

            d /= 4;
            Console.WriteLine(d);

            // 節目の表示
            LineBorder.Line();

            int playerPosX = 10;
            int enemyPosX = 10;
            if (playerPosX == enemyPosX)
            {
                Console.WriteLine("敵と遭遇");
            }

            // 節目の表示
            LineBorder.Line();

            // 練習問題3-7
            Console.WriteLine("練習問題3-7");
            int num = 10;
            if (num >= 3)
            {
                Console.WriteLine("勝ち");
            }

            // 節目の表示
            LineBorder.Line();

            int player1PosX = 2;
            int player2PosX = 6;
            if (player1PosX == 2)
            {
                if (player2PosX == 6)
                {
                    Console.WriteLine("仕掛け解除");
                }
            }

            // 節目の表示
            LineBorder.Line();

            //int player1PosX = 2;
            //int player2PosX = 6;
            if (player1PosX == 2 && player2PosX == 6)
            {
                Console.WriteLine("仕掛け解除");
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-8
            //int player1PosX = 2;
            //int player2PosX = 6;
            Console.WriteLine("練習問題3-8");
            if (player1PosX == 1 || player2PosX == 4)
            {
                Console.WriteLine("仕掛け解除");
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-9
            Console.WriteLine("練習問題3-9");
            if ((player1PosX == 2 && player2PosX == 6) || (player1PosX == 6 && player2PosX == 2))
            {
                Console.WriteLine("仕掛け解除");
            }


            // 節目の表示
            LineBorder.Line();

            int playerPosY = 2;
            if (playerPosY == 0)
            {
                Console.WriteLine("走る");
            }
            else
            {
                Console.WriteLine("泳ぐ");
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-10
            Console.WriteLine("練習問題3-10");
            int num2 = 10;
            if (num2 >= 3)
            {
                Console.WriteLine("勝ち");
            }
            else
            {
                Console.WriteLine("負け");
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-11
            Console.WriteLine("練習問題3-11");
            int hp = 100;
            int mapType = 0;

            if (mapType == 1)
            {
                hp += 10;
            }
            else if (mapType == 2)
            {
                hp -= 5;
            }
            else if (mapType == 3)
            {
                hp = 0;
            }
            else
            {
                Console.WriteLine("HPの変化なし");
            }

            Console.WriteLine("HP=" + hp);

            // 節目の表示
            LineBorder.Line();

            switch (mapType)
            {
                case 1:
                    hp += 10;
                    break;
                case 2:
                    hp -= 5;
                    break;
                case 3:
                    hp = 0;
                    break;
                default:
                    Console.WriteLine("HPの変化なし");
                    break;
            }
            Console.WriteLine("HP=" + hp);


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-12
            Console.WriteLine("練習問題3-12");
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("逃走！");
            }


            // 節目の表示
            LineBorder.Line();


            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(i + "番！");
            }



            // 節目の表示
            LineBorder.Line();

            // 練習問題3-13
            //int e = 2;
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(e);
            //    e++;
            //}
            Console.WriteLine("練習問題3-13");
            for (int i = 2; i < 6; i++)
            {
                Console.WriteLine(i);
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-14
            //for (int i = 0; i < 6; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            Console.WriteLine("練習問題3-14");
            for (int i = 0; i < 5; i += 2)
            {
                Console.WriteLine(i);
            }

            // 節目の表示
            LineBorder.Line();

            for (int i = 3; i > 0; i--) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("スタート");


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-15
            Console.WriteLine("練習問題3-15");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("スタート");


            // 節目の表示
            LineBorder.Line();

            int playerPosA = 5;
            int missilePosX = 15;

            while (playerPosA != missilePosX)
            {
                Console.WriteLine("missile at" + missilePosX);
                missilePosX--;
            }
            Console.WriteLine("HIT");



            // 節目の表示
            LineBorder.Line();

            // 練習問題3-16
            Console.WriteLine("練習問題3-16");
            int ans16 = 10000;
            int count16 = 0;
            while (ans16 > 100) {
                //ans16 = ans16 / 2;
                ans16 /= 2;
                count16++;
            }
            Console.WriteLine(count16);


            // 節目の表示
            LineBorder.Line();

            int playerPosB = 5;
            int missilePosY = 15;

            while (true)
            {
                if (playerPosB == missilePosY)
                {
                    break;
                }
                Console.WriteLine("missile at" + missilePosY);
                missilePosY--;
            }
            Console.WriteLine("HIT");

            // 節目の表示
            LineBorder.Line();

            // 練習問題3-17
            Console.WriteLine("練習問題3-17");
            int ans17 = 0;
            int num17 = 1;
            while (true) {

                ans17 += num17;
                Console.WriteLine(ans17);

                if (ans17 >= 500) { 
                    break;
                }

                num17++;
            }


        }


    }
}
