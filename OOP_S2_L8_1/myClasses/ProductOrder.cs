using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S2_L8.myClasses
{
    [Serializable]
    public class ProductOrder : IComparable
    {
        private int price;
        private int quantity;

        public string Client { get; set; }
        public string ProductName { get; set; }
        public int OriginalPrice {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0) throw new ArgumentException();
                price = value;
            }
        }

        public int Quantity { 
            get
            {
                return quantity;
            }
            set
            {
                if (value <= 0) throw new ArgumentException();
                quantity = value;
            }
        }

        public int Discount
        {
            get
            {
                if (Quantity >= 2 && Quantity < 5)
                {
                    return 3;
                }
                else if (Quantity >= 5 && Quantity < 10)
                {
                    return 5;
                }
                else if (Quantity >= 10)
                {
                    return 7;
                }
                return 0;
            }
        }

        public int PriceWithDiscount => OriginalPrice - (int)(OriginalPrice * (Discount / 100.0));

        public ProductOrder(string client, string productName, int price, int quantity)
        {
            Client = client;
            ProductName = productName;
            OriginalPrice = price;
            Quantity = quantity;
        }

        public ProductOrder()
        {
            Client = "John Doe";
            ProductName = "Bread";
            OriginalPrice = 20;
            Quantity = 4;
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is ProductOrder)) return -1;
            ProductOrder another = (ProductOrder)obj;
            return this.Quantity.CompareTo(another.Quantity);
        }
    }

}