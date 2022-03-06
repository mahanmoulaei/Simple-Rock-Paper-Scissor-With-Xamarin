using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace input
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicator : ContentPage
    {
        bool state = true;
        public ActivityIndicator()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (state) {
                Bar1.Progress = 0.8;
                Bar3.Progress = 0.2;

                Bar2.ProgressTo(1.0, 2000, Easing.Linear);
                state = false;
            } else
            {
                Bar1.Progress = 0.2;
                Bar3.Progress = 0.8;

                Bar2.ProgressTo(0.0, 2000, Easing.Linear);
                state = true;
            }
        }
    }
}