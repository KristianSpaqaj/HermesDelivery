﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class Store
    {
		private string _name;
		private string _address;
		private string _number;
		private string _open;
		private Menu _menu;
		
		public string Number
		{
			get { return _number; }
			set { _number = value; }
		}
	
		public string Open
		{
			get { return _open; }
			set { _open = value; }
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

		public Menu Menu { get => _menu; set => _menu = value; }

		public Store(string name, string address, string number, string open, Menu menu )
		{
			this.Name = name;
			this.Address = address;
			this.Number = number;
			this.Open = open;
			this.Menu = menu;
			
		}



	}
}
