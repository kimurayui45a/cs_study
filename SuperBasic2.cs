using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy
{
    internal class SuperBasic2
    {


        public static void Run()
        {

            float[] weights;
            weights = new float[7];

            weights[0] = 41.2f;
            weights[1] = 41.5f;
            weights[2] = 44.9f;
            weights[3] = 43.2f;

            // Console.WriteLine(weights)では中の確認は行えないので、joinで一行に表示
            Console.WriteLine(string.Join(", ", weights));

            // 1つずつ取り出して表示
            for (int i = 0; i < 7; i++) {
                Console.WriteLine(weights[i]);
            }

            // 節目の表示
            LineBorder.Line();

            float[] weights2 = { 41.2f, 41.3f, 42.2f, 45.2f };
            for (int i = 0; i < weights2.Length; i++) 
            {
                Console.WriteLine(weights2[i]);
            }

            // 節目の表示
            LineBorder.Line();

            float[] weights3 = { 41.2f, 41.3f, 42.2f, 45.2f };
            foreach (float w in weights3) 
            {
                Console.WriteLine(w);
            }

            // 節目の表示
            LineBorder.Line();

            float[] weights4 = { 41.2f, 41.3f, 42.2f, 45.2f };
            float sum = 0.0f;
            foreach (float w in weights4)
            {
                sum += w;
            }
            float average = sum / weights4.Length;
            Console.WriteLine("平均値" + average);


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-18
            Console.WriteLine("練習問題3-18");
            float[] weights5 = { 41.2f, 42.54f, 44.9f, 43.0f, 45.1f, 43.2f, 42.7f };
            foreach(float w in weights5)
            {
                if (w <= 43.0f) 
                { 
                    // 43.0は43で表示される
                    Console.WriteLine(w);

                    // 小数点以下1桁で表示（小数第2位は四捨五入され、 小数第1位までが表示）
                    Console.WriteLine($"{w:0.0}");

                }
            }

        }


    }
}
