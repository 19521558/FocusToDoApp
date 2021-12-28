using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ForcusToDo.ViewModel
{
    public class ViewModel : BaseViewModel
    {
        public ViewModel()
        {
            MenuList = GetMenu();

        }

        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Image = "wall1.jpg"},
                new Pick { Image = "wall2.jpg"},
                new Pick { Image = "wall3.jpg"},
                new Pick { Image = "wall4.jpg"}
            };
        }
    }
    public class Pick
    {
        public string Image { get; set; }
    }

    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}

