using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class LivingCreature
    {
        public readonly string Name;
        private int Level { get; set; }
        private int MaxHealthPoints { get; set; }
        private int CurrentHealthPoints { get; set; }
        private static readonly List<Status> Conditions = new List<Status>();
        private int Strength { get; set; }
        private int Resistance { get; set; }
        private int Intelligence { get; set; }
        private int Mind { get; set; }
        private int Speed { get; set; }
        private int Luck { get; set; }


        private int IvHealthPoints { get; set; }
        private int IvStrength { get; set; }
        private int IvResistance { get; set; }
        private int IvIntelligence{ get; set; }
        private int IvMind{ get; set; }
        private int IvSpeed { get; set; }

        public static readonly List<Attack> Attacks = new List<Attack>();

        public LivingCreature(string name, int level, int maxHealthPoints, int ivHealthPoints, int strength, int ivStrength, int resistance, int ivResistance, 
            int intelligence, int ivIntelligence, int mind, int ivMind, int speed, int ivSpeed, int luck)
        {
            Name = name;
            Level = level;
            MaxHealthPoints = maxHealthPoints;
            Strength = strength;
            Resistance = resistance;
            Intelligence = intelligence;
            Mind = mind;
            Speed = speed;
            Luck = luck;

            IvHealthPoints = ivHealthPoints;
            IvStrength = ivStrength;
            IvResistance = ivResistance;
            IvIntelligence = ivIntelligence;
            IvMind = ivMind;
            IvSpeed = ivSpeed;
        }

        public void LevelUp(int LevelsUps)
        {
            while (LevelsUps > 0)
            {
                LevelUp();

                LevelsUps -= 1;
            }
        }

        public void LevelUp()
        {
            Level += 1;
            MaxHealthPoints += RNG.NumberBetween(0, IvHealthPoints);
            Strength += RNG.NumberBetween(0, IvStrength);
            Resistance += RNG.NumberBetween(0, IvResistance);
            Intelligence += RNG.NumberBetween(0, IvIntelligence);
            Mind += RNG.NumberBetween(0, IvMind);
            Speed += RNG.NumberBetween(0, IvSpeed);
        }

        public void TakeDamage(int Damage)
        {
            CurrentHealthPoints -= Damage;

            if (CurrentHealthPoints < 0)
            {
                CurrentHealthPoints = 0;
            }
        }

        public void Heal(int Heals)
        {
            CurrentHealthPoints += Heals;
            if (CurrentHealthPoints > MaxHealthPoints)
            {
                CurrentHealthPoints = MaxHealthPoints;
            }
        }

        public void AddStatus(Status status)
        {
            if (!Conditions.Contains(status))
            {
                Conditions.Add(status);
            }
        }

        public void RemoveStatus(Status status)
        {
            if (Conditions.Contains(status))
            {
                Conditions.Remove(status);
            }
        }

        public bool IsStatus(Status status)
        {
            if (Conditions.Contains(status))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAttack(Attack attack)
        {
            if (!Attacks.Contains(attack))
            {
                Attacks.Add(attack);
            }
        }

        public void SetEquipment(Equipment equipment)
        {
            MaxHealthPoints += equipment.HealthPointsModifier;
            Strength += equipment.StrengthModifier;
            Resistance += equipment.ResistanceModifier;
            Intelligence += equipment.IntelligenceModifier;
            Mind += equipment.MindModifier;
            Speed += equipment.SpeedModifier;
            Luck += equipment.LuckModifier;
        }

        public void RemoveEquipment(Equipment equipment)
        {
            MaxHealthPoints -= equipment.HealthPointsModifier;
            Strength -= equipment.StrengthModifier;
            Resistance -= equipment.ResistanceModifier;
            Intelligence -= equipment.IntelligenceModifier;
            Mind -= equipment.MindModifier;
            Speed -= equipment.SpeedModifier;
            Luck -= equipment.LuckModifier;
        }

        public int GetLevel()
        {
            return Level;
        }

        public int GetMaxHP()
        {
            return MaxHealthPoints;
        }

        public int GetHP()
        {
            return CurrentHealthPoints;
        }

        public int GetStrength()
        {
            return Strength;
        }

        public int GetResistance()
        {
            return Resistance;
        }

        public int GetInteligence()
        {
            return Intelligence;
        }

        public int GetMind()
        {
            return Mind;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public int GetLuck()
        {
            return Luck;
        }

        /* IV Getters
        public int GetIvHP()
        {
            return IvHealthPoints;
        }

        public int GetIvStrength()
        {
            return IvStrength;
        }

        public int GetIvResistance()
        {
            return IvResistance;
        }

        public int GetIvIntelligence()
        {
            return IvIntelligence;
        }

        public int GetIvMind()
        {
            return IvMind;
        }

        public int GetIvSpeed()
        {
            return IvSpeed;
        }
        */

        /* Stats and IV Setters
        public void SetMaxHP(int maxHP)
        {
            MaxHealthPoints = maxHP;
        }

        public void SetMaxHP(int maxHP)
        {
            MaxHealthPoints = maxHP;
        }

        public void SetHP(int hp)
        {
            CurrentHealthPoints = hp;
        }

        public void SetStrength(int strength)
        {
            Strength = strength;
        }

        public void SetResistance(int resistance)
        {
            Resistance = resistance;
        }

        public void SetIntelligence(int intelligence)
        {
            Intelligence = intelligence;
        }

        public void SetMind(int mind)
        {
            Mind = mind;
        }

        public void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public void SetLuck(int luck)
        {
            Luck = luck;
        }

        public void SetIvHP(int ivHP)
        {
            IvHealthPoints = ivHP;
        }

        public void SetIvStrength(int ivStrength)
        {
            IvStrength = ivStrength;
        }

        public void SetIvResistance(int ivResistance)
        {
            IvResistance = ivResistance;
        }

        public void SetIvIntelligence(int ivIntelligence)
        {
            IvIntelligence = ivIntelligence;
        }

        public void SetIvMind(int ivMind)
        {
            IvMind = ivMind;
        }

        public void SetIvSpeed(int ivSpeed)
        {
            IvSpeed = ivSpeed;
        }
        */
    }

    public enum Status
    {
        Poisoned
    }
}
