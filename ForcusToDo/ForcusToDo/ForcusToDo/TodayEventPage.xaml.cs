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
    public partial class TodayEventPage : ContentPage
    {
        public TodayEventPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        private List<TodayTask> TodayTaskData()
        {
            var TodayTaskList = new List<TodayTask>();
            TodayTaskList.Add(new TodayTask { Task = "Study"});

            return TodayTaskList;
        }
    }
}