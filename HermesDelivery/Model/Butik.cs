using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class Butik
    {
		private string _name;
		private string _address;
		private string _number;
		private int _rating;

		public int Rating
		{
			get { return _rating; }
			set { _rating = value; }
		}


		public string Number
		{
			get { return _number; }
			set { _number = value; }
		}


		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public Butik(string name, string address, string number, int rating)
		{
			this.Name = name;
			this.Address = address;
			this.Number = number;
			this.Rating = rating;
		}

		public Butik()
		{

		}

	

	}
}
