using HermesDelivery.Common;
using HermesDelivery.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.ViewModel
{
    public class CartViewModel
    {
        private int _sumOfCartItems;
        private ObservableCollection<MenuItem> _cartItems;
        private RelayCommand _goBackCommand;

        public int SumOfCartItems { get => _sumOfCartItems; set => _sumOfCartItems = value; }
        public ObservableCollection<MenuItem> CartItems { get => _cartItems; set => _cartItems = value; }
        public RelayCommand GoBackCommand { get => _goBackCommand; set => _goBackCommand = value; }

        public CartViewModel()
        {
            CartItems = Navigation.GetParameter<ObservableCollection<MenuItem>>();
            _sumOfCartItems = CalculateSum(CartItems);
            GoBackCommand = new RelayCommand(GoBack);
            
        }

        public int CalculateSum(ObservableCollection<MenuItem> cartList)
        {
            int sum = 0;
            foreach (MenuItem item in cartList)
            {
                sum = item.Price + sum;
            }
            return sum;
            
        }

        public void GoBack()
        {
            Navigation.GoBack();
        }

        
    }
}
