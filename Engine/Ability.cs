using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Ability : Attack
    {
        public readonly AbilityID ID;
        public readonly string Name;

        public Ability(AbilityID id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract int Damage(LivingCreature Target);
    }
}
