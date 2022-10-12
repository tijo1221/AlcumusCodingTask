using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcumusCodingTask
{
    /// <summary>
    /// class to handle shopping basket functionalities
    /// </summary>
    public class ShoppingBasket
    {
        private double _totalPrice = 0;
        private double _totalOffer = 0;
        Item _item;
        Offers _offer;

        public ShoppingBasket()
        {
            _offer = new Offers();
            _item = new Item();
        }

        /// <summary>
        /// function to calculate total price of basket items after offer reduction
        /// </summary>
        /// <param name="lstItemCode"></param>
        /// <returns></returns>
        public double CalculateTotalPrice(List<Item.ItemCode> lstItemCode)
        {
            foreach (Item.ItemCode itemCode in lstItemCode)
            {
                _totalPrice += _item.UnitPrice(itemCode);
            }

            //calculate the offer and reduce it from total price
            _totalPrice -= CalculateSpecialOffers(lstItemCode);

            //any basket containing 10 or more items receives an additional 10% overall discount
            if (lstItemCode.Count >= 10)
            {
                _totalPrice -= _totalPrice / 10;
            }

            return _totalPrice;
        }

        /// <summary>
        /// function to calculate special offer amount for each item
        /// </summary>
        /// <param name="lstItemCode"></param>
        /// <returns></returns>
        public double CalculateSpecialOffers(List<Item.ItemCode> lstItemCode)
        {
            //counter - calculate how many times we need to group items for the offer(repeat the same offer).
            int counter = 0;

            //take count of each item to calculate the offer.
            int countB = lstItemCode.Where(x => x == Item.ItemCode.B).Count();
            int countC = lstItemCode.Where(x => x == Item.ItemCode.C).Count();
            int countD = lstItemCode.Where(x => x == Item.ItemCode.D).Count();
            int countE = lstItemCode.Where(x => x == Item.ItemCode.E).Count();

            if (countB >= 3)
            {
                counter = countB / 3;

                for(int i = 0; i < counter; i++)
                {
                    _totalOffer += _offer.SpecialOffers(Item.ItemCode.B, Offers.OfferType.Three);
                }
            }

            if (countC >= 2)
            {
                counter = countC / 2;

                for (int i = 0; i < counter; i++)
                {
                    _totalOffer += _offer.SpecialOffers(Item.ItemCode.C, Offers.OfferType.Two);
                }
            }

            if (countD >= 2 || countD >= 3)
            {
                //where a type of item in the basket is eligible for more than one special offer,
                //choose the offer that gives the lowest total price
                if (countD == 3)
                {
                    counter = countD / 3;

                    for (int i = 0; i < counter; i++)
                    {
                        _totalOffer += _offer.SpecialOffers(Item.ItemCode.D, Offers.OfferType.Three);
                    }
                }                
                else
                {
                    counter = countD / 2;

                    for (int i = 0; i < counter; i++)
                    {
                        _totalOffer += _offer.SpecialOffers(Item.ItemCode.D, Offers.OfferType.Two);
                    }
                }
            }
            if (countE >= 3)
            {
                counter = countE / 3;

                for (int i = 0; i < counter; i++)
                {
                    _totalOffer += _offer.SpecialOffers(Item.ItemCode.E, Offers.OfferType.Three);
                }
            }

            return _totalOffer;
        }
    }
}
