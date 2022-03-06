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
    public partial class imageButton : ContentPage
    {
        bool isPressed = false;

        public imageButton()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!isPressed)
            {     
                Bar1.ProgressColor = Color.Red;
                Bar1.ProgressTo(1, 2000, Easing.Linear);
                btn.ImageSource = "buttonPressed.png";
                isPressed = true;
            } else
            {
                Bar1.ProgressColor = Color.Gold;
                Bar1.ProgressTo(0.0, 2000, Easing.Linear);
                btn.ImageSource = "button.png";
                isPressed = false;
            }
            
        }
    }
}