// See https://aka.ms/new-console-template for more information
using AlcumusCodingTask;

Console.WriteLine("Hello, Welcome!");

var shoppingBasket = new ShoppingBasket();

// create an enum list(shopping basket) and add different items to list for purchasing.
List<Item.ItemCode> items = new List<Item.ItemCode>();

items.Add(Item.ItemCode.D);
items.Add(Item.ItemCode.D);
items.Add(Item.ItemCode.D);
items.Add(Item.ItemCode.D);
items.Add(Item.ItemCode.D);
items.Add(Item.ItemCode.B);

//calculate total price for added items in the basket, after offer reduction.
double totalPrice = shoppingBasket.CalculateTotalPrice(items);

Console.WriteLine($"Total price of items in the Basket after offer reduction is £{totalPrice}");

Console.WriteLine("Thank you!");


