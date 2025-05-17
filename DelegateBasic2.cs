using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy
{
    internal class DelegateBasic2
    {
     
        public Func<int, int, int> Method3 { get; }

        public int Sum(int a, int b)
        {
            Console.WriteLine("足し算の結果：" + (a + b));
            return a + b;
        }

        public int multiplication(int a, int b)
        {
            Console.WriteLine("掛け算の結果：" + (a * b));
            return a * b;
        }

        public DelegateBasic2()
        {
            Func<int, int, int> method1 = Sum;
            Func<int, int, int> method2 = multiplication;

            Method3 = method1 + method2;
        }
    }
}
