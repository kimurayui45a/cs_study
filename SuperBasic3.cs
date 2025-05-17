using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SampleRPGをインポート
using CsStudy.SampleRPG;

namespace CsStudy
{
    internal class SuperBasic3
    {
        public static void Run()
        {


            List<float> weights = new List<float>();
            //List<float> weights = new();

            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(44.9f);
            weights.Add(43.2f);
            weights.Add(42.7f);
            weights.Add(41.7f);

            // 1つずつ取り出して表示
            for (int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }


            // 節目の表示
            LineBorder.Line();

            // 簡略化版
            List<float> weights2 = [41.2f, 42.5f, 44.9f, 43.2f, 42.7f, 41.7f];

            foreach (float w in weights2)
            {
                Console.WriteLine(w);
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題5-1
            Console.WriteLine("練習問題5-1");
            List<string> nameList = ["あああ", "さささ", "かかか", "ららら"];

            foreach (string w in nameList)
            {
                Console.WriteLine(w);
            }


            // 節目の表示
            LineBorder.Line();

            List<float> weights3 = new();

            weights3.Add(41.2f);
            weights3.Add(42.5f);
            weights3.Add(44.9f);  // ← 消される値
            weights3.Add(43.2f);
            weights3.Add(42.7f);
            weights3.Add(41.7f);

            weights3.RemoveAt(2);

            // 1つずつ取り出して表示
            for (int i = 0; i < weights3.Count; i++)
            {
                Console.WriteLine(weights3[i]);
            }


            // 節目の表示
            LineBorder.Line();

            List<float> weights4 = new();

            weights4.Add(41.2f);
            weights4.Add(42.5f);
            weights4.Add(44.9f);
            weights4.Add(43.2f);
            weights4.Add(42.7f);
            weights4.Add(41.7f);

            weights4.Sort();

            // 1つずつ取り出して表示
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(weights4[i]);
            }


            // 節目の表示
            LineBorder.Line();

            // 要素数を指定して表示する場合はforの方がシンプル
            List<float> weights5 = [41.2f, 42.5f, 44.9f, 43.2f, 42.7f, 41.7f];

            weights5.Sort();

            int count = 0;
            foreach (float w in weights5)
            {
                if (count >= 3)
                    break;

                Console.WriteLine(w);
                count++;
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題5-2
            Console.WriteLine("練習問題5-2");
            List<float> weights6 = [41.2f, 42.5f, 44.9f, 43.2f, 42.7f, 41.7f];

            // 体重を小さい順に並べ替える
            weights6.Sort();

            // Listを逆順に並べ替える
            weights6.Reverse();

            // 1つずつ取り出して表示
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(weights6[i]);
            }



            // 節目の表示
            LineBorder.Line();

            Dictionary<string, float> weights7 = new Dictionary<string, float>();

            weights7.Add("2023/12/10", 41.2f);
            weights7.Add("2023/12/11", 42.5f);
            weights7.Add("2023/12/12", 44.9f);
            weights7.Add("2023/12/13", 43.2f);
            weights7.Add("2023/12/14", 42.7f);
            weights7.Add("2023/12/15", 41.7f);

            Console.WriteLine(weights7["2023/12/13"]);

            // 節目の表示
            LineBorder.Line();

            // 簡略化
            Dictionary<string, float> weights8 = new()
            {
                { "2023/12/10", 41.2f },
                { "2023/12/11", 42.5f },
                { "2023/12/12", 44.9f },
                { "2023/12/13", 43.2f },
                { "2023/12/14", 42.7f },
                { "2023/12/15", 41.7f }
            };

            // キーが存在するか確認してから取り出す（安全版）
            if (weights8.TryGetValue("2023/12/13", out float w8))
            {
                Console.WriteLine($"体重は {w8} kg です");
            }
            else
            {
                Console.WriteLine("その日付のデータはありません");
            }


            // 節目の表示
            LineBorder.Line();

            // 練習問題5-3
            Console.WriteLine("練習問題5-3");

            Dictionary<string, string> tell = new()
            {
                { "山田", "000-123-4563" },
                { "小山田", "000-469-2488" },
                { "山本", "000-312-7721" }
            };

            // キーが存在するか確認してから取り出す（安全版）
            if (tell.TryGetValue("山田", out var t3))
            {
                Console.WriteLine(t3);
            }
            else
            {
                Console.WriteLine("その日付のデータはありません");
            }

            // 節目の表示
            LineBorder.Line();

            Func<int, int> add5 = n => n + 5;
            Console.WriteLine(add5(3));

            // 節目の表示
            LineBorder.Line();

            // Where：条件で絞る
            int[] hp = { 420, 120, 600, 0, 1200 };
            var newHP = hp.Where(n => n >= 500);

            foreach (int n in newHP) 
            {
                Console.WriteLine(n);
            }

            // 節目の表示
            LineBorder.Line();

            // Select：値を変換する
            int[] hp2 = { 550, 420, 600, 800, 220 };
            var newHP2 = hp2.Select(n => n - 100);
            foreach (int n in newHP2)
            {
                Console.WriteLine(n);
            }

            // 節目の表示
            LineBorder.Line();

            // Count：値をカウントする
            int[] hp3 = { 550, 0, 600, 0, 220 };
            int num = hp3.Where(n => n == 0).Count();
            Console.WriteLine(num);

            // 節目の表示
            LineBorder.Line();

            // 練習問題5-4
            Console.WriteLine("練習問題5-4");

            int[] hp4 = { -1, -10, -5, -40, -15 };
            var newPlus10 = hp4.Select(n => n + 10);
            var new0Ijo = newPlus10.Where(n => n >= 0).Count();
            Console.WriteLine(new0Ijo);


            // 節目の表示
            LineBorder.Line();
            int[] array = { -1, -10, -5, -40, -15 };

            // LINQを使ってすべての要素に「10」足して
            // 結果が「0以上」となる要素の個数を求める
            int num2 = array.Select(n => n + 10).Where(n => n >= 0).Count();

            Console.WriteLine(num2);


            // 節目の表示
            LineBorder.Line();

            //体力でソートする
            List<Player> players = new List<Player>();

            //Visual Studioのおすすめ
            //List<Player> players = [];

            players.Add(new Player("一郎", 70));
            players.Add(new Player("次郎", 60));
            players.Add(new Player("太郎", 100));

            var sortPlayers = players.OrderBy(n => n.Hp);
            foreach (Player player in sortPlayers)
            {
                Console.WriteLine(player.Name);
            }


            // 節目の表示
            LineBorder.Line();

            // 値型
            int num1 = 35;
            int num3 = num1;
            Console.WriteLine(num3);
            num1 = 0;
            Console.WriteLine(num3);


            // 節目の表示
            LineBorder.Line();

            // 参照型
            Player player10 = new Player("たかし", 35);
            Player player20 = new Player("ひろし", 100);

            player20 = player10;
            Console.WriteLine(player20.Hp);
            player10.UpdateHp(2);
            Console.WriteLine(player20.Hp);


            // 節目の表示
            LineBorder.Line();
            static void Heal(ref int hp, int healAmount)
            {
                hp += healAmount;
                Console.WriteLine($"HPが{healAmount}回復しました。現在のHP: {hp}");

            }
            int playerHP = 50;
            Heal(ref playerHP, 20);
            Console.WriteLine($"最終HP: {playerHP}");
            Heal(ref playerHP, 50);
            Console.WriteLine($"最終HP: {playerHP}");

            // 節目の表示
            LineBorder.Line();

            Console.WriteLine("数値を入力してください:");
            string? input = Console.ReadLine();

            if (input != null && int.TryParse(input, out int number))
            {
                Console.WriteLine($"変換成功！入力された値は {number} です。");
            }
            else
            {
                Console.WriteLine("変換失敗：数値として読み取れません。");
            }


        }

    }
}
