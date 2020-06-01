using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class MenuItem
    {
            private string _name;
            private int _price;

            public int Price
            {
                get { return _price; }
                set { _price = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public MenuItem(string name, int price)
            {
            this.Name = name;
            this.Price = price;

            }

        public MenuItem()
        {
        }
    }
}
