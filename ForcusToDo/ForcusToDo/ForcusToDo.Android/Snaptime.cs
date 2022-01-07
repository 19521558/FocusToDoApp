using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.App;

namespace ForcusToDo.Droid
{
    public class SnapTime : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            /*
            var dialog = new SnapTimePickerDialog.Builder();
                    .SetTitle(Resource.String.title)
                    .SetTitleColor(Android.Resource.Color.White)
                    .SetPreselectedTime(new TimeValue(8, 0))
                    .Build();

            dialog.Show(SupportFragmentManager, "FocusToDo");
            */
        }


     
    }
}