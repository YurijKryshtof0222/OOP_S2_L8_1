using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_S2_L8.myClasses
{
    public class ProductOrderList : List<ProductOrder>
    {
        public override string ToString()
        {
            string str = "product order list";

            int i = 0;
            foreach(ProductOrder item in this)
            {
                str += i++ + ".) " + item.ToString() + ";\n";
            }

            return str;
        }

        public void writeToFile(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductOrderList));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, this);
            }
        }
        public ProductOrderList readFromFile(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ProductOrderList));
            using (StreamReader reader = new StreamReader(fileName))
            { 
                 return (ProductOrderList)serializer.Deserialize(reader);
            }
        }

        public ProductOrderList prodictsWithDiscount()
        {
            ProductOrderList productOrders = new ProductOrderList();

            foreach (ProductOrder productOrder in this)
            {
                if (productOrder.Discount != 0)
                    productOrders.Add(productOrder);
            }
            return productOrders;
        }

    }

}
