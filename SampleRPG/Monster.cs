﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.SampleRPG
{

    internal class Monster : Enemy 
    {
        public override void Move()
        {
            Console.WriteLine("突進");
        }
    }

}
