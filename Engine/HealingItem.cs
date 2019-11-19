using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingItem : Item
    {
        public readonly int HealthPointsRecovery;

        public HealingItem(ItemID id, string name, string namePlural, int healthPointsRecovery = 0) : base(id, name, namePlural)
        {
            HealthPointsRecovery = healthPointsRecovery;
        }

        public override void Use(LivingCreature Target)
        {
            Target.Heal(HealthPointsRecovery);
        }
    }
}
