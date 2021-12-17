using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ForcusToDo
{
    public class ViewModel : ContentPage
    {
        public ICommand MyCommand { 
            private set; get;
    }

        public ViewModel()
        {
            
        }
    }
}