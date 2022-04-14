using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex301
{
    internal class Shop
    {
        public List<Product> products;
        public void Add_product(string _name, double _price, double _ost) 
        {
            bool flag = false;
            Product tmp = new Product(_name,_price,_ost);
            for (int i = 0; i < products.Count; i++) 
            {
                if (tmp.Name==products[i].Name && tmp.Price==products[i].Price) 
                {
                    products[i].Add_Ost(tmp.Ost);
                    flag = true;
                }
            }
            if (!flag) products.Add(tmp);
        }

        public void Reviziya()
        {
            for (int i = 0; i < products.Count; i++) if (products[i].Ost==0) products.RemoveAt(i);
        }

        public int Find_product (string _name, double _price)
        {
            int tmp = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == _name && products[i].Price == _price) tmp = i;
            }
            return tmp;
        }

        public string Bay_Product (string _name, double _price, double _ost)
        {
            int idx = Find_product(_name, _price);
            if (idx != 0) 
            {
                if (products[idx].Ost < _ost) 
                {
                    string tmp = "product is bayed\nIn Shop product\n" + products[idx].Print() + "\nBayes is "+ products[idx].Ost+"\n\n";
                    products[idx].Sub_Ost(products[idx].Ost);
                    return tmp;
                }
                else 
                {
                    products[idx].Sub_Ost(products[idx].Ost);
                    return "product in shop : " + products[idx].Ost + "\nBayed : " + products[idx].Ost + " of product";
                }
            }
            return "Product is not fined";
        }
        public void ShowAllOProductInShop()
        {
            Reviziya();
            Console.WriteLine("Products in shop");
            foreach (Product p in products) Console.WriteLine(p.Print());
        }

        public Shop () { products = new List<Product>(); }

    }
}
