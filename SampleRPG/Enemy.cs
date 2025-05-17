using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStudy.SampleRPG
{
    // 継承して使用するクラス（abstractによりインスタンスは作成できない）
    internal abstract class Enemy
    {
        public abstract void Move();
    }
}
