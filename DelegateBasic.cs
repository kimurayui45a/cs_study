using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy
{
    // メソッドの型をデリゲートとして定義している
    public delegate int Cal(int a, int b);

    internal class DelegateBasic
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public Cal GetDelegate()
        {
            return Sum;
        }
    }
}
