using System;
using Engine;

namespace Assets
{
    public class Potion : HealingItem
    {
        public Potion() : base(ItemID.Potion, "Potion", "Potions")
        { 
        }

        public override int Heal(LivingCreature target)
        {
            if (target != null)
            {
                target.Heal(20);
                return 20;
            }

            return 0;
        }

        public override void Use(LivingCreature Target)
        {

        }
    }
}
