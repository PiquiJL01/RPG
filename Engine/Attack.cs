using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Attack
    {
        public readonly AttackID ID;
        public readonly string Name;
        public int BaseDamage { get; set; }
        public readonly AttackType Type;
        public readonly Element Attribute;

        public Attack(AttackID id, string name, int baseDamage, AttackType type)
        {
            ID = id;
            Name = name;
            BaseDamage = baseDamage;
            Type = type;
        }

        public void Damage(LivingCreature Attacker, LivingCreature Target)
        {
            switch (Type)
            {
                case AttackType.Physical:
                    CalculateDamage(Attacker.GetStrength(), Target.GetResistance());
                    break;
                case AttackType.Magical:
                    CalculateDamage(Attacker.GetInteligence(), Target.GetMind());
                    break;
                case AttackType.Heal:
                    CalculateDamage(Attacker.GetMind(), 1);
                    break;
                case AttackType.Status:
                    break;
            }
        }

        private int CalculateDamage(int StatAttack, int StatDefense)
        { 
            return StatAttack*BaseDamage/StatDefense;
        }
    }

    public enum AttackID
    {
        Slash,
        Fire
    }

    public enum AttackType
    {
        Physical,
        Magical,
        Status,
        Heal
    }
}
