using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcusToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountDetailsPage : ContentPage
    {
        public AccountDetailsPage()
        {
            InitializeComponent();
        }

        private void ChangeUsername_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ChangeUserPage());
        }
        private void ChangeAccount_Clicked(object o, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ChangeAccountPage());
        }

        private void ChangePw_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new ChangePasswordPage());
        }

        private void SignOut_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Sign Out", "Confirm", "Cancel", "Are you sure to want to sign out?");
        }
    }
}