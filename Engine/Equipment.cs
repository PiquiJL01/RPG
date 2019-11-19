using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Equipment : Item
    {
        public new readonly EquipmentID ID;
        public readonly EquipmentType Type;
        public readonly int HealthPointsModifier;
        public readonly int StrengthModifier;
        public readonly int ResistanceModifier;
        public readonly int IntelligenceModifier;
        public readonly int MindModifier;
        public readonly int SpeedModifier;
        public readonly int LuckModifier;


        public Equipment(EquipmentID id, string name, string namePlural, EquipmentType type, int healthPointsModifier, int strengthModifier, int resistanceModifier,
            int intelligenceModifier, int mindModifier, int speedModifier, int luckModifier) 
            : base(name, namePlural)
        {
            ID = id;
            Type = type;
            HealthPointsModifier = healthPointsModifier;
            StrengthModifier = strengthModifier;
            ResistanceModifier = resistanceModifier;
            IntelligenceModifier = intelligenceModifier;
            MindModifier = mindModifier;
            SpeedModifier = speedModifier;
            LuckModifier = luckModifier;
        }

        public override void Use(LivingCreature Target)
        {
            Target.SetEquipment(this);
        }

        public void Use(Player player)
        {
            player.SetEquipment(this);
        }
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
}
