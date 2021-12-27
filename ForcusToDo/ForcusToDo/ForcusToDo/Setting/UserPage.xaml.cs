using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcusToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }
        private void AccountDetailsPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AccountDetailsPage());
        }

        private void WorkAlarmPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WorkAlarmPage());
        }

        private void BreakAlarmPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BreakAlarmPage());
        }

        private void WhiteNoisepage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhiteNoisepage());
        }

        private void PromodoroLengthPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PromodoroLengthPage());
        }

        private void BreakLengthPage_Clicked(object sender, EventArgs e)
        {
        }
    }

}