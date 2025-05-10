using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.KartGame
{
    internal class TurboKart : Kart
    {
        public void Turbo()
        {
            Console.WriteLine("ブースト！");
        }

        public override void Horn()
        {
            Console.WriteLine("ビービー");
        }

    }
}
