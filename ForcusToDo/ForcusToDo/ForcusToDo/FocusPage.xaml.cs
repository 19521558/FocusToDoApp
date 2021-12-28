using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcusToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class FocusPage : ContentPage
    {
        Stopwatch stopwatch;
        
        public FocusPage()
        {
            InitializeComponent();
            Setup();
            stopwatch = new Stopwatch();

        }
        private List<Event> AllEvents { get; set; }

        private List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event{ wallpaper = "wall2.jpg", Hour = new DateTime(DateTime.Now.Ticks + new TimeSpan(0, 25, 0).Ticks)},
            };
        }

        
        private void Setup()
        {
                AllEvents = GetEvents();
                eventList.ItemsSource = AllEvents;

                Device.StartTimer(new TimeSpan(0, 0, 1), () =>
                {

                    if (stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                        return false;
                    }

                    else
                    {
                        foreach (var evt in AllEvents)
                        {
                            var timespan = evt.Hour - DateTime.Now;
                            evt.Timespan = timespan;
                        }

                        eventList.ItemsSource = null;
                        eventList.ItemsSource = AllEvents;

                        return true;
                    }
                });
        }

        private void StopWatch_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            stopwatch.Start();
        }
    }
}