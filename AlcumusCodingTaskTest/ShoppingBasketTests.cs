using AlcumusCodingTask;

namespace AlcumusCodingTaskTest
{
    /// <summary>
    /// Used NUnit Framework to create the Test project
    /// unit test cases for ShoppingBasket class units(functionalities).- added only mentioned test cases
    /// </summary>
    public class ShoppingBasketTests
    {
        ShoppingBasket _shoppingBasket;
        List<Item.ItemCode> _items;
        private double _totalPrice;

        [SetUp]
        public void Setup()
        {
            _shoppingBasket = new ShoppingBasket();
            _items = new List<Item.ItemCode>();
            _totalPrice = 0;
        }

        [Test]
        public void CalculateTotalPriceTest_ABCDE()
        {
            _items.Add(Item.ItemCode.A);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.C);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.E);

            _totalPrice = _shoppingBasket.CalculateTotalPrice(_items);          

            Assert.AreEqual(_totalPrice.ToString("F"), "9.65");
        }

        [Test]
        public void CalculateTotalPriceTest_ABBCC()
        {
            _items.Add(Item.ItemCode.A);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.C);
            _items.Add(Item.ItemCode.C);

            _totalPrice = _shoppingBasket.CalculateTotalPrice(_items);           

            Assert.AreEqual(_totalPrice.ToString("F"), "6.25");
        }

        [Test]
        public void CalculateTotalPriceTest_BDDBBEE()
        {
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.E);
            _items.Add(Item.ItemCode.E);

            _totalPrice = _shoppingBasket.CalculateTotalPrice(_items);            

            Assert.AreEqual(_totalPrice.ToString("F"), "14.30");
        }

        [Test]
        public void CalculateTotalPriceTest_DABBDD()
        {
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.A);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.B);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.D);

            _totalPrice = _shoppingBasket.CalculateTotalPrice(_items);         

            Assert.AreEqual(_totalPrice.ToString("F"), "12.50");
        }

        [Test]
        public void CalculateTotalPriceTest_DCDEEECCDD()
        {
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.C);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.E);
            _items.Add(Item.ItemCode.E);
            _items.Add(Item.ItemCode.E);
            _items.Add(Item.ItemCode.C);
            _items.Add(Item.ItemCode.C);
            _items.Add(Item.ItemCode.D);
            _items.Add(Item.ItemCode.D);

            _totalPrice = _shoppingBasket.CalculateTotalPrice(_items);
            
            Assert.AreEqual(_totalPrice.ToString("F"), "13.77");
        }

    }
}