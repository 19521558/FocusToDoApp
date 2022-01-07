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

        private List<WorkAlarm> WorkAlarmData()
        {
            var WorkAlarmList = new List<WorkAlarm>();
            WorkAlarmList.Add(new WorkAlarm { Sound = "None"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bell1"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bell2"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bicycle Bell"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Clown Horn"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Piano music"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Wind Chimes"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Party Horn"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Ring tone"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Bird call"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Clock"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Cuckoo"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Musical"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Whistle"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Cuckoo"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Musical"});
            WorkAlarmList.Add(new WorkAlarm { Sound = "Whistle"});

            return WorkAlarmList;
        }
        class WorkAlarm
        {
            public string Sound { get; set; }
        }
    }

}