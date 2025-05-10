using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy
{
    // internal（アクセス修飾子）：このアセンブリ（＝プロジェクト）内では自由に使えるけど、他のプロジェクトからは使えない
    internal class LineBorder
    {

        // 節目の表示
        public static void Line()
        {
            Console.WriteLine("----------------------");
        }

    }
}
