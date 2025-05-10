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

            // 節目の表示
            LineBorder.Line();


            // ローカル関数
            static void Shop(string itemName)
            {
                Console.WriteLine("いらっしゃいませ！");

                if (itemName == "薬草")
                {
                    Console.WriteLine(itemName + "は100円です");
                }
                else if (itemName == "棍棒")
                {
                    Console.WriteLine(itemName + "は1500円です");
                }
                else
                {
                    Console.WriteLine("売り切れです");
                }
            }
            Shop("薬草");



            // 節目の表示
            LineBorder.Line();

            // 練習問題3-20
            Console.WriteLine("練習問題3-20");
            static void ShowEvenOrOdd (int num) 
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("偶数です");
                }
                else 
                {
                    Console.WriteLine("奇数です");
                }
            }
            ShowEvenOrOdd(3);


            // 節目の表示
            LineBorder.Line();


            // ローカル関数
            int ShopA(string itemName)
            {
                Console.WriteLine("いらっしゃいませ！");
                int price = 0;

                if (itemName == "薬草")
                {
                    Console.WriteLine(itemName + "は100円です");
                    price = 100;

                    // 条件に合った時点で早く抜けられる（早期リターン）
                    // 小さな処理ならこっちの方が読みやすく、追いやすい(switch 文に似た構造)
                    //return price;
                }
                else if (itemName == "棍棒")
                {
                    Console.WriteLine(itemName + "は1500円です");
                    price = 1500;
                    //return price;
                }
                else
                {
                    Console.WriteLine("売り切れです");
                    price = 0;
                    //return price;
                }

                return price;

            }

            int money = 2500;
            Console.WriteLine("所持金は" + money + "円です");
            int price = ShopA("薬草");
            money -= price;
            Console.WriteLine("所持金は" + money + "円です");


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-21
            Console.WriteLine("練習問題3-21");
            // ローカル関数
            int ShopB(string itemName)
            {
                Console.WriteLine("いらっしゃいませ！");

                if (itemName == "薬草")
                {
                    Console.WriteLine(itemName + "は100円です");
                    return 100;
                }
                else if (itemName == "万能薬")
                {
                    Console.WriteLine(itemName + "は500円です");
                    return 500;
                }
                else if (itemName == "棍棒")
                {
                    Console.WriteLine(itemName + "は1500円です");
                    return 1500;
                }
                else
                {
                    Console.WriteLine("売り切れです");
                    return 0;
                }

            }
            int moneyB = 2500;
            Console.WriteLine("所持金は" + moneyB + "円です");
            int priceB = ShopB("万能薬");
            moneyB -= priceB;
            Console.WriteLine("所持金は" + moneyB + "円です");


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-21、Switch版
            Console.WriteLine("練習問題3-21、Switch版");
            int ShopC(string itemName)
            {
                Console.WriteLine("いらっしゃいませ！");

                switch (itemName)
                {
                    case "薬草":
                        Console.WriteLine(itemName + "は100円です");
                        return 100;

                    case "万能薬":
                        Console.WriteLine(itemName + "は500円です");
                        return 500;

                    case "棍棒":
                        Console.WriteLine(itemName + "は1500円です");
                        return 1500;

                    default:
                        Console.WriteLine("売り切れです");
                        return 0;
                }

            }
            int moneyC = 2500;
            Console.WriteLine("所持金は" + moneyC + "円です");
            int priceC = ShopC("薬草");
            moneyC -= priceC;
            Console.WriteLine("所持金は" + moneyC + "円です");
  
            priceC = ShopC("万能薬");
            moneyC -= priceC;
            Console.WriteLine("所持金は" + moneyC + "円です");


            // 節目の表示
            LineBorder.Line();

            // 練習問題3-22
            Console.WriteLine("練習問題3-22");
            float CalcAverage (float numa, float numb, float numc) 
            {
                float ans;
                ans = (numa + numb + numc) / 3.0f;
                return ans;
            }
            float ans22 = CalcAverage(22.5f, 22.3f, 50.64f);
            Console.WriteLine(ans22);

            // 節目の表示
            LineBorder.Line();

            // 練習問題3-22、可変長
            Console.WriteLine("練習問題3-22、可変長");
            float CalcAverageA(params float[] numbers)
            {
                float sum = 0;
                foreach (var number in numbers) 
                {
                    sum += number;
                }
                float ans;
                ans = sum / numbers.Length;

                // 明示的キャスト（不要だけどOK）
                //float ans = sum / (float)numbers.Length;

                return ans;
            }
            float ans223 = CalcAverageA(22.5f, 22.3f, 50.64f, 40.3f, 3f);
            Console.WriteLine(ans223);


        }
    }
}
