using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcusToDo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

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

        public List<MainChange> MainChanges { get => MainChangeData(); }

        private List<MainChange> MainChangeData()
        {
            var MainChangeList = new List<MainChange>();
            MainChangeList.Add(new MainChange { Wallpaper ="wall2.jpg", UserName = "Lily", UserAvatar = "tickicon.png", TimeFocus= 30});

            return MainChangeList;
        }

        private void FocusPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FocusPage());
        }
    }
    public class MainChange
    {

        public string Wallpaper { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
        public int TimeFocus { get; set; }
    }

}
