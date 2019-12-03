using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Monster : LivingCreature
    {
        public readonly MonsterID ID;
        public readonly string PluralName;
        public int Size { get; set; }
        public int PrizeMoney { get; set; }
        public int IvPrizeMoney { get; set; }
        public int ExperienceReward { get; set; }
        public int IvExperienceReward { get; set; }

        public Monster(MonsterID id, string name, string pluralName, int size, int level, int maxHealthPoints, int ivHealthPoints, int strength, int ivStrength, int resistance,
            int ivResistance, int intelligence, int ivIntelligence, int mind, int ivMind, int speed, int ivSpeed, int luck) : 
            base(name, level, maxHealthPoints, ivHealthPoints, strength, ivStrength, resistance, ivResistance, intelligence, ivIntelligence,
            mind, ivMind, speed, ivSpeed, luck)
        {
            ID = id;
            PluralName = pluralName;
            Size = size;
        }

        public void SetLevel(int level)
        {
            base.LevelUp(level);
        }
    }
}
