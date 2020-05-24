using HermesDelivery.Common;
using HermesDelivery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace HermesDelivery.ViewModel
{
    public class RestaurantViewModel : INotifyPropertyChanged
    {

        

        public ObservableCollection<MenuItem> MenuCartItem { get; set; }

        private Restaurant _currentRestaurant;
        private RelayCommand _goBack;

        public Restaurant CurrentRestaurant { get => _currentRestaurant; set => _currentRestaurant = value; }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public MenuItem SelectedMenuItem { get; set; }

        public RelayCommand AddNewItem { get; set; }
        public RelayCommand GoBackCommand { get => _goBack; set => _goBack = value; }

        public RestaurantViewModel()
           
        { 
            AddNewItem = new RelayCommand(AddItem);
            GoBackCommand = new RelayCommand(GoBack);
            MenuCartItem = new ObservableCollection<MenuItem>();
            CurrentRestaurant = Navigation.GetParameter<Restaurant>();
            SelectedMenuItem = new MenuItem();
            
        }

        

        public void AddItem()
        {
            MenuCartItem.Add(SelectedMenuItem);
        }

        public void GoBack()
        {
            Navigation.GoBack();
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
