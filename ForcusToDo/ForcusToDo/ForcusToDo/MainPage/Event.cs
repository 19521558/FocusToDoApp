using System;
using System.Collections.Generic;
using System.Text;

namespace ForcusToDo
{
    class Event
    {
        public DateTime Hour { get; set; }
        public TimeSpan Timespan { get; set; }
        public string Hours => Timespan.Hours.ToString("00");
        public string Minutes => Timespan.Minutes.ToString("00");
        public string Seconds => Timespan.Seconds.ToString("00");
        public string wallpaper { get; set; }
    }
}
