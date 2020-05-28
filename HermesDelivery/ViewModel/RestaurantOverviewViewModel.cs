using HermesDelivery.Common;
using HermesDelivery.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace HermesDelivery.ViewModel
{
    public class RestaurantOverviewViewModel
    {
        private ObservableCollection<Restaurant> _restaurantsList;
        private RelayCommand _goToRestaurantPageCommand;
        private Restaurant _selectedRestaurant;


        public ObservableCollection<Restaurant> RestaurantsList { get => _restaurantsList; set => _restaurantsList = value; }
        public RelayCommand GoToRestaurantPageCommand { get => _goToRestaurantPageCommand; set => _goToRestaurantPageCommand = value; }
        public Restaurant SelectedRestaurant { get => _selectedRestaurant; set { _selectedRestaurant = value; GoToRestaurantPage(); } }


        public RestaurantOverviewViewModel()
        {
            RestaurantsList = new ObservableCollection<Restaurant>()
            {
                new Restaurant("Bon Appetit", "Labæk 51", "42 78 41 55", "Mandag-Fredag 10:00-22:00", new Menu(new List<MenuItem>(){new MenuItem("Burger ", 55),
                    new MenuItem("Pasta ", 70), new MenuItem("Pizza", 55), new MenuItem("Lasagne ",60), new MenuItem("Hvidløgs Brød ", 85)})),
                new Restaurant("Texas Steakhouse", "123 Dallas", "12 34 56 78","Mandag-Fredag 10:00-22:00", new Menu(new List<MenuItem>(){new MenuItem ("Burger ", 60),
                    new MenuItem("French Fries ", 36), new MenuItem("T-bone Steak ", 135), new MenuItem("Entrecôte ",120)})),
                new Restaurant("Nippon Sushi", "180 hvidovrevej", "34 45 23 98","Mandag-Fredag 9:00-23:00",new Menu(new List<MenuItem>(){new MenuItem("California rolls ", 75 ),
                    new MenuItem("Fried shrimp ",40), new MenuItem("Springroll ", 45), new MenuItem("Squid Rings ", 75)})),
                new Restaurant("Happy Elephant ", "130 hvidovrevej ", "14 34 42 89", "Mandag-lørdag 10:00-22:00",new Menu(new List<MenuItem>(){new MenuItem("Red Curry Rice ", 75),
                    new MenuItem("Nam Bread ",25), new MenuItem("Tandoori Chicken", 65), new MenuItem("Green Madras Curry", 45)})),
            };
            GoToRestaurantPageCommand = new RelayCommand(GoToRestaurantPage);

        }
        
        // sender SelectedRestaurant til RestaurantView
        public void GoToRestaurantPage()
        {
            if (SelectedRestaurant != null)
            {
                Navigation.GoToPage("RestaurantView", SelectedRestaurant);
            }

        }
    }
}
