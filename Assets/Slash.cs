using Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assets
{
    public class Slash : Ability
    {
        public Slash() : base(AbilityID.Slash, "Slash", 10) { }

        public override int Damage(LivingCreature Target)
        {
            throw new NotImplementedException();
        }
    }
}
