using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcumusCodingTask
{
    /// <summary>
    /// class to handle items available for purchase and it's unit price details.
    /// </summary>
    public class Item
    {
        public enum ItemCode
        {
            A,
            B,
            C,
            D,
            E
        }

        /// <summary>
        /// function to calculate unit price for each item
        /// </summary>
        /// <param name="itemCodeValue"></param>
        /// <returns></returns>
        internal double UnitPrice(ItemCode itemCodeValue)
        {
            double unitPrice = 0;

            if (Item.ItemCode.A == itemCodeValue)
            {
                unitPrice = 1.50;
            }
            if (Item.ItemCode.B == itemCodeValue)
            {
                unitPrice = 2.00;
            }
            if (Item.ItemCode.C == itemCodeValue)
            {
                unitPrice = 0.75;
            }
            if (Item.ItemCode.D == itemCodeValue)
            {
                unitPrice = 3.00;
            }
            if (Item.ItemCode.E == itemCodeValue)
            {
                unitPrice = 2.40;
            }

            return unitPrice;
        }
    }
}
