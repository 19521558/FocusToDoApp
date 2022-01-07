using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ForcusToDo.Views;
using Rg.Plugins.Popup.Services;
namespace ForcusToDo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
 
        private void User_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserPage());
        }

        private void ThemeSetting_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemeSettingPage());
        }

        private void TodayEvent_Clicked(object sender, EventArgs e)
        {
            var nav = Navigation.PushAsync(new TodayEventPage());
            
        }

        
        private void WhiteNoisepage_Clicked(object sender, EventArgs e)
        {
            var nav = Navigation.PushAsync(new WhiteNoisepage());

        }

        private void FocusPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FocusPage());
        }
        private List<MainChange> MainChangeData()
        {
            var MainChangeList = new List<MainChange>();
            MainChangeList.Add(new MainChange { Wallpaper ="wall2.jpg", UserName = "Lily", UserAvatar = "tickicon.png"});

            return MainChangeList;
        }
        private async void EventPage_Clicked(object sender, System.EventArgs e)
        {
            var calendarPage = new CalendarPage(DateTime.Now);
            await PopupNavigation.Instance.PushAsync(calendarPage);
        }

        private void AddProject_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProjectPage());
        }
        private void lstProject_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Project selectedProject = (Project)e.SelectedItem;
        }
    }

}
