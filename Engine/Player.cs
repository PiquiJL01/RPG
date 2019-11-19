using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        private int Experience { get; set; }
        private int Money { get; set; }
        private readonly List<InventoryItem> Bag = new List<InventoryItem>();
        private readonly List<Equipment> Equipments = new List<Equipment>(); 

        public Player(string name, int level, int maxHealthPoints, int ivHealthPoints, int strength, int ivStrength, int resistance,
            int ivResistance, int intelligence, int ivIntelligence, int mind, int ivMind, int speed, int ivSpeed, int luck) :
            base(name, level, maxHealthPoints, ivHealthPoints, strength, ivStrength, resistance, ivResistance, intelligence, ivIntelligence, mind,
                ivMind, speed, ivSpeed, luck)
        {
            Experience = 0;
        }

        public int GetExperience()
        {
            return Experience;
        }

        public void AddExperience(int exp)
        {
            Experience += exp;
        }

        public int GetMoney()
        {
            return Money;
        }

        public void EarnMoney(int amount)
        {
            Money += amount;
        }

        public void Pay(int amount)
        {
            Money -= amount;
        } 

        public new void SetEquipment(Equipment equipment)
        {
            if (!Equipments.Contains(equipment))
            {
                if (equipment.Type == EquipmentType.Ring)
                {
                    int nrRings = 0;

                    foreach (Equipment playerEquipment in Equipments)
                    {
                        if (equipment.Type == EquipmentType.Ring)
                        {
                            nrRings += 1;
                        }
                    }

                    if (nrRings < 10)
                    {
                        base.SetEquipment(equipment);
                        Equipments.Add(equipment);
                    }
                }
                else
                {
                    bool typeRepeated = false;

                    foreach (Equipment playerEquipment in Equipments)
                    {
                        if (equipment.Type == playerEquipment.Type)
                        {
                            typeRepeated = true;
                        }
                    }

                    if (!typeRepeated)
                    {
                        base.SetEquipment(equipment);
                        Equipments.Add(equipment);
                    }
                }
            }
        }

        public void RemoveEquipmant(Equipment equipment)
        {
            if (Equipments.Contains(equipment))
            {
                base.RemoveEquipment(equipment);
            }
        }

        public void AddItemToBag(Item item, int quantity = 1)
        {
            bool IsInBag = false;

            foreach (InventoryItem bagItem in Bag)
            {
                if (bagItem.ID == item.ID)
                {
                    IsInBag = true;

                    bagItem.IncreaseQty(quantity);
                }
            }

            if (!IsInBag)
            {
                Bag.Add(new InventoryItem(item, quantity));
            }
        }

        public void UseBagItem(Item item)
        {
            foreach (InventoryItem bagItem in Bag)
            {
                if (item.ID == bagItem.ID)
                {
                    bagItem.Use(null);

                    if (bagItem.GetQuantity() == 0)
                    {
                        Bag.Remove(bagItem);
                    }
                }
            }
        }

        public bool IsItemInBag(Item item)
        {
            foreach (InventoryItem bagItem in Bag)
            {
                if (bagItem.ID == item.ID)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
