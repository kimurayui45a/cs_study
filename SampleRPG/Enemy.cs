using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.SampleRPG
{
    internal class Enemy
    {
        public int hp;

        public void Attack()
        {
            Console.WriteLine("敵の攻撃！");
        }

        public void Defense()
        {
            Console.WriteLine("逃げられた！");
        }
    }
}
