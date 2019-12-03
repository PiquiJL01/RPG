using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public enum Element
    {
        Nill,
        Fire,
        Water,
        Earth,
        Wind
    }

    public enum EffectID
    {
        Stun
    }

    public enum AbilityID
    {
        Slash,
        Fire
    }

    public enum ItemID
    {
        AdventurerPass,
        Potion,
        Sword,
    }

    public enum HealingItemID
    {
        Potion,
    }

    public enum EquipmentID
    {
        Sword
    }

    public enum EquipmentType
    {
        Hat,
        Necklace,
        Shirt,
        ArmorPlate,
        ArmorPants,
        Shoes,
        Belt,
        HandShoes,
        Ring
    }

    public enum Direction
    {
        North,
        South,
        East,
        West
    }

    public enum LocationID
    {
        nill,
        Home,
        TownOfBeginnings,
        Bridge,
        SpiderForest
    }

    public enum MonsterID
    {
        Slime
    }
}
