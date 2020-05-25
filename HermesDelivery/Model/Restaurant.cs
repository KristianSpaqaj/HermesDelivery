using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class Restaurant : Store
    {
		public Restaurant(string name, string address, string number, Menu menu, int open, int closed) : base(name, address, number, menu, open, closed)
		{


		}

		
	}
}
