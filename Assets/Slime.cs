using System;
using System.Collections.Generic;
using System.Text;
using Engine;

namespace Assets
{
    public class Slime : Monster
    {
        public Slime() : base(MonsterID.Slime, "Slime", "Slimes", 1 , 1, 10, 3, 2, 2, 4, 3, 2, 1, 2, 1, 2, 3, int luck)
    }
}
