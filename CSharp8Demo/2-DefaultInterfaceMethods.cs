using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Demo
{
   public interface IShoppingCart
    {
        public static void SetDefaultName(string name)
        {
            defaultName = name;
        }
        private static string defaultName = "default";
        void CalculateSubTotal()
        {
            Console.WriteLine($"This is {defaultName} Default IShoppingCart Implementation"); 
        }
        void CalculateTotal();
    }

    public interface ISubTotal
    {
        void CalculateSubTotal()
        {
            Console.WriteLine("This is ISUBTOTAL Default IShoppingCart Implementation");
        }
    }
    public class ShoppingCart : IShoppingCart, ISubTotal
    {
        public void CalculateTotal()
        {
            Console.WriteLine("Calculate Total in ShoppingCart CLASS"); ;
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {

        public void CalculateSubTotal()
        {
            Console.WriteLine("This is BETTER ShoppingCart Implementation of Calculate Subtotal");
        }
        //public BetterShoppingCart()
        //{
        //    IShoppingCart.SetDefaultName("Constructor of BetterShoppingCart");
        //}
        public void CalculateTotal()
        {
            Console.WriteLine("Calculate Total in BETTER ShoppingCart CLASS"); ;
        }
    }
}
