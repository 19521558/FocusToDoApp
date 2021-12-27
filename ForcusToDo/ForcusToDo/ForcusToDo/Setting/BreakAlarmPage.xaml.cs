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
    public partial class BreakAlarmPage : ContentPage
    {
        public BreakAlarmPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        private List<BreakAlarm> BreakAlarmData()
        {
            var BreakAlarmList = new List<BreakAlarm>();
            BreakAlarmList.Add(new BreakAlarm { Sound = "None", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Bell1", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Bell2", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Bicycle Bell", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Clown Horn", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Piano music", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Wind Chimes", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Party Horn", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Ring tone", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Bird call", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Clock", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Cuckoo", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Musical", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Whistle", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Cuckoo", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Musical", Icon = "tickicon.png" });
            BreakAlarmList.Add(new BreakAlarm { Sound = "Whistle", Icon = "tickicon.png" });

            return BreakAlarmList;
        }
    }
}