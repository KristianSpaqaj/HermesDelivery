using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.Model
{
    public class Menu : INotifyPropertyChanged
    {
        private ObservableCollection<MenuItem> menuItemList;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MenuItem> MenuItemList { get => menuItemList; set => menuItemList = value; }

        public Menu()
        {
            // MenuItemList = new ObservableCollection<MenuItem>();
            // MenuItemList.Add(new MenuItem("Salat pizza", 60);
            // MenuItemList.Add(new MenuItem("Chesse burger", 50);
            // MenuItemList.Add(new MenuItem("Pomme frites", 35);
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
   
}

