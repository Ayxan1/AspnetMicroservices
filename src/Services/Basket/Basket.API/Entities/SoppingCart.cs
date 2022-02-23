using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class SoppingCart
    {
        public string Username { get; set; }
        public List<ShopingCartItem> Items { get; set; } = new List<ShopingCartItem>();

        public SoppingCart()
        {                            
        }

        public SoppingCart(string username)
        {
            Username = username;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var item in Items)
                {
                    total += item.Price * item.Quantity;
                }

                return total;
            }
        }
    }
}
