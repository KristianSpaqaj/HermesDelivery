using HermesDelivery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HermesDelivery.ViewModel
{
    public class UserViewModel
    {
        private RelayCommand _goBackCommand;
       


        public RelayCommand GoBackCommand { get => _goBackCommand; set => _goBackCommand = value; }
        public void GoBack()
        {
            //Navigation.GoBack();
        }

    }
}
