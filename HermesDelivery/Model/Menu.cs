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
        
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MenuItem> MenuItemList { get; set; }

        public Menu(List<MenuItem> menuitems)
        {
            MenuItemList = new ObservableCollection<MenuItem>(menuitems);
            //test
            //MenuItemList.Add(new MenuItem("Salat pizza", 60));
            //MenuItemList.Add(new MenuItem("Chesse burger", 50));
            //MenuItemList.Add(new MenuItem("Pomme frites", 35));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
   
}

