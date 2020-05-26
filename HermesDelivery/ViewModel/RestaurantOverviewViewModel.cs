using HermesDelivery.Common;
using HermesDelivery.Model;
using Newtonsoft.Json;
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
                new Restaurant("Bon Appetit", "Lundestrædet 3 1tv", "88 88 88 88", "Mandag-Fredag 10:00-22:00", new Menu(new List<MenuItem>(){new MenuItem("Burger", 55),
                    new MenuItem("Pasta", 70), new MenuItem("Pizza", 55)})),
                new Restaurant("Texas Steakhouse", "123 Dallas", "12 34 56 78","Mandag-Fredag 10:00-22:00", new Menu(new List<MenuItem>(){new MenuItem ("Burger", 60), 
                    new MenuItem("French Fries", 36)}))
                
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
