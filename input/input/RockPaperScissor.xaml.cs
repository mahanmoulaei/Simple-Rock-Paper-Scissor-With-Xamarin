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
    public partial class RockPaperScissor : ContentPage
    {
        string[] images = { "stone", "paper", "scissor" };
        Random random;
        public RockPaperScissor()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            int machineOption = random.Next(0, 3); //generates 0, 1, and 2
            machineButton.ImageSource = images[machineOption] + ".png";
            if (btn.Text != images[machineOption])
            {
                if (btn.Text == "stone" && images[machineOption] == "scissor")
                {
                    playerProgress.Progress += 0.1;
                } 
                else if (btn.Text == "stone" && images[machineOption] == "paper")
                {
                    machineProgress.Progress += 0.1;
                }
                else if (btn.Text == "scissor" && images[machineOption] == "stone")
                {
                    machineProgress.Progress += 0.1;
                }
                else if (btn.Text == "scissor" && images[machineOption] == "paper")
                {
                    playerProgress.Progress += 0.1;
                }
                else if (btn.Text == "paper" && images[machineOption] == "stone")
                {
                    playerProgress.Progress += 0.1;
                }
                else if (btn.Text == "paper" && images[machineOption] == "scissor")
                {
                    machineProgress.Progress += 0.1;
                }
            }
        }
    }
}