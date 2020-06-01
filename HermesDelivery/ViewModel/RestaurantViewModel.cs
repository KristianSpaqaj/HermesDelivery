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
        private RelayCommand _goToCartPageCommand;

        public Restaurant CurrentRestaurant { get => _currentRestaurant; set => _currentRestaurant = value; }

        public RelayCommand RemoveItem { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MenuItem SelectedMenuItem { get; set; }
        public MenuItem SelectedCartItem { get; set; }

        

        public RelayCommand AddNewItem { get; set; }
        public RelayCommand GoBackCommand { get => _goBack; set => _goBack = value; }
        public RelayCommand GoToCartPageCommand { get => _goToCartPageCommand; set => _goToCartPageCommand = value; }

        public RestaurantViewModel()
           
        { 
            GoBackCommand = new RelayCommand(GoBack);
            MenuCartItem = new ObservableCollection<MenuItem>();
            CurrentRestaurant = Navigation.GetParameter<Restaurant>();
            SelectedMenuItem = new MenuItem();
            SelectedCartItem = new MenuItem();
            RemoveItem = new RelayCommand(DeleteItem);
            GoToCartPageCommand = new RelayCommand(GoToCartPage);
            AddNewItem = new RelayCommand(AddItem);
        }

        
        // her tilføjer man en ret fra menu til ens kurv
        public void AddItem()
        {
            MenuCartItem.Add(SelectedMenuItem);
        }
        // ved denne metode bliver man sendt tilbage til den forrige side
        public void GoBack()
        {
            Navigation.GoBack();
        }
        // I denne metode, når man trykker på et element i listen og derefter trykker på en knap som er bundet her til,
        // sletter man den vare man ikke ville have fra ens kurv
        private void DeleteItem()
        {
            MenuCartItem.Remove(SelectedCartItem);
            RemoveItem.RaiseCanExecuteChanged();
        }
        // Denne metode tjekker om der er tilføjet noget til kurve, og hvis der er kan man trykke på knappen
        // som er bundet til denne metode og blive videresent til "CartView"
        public void GoToCartPage()
        {
            
            if (MenuCartItem.Count > 0 )
            {
                Navigation.GoToPage("CartView", MenuCartItem);
            }

        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
