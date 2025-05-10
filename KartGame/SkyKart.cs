using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.KartGame
{
    internal class SkyKart : Kart
    {
        public void Flying() 
        {
            Console.WriteLine("離陸！");
        }

        public override void Horn()
        {
            Console.WriteLine("ピッピー");
        }

    }
}
