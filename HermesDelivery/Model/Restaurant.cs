using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class Restaurant : Store
    {
		public Restaurant(string name, string address, string number, string open, Menu menu) : base(name, address, number, open, menu)
		{


		}

		
	}
}
