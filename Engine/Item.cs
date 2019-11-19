using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Item
    {
        public readonly ItemID ID;
        public readonly string Name;
        public readonly string NamePlural;

        public Item(ItemID id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }

        public Item(string name, string namePlural)
        {
            Name = name;
            NamePlural = namePlural;
        }

        public Item(Item item)
        {
            ID = item.ID;
            Name = item.Name;
            NamePlural = item.NamePlural;
        }

        public abstract void Use(LivingCreature Target);
    }

    public enum ItemID
    {
        Potion,
        Sword,
        AdventurerPass
    }
}
