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
    public partial class ThemeSettingPage : ContentPage
    {
        public ThemeSettingPage()
        {
            InitializeComponent();
        }
        private void CarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView;
            var views = carousel.VisibleViews;

            if (views.Count > 0)
            {
                foreach (var view in views)
                {
                    var img = view.FindByName<Image>("MenuImg");
                    ViewExtensions.CancelAnimations(img);

                }
            }
        }

        private void AddTheme_Clicked(object sender, EventArgs e)
        {

        }
    }
}