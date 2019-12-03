using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class HealingItem : Item, Healing
    {
        public HealingItem(ItemID id, string name, string namePlural) : base(id, name, namePlural)
        {
        }

        public abstract int Heal(LivingCreature target);
    }
}
