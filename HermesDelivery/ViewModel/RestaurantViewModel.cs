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

        //private string name;
        //private int price;

        public ObservableCollection<MenuItem> OC_Kurv { get; set; }

        private Restaurant _currentRestaurant;

        public Restaurant CurrentRestaurant { get => _currentRestaurant; set => _currentRestaurant = value; }

        //public string Name { get => name; set => name = value; }
        //public int Price { get => price; set => price = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MenuItem SelectedKurvItem { get; set; }

        public RelayCommand AddNewItem { get; set; }

        public RestaurantViewModel()
           
        { 
            AddNewItem = new RelayCommand(AddItem);
            OC_Kurv = new ObservableCollection<MenuItem>();

            SelectedKurvItem = new MenuItem();


            CurrentRestaurant = new Restaurant("Bon Appetit", "Lundestrædet 3 1tv", "88 88 88 88", new Menu(new List<MenuItem>(){new MenuItem("Burger", 55),
            new MenuItem("Pasta", 70), new MenuItem("Pizza", 55)}));

        }

        public void AddItem()
        {
            //MenuItem oBlomst = new MenuItem(Name, Price);

            //OC_Kurv.Add(oBlomst);

            OC_Kurv.Add(SelectedKurvItem);

            //SletSelectedBlomst.RaiseCanExecuteChanged();
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
