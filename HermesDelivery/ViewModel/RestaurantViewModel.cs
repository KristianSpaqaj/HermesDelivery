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
            CurrentRestaurant = new Restaurant("Bon Appetit", "Labæk 51, 4300 Holbæk", "42 78 41 55", new Menu(new List<MenuItem>(){new MenuItem("Burger", 55),
            new MenuItem("Pasta", 70), new MenuItem("Pizza", 55)}));

        }

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
