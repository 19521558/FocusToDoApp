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
    public partial class WhiteNoisepage : ContentPage
    {
        public WhiteNoisepage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private List<WhiteNoise> WhiteNoiseData()
        {
            var WhiteNoiseList = new List<WhiteNoise>();
            WhiteNoiseList.Add(new WhiteNoise { Sound = "None", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Bell1", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Bell2", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Bicycle Bell", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Clown Horn", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Piano music", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Wind Chimes", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Party Horn", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Ring tone", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Bird call", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Clock", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Cuckoo", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Musical", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Whistle", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Cuckoo", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Musical", Icon = "tickicon.png" });
            WhiteNoiseList.Add(new WhiteNoise { Sound = "Whistle", Icon = "tickicon.png" });

            return WhiteNoiseList;
        }
    }
}