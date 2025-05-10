using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.SampleRPG
{
    // プライマリコンストラクターを使用（C# 12 以降）
    internal class Player(string name = "名無し", int hp = 100)
    {
        //書き込みは可能、更新はクラス内でのみ可能
        //この書き方ならゲッターセッターの隠蔽問題は解決するのか？
        public string Name { get; private set; } = name;

        //public string Name { get; }


        public int Hp { get; private set; } = hp;


        public void UpdateName(string name) 
        {
            if (name != null)
            {
                if (name.Length <= 8)
                {
                    Name = name;
                }
                else 
                {
                    Console.WriteLine("無効な名前");
                }
            }

        }

        public void UpdateHp(int hp)
        {
            //条件チェックし、 hp が 0 未満なら 0 を使う。そうでなければそのまま hp を使う。
            Hp = hp < 0 ? 0 : hp;
        }



        public void Attack() 
        {
            Console.WriteLine(Name + "は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(Name + "は防御した");
        }

    }
}
