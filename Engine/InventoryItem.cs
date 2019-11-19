using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
     public class InventoryItem : Item    
    {
        private int Quantity { get; set; }

        public InventoryItem(Item item, int quantity) : base(item)
        {
            Quantity = quantity;
            QtyLimits();
        }

        public override void Use(LivingCreature Target)
        {
            DecreaseQty();
        }

        public void IncreaseQty()
        {
            Quantity = +1;
            QtyLimits();
        }

        public void IncreaseQty(int quantity)
        {
            Quantity = +quantity;
            QtyLimits();
        }

        public void DecreaseQty()
        {
            Quantity = -1;
            QtyLimits();
        }

        public void DecreaseQty(int quantity)
        {
            Quantity = -quantity;
            QtyLimits();
        }

        private void QtyLimits()
        {
            if (Quantity > 99)
            {
                Quantity = 99;
            }

            if (Quantity < 0)
            {
                Quantity = 0;
            }
        }

        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
