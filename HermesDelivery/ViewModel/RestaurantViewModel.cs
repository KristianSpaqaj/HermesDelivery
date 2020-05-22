using HermesDelivery.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace HermesDelivery.ViewModel
{
    public class RestaurantViewModel : INotifyPropertyChanged
    {
        private Restaurant _currentRestaurant;

        public Restaurant CurrentRestaurant { get => _currentRestaurant; set => _currentRestaurant = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public RestaurantViewModel()
        {
            CurrentRestaurant = new Restaurant("Bon Appetit", "Lundestrædet 3 1tv", "88 88 88 88", new Menu(new List<MenuItem>(){new MenuItem("Burger", 55),
            new MenuItem("Pasta", 70), new MenuItem("Pizza", 55), new MenuItem("durum kebab", 67)}));

        }

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
