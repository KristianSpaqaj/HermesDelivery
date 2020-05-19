using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class User
    {
		private string _name;
		private string _address;
		private string _number;
		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
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
		public User(string name, string email, string address, string number)
		{
			this.Name = name;
			this.Number = number;
			this.Address = address;
			this.Email = email;
		}

	}
}
