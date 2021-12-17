using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcusToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkAlarmPage : ContentPage
    {
        public WorkAlarmPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<WorkAlarm> WorkAlarms { get => WorkAlarmData(); }

        private List<WorkAlarm> WorkAlarmData()
        {
            var WorkAlarmList = new List<WorkAlarm>();
            WorkAlarmList.Add(new WorkAlarm { Sound = "None", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bell1", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bell2", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bicycle Bell", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Clown Horn", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Piano music", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Wind Chimes", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Party Horn", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Ring tone", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bird call", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Clock", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Cuckoo", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Musical", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Whistle", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Cuckoo", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Musical", Icon = "tickicon.png" });
            WorkAlarmList.Add(new WorkAlarm { Sound = "Whistle", Icon = "tickicon.png" });

            return WorkAlarmList;
        }

        private void ChooseWorkAlarm_Clicked(object sender, EventArgs e)
        {
            Button MyButton = new Button();
            if(MyButton.IsEnabled)
            {
                MyButton.Text = "ABCDE";
            }
            
        }
    }
    public class WorkAlarm
    {
        public string Sound { get; set; }
        public string Icon { get; set; }
    }
}