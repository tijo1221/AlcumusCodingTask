using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcumusCodingTask
{
    /// <summary>
    /// class to handle special offers for different items
    /// </summary>
    internal class Offers
    {
        internal enum OfferType
        {
            Two = 2,
            Three = 3
        }

        /// <summary>
        /// function to assign special offer prices for different items
        /// </summary>
        /// <param name="itemCodeValue"></param>
        /// <param name="offersTypeValue"></param>
        /// <returns></returns>
        internal double SpecialOffers(Item.ItemCode itemCodeValue, OfferType offersTypeValue)
        {
            double finalOffer = 0;

            if (Item.ItemCode.B == itemCodeValue)
            {
                if(OfferType.Three == offersTypeValue)
                {
                    finalOffer += 1.00;
                }               
            }
            if (Item.ItemCode.C == itemCodeValue)
            {
                if (OfferType.Two == offersTypeValue)
                {
                    finalOffer += 0.75;
                }               
            }
            if (Item.ItemCode.D == itemCodeValue)
            {
                if (OfferType.Two == offersTypeValue)
                {
                    finalOffer += 1.50;
                }
                if (OfferType.Three == offersTypeValue)
                {
                    finalOffer += 2.00;
                }
            }
            if (Item.ItemCode.E == itemCodeValue)
            {
                if (OfferType.Three == offersTypeValue)
                {
                    finalOffer += 2.40;
                }
            }

            return finalOffer;
        }
    }
}
