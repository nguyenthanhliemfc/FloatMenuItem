using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private bool isOpen = false;
        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                isOpen = true;
                //Scale to smaller
                await ((Frame)sender).ScaleTo(0.8, 50, Easing.Linear);
                //Wait a moment
                await Task.Delay(100);
                //Scale to normal
                await ((Frame)sender).ScaleTo(1, 50, Easing.Linear);

                //Show FloatMenuItem1
                FloatMenuItem1.IsVisible = true;
                await FloatMenuItem1.TranslateTo(0, 0, 100);
                await FloatMenuItem1.TranslateTo(0, -20, 100);
                await FloatMenuItem1.TranslateTo(0, 0, 200);

                //Show FloatMenuItem2
                FloatMenuItem2.IsVisible = true;
                await FloatMenuItem2.TranslateTo(0, 0, 100);
                await FloatMenuItem2.TranslateTo(0, -20, 100);
                await FloatMenuItem2.TranslateTo(0, 0, 200);

                //Show FloatMenuItem3
                FloatMenuItem3.IsVisible = true;
                await FloatMenuItem3.TranslateTo(0, 0, 100);
                await FloatMenuItem3.TranslateTo(0, -20, 100);
                await FloatMenuItem3.TranslateTo(0, 0, 200);
            }
            else
            {
                isOpen = false;
                //Scale to smaller
                await ((Frame)sender).ScaleTo(0.8, 50, Easing.Linear);
                //Wait a moment
                await Task.Delay(100);
                //Scale to normal
                await ((Frame)sender).ScaleTo(1, 50, Easing.Linear);

                //Hide FloatMenuItem1
                await FloatMenuItem1.TranslateTo(0, 0, 100);
                await FloatMenuItem1.TranslateTo(0, -20, 100);
                await FloatMenuItem1.TranslateTo(0, 0, 200);
                FloatMenuItem1.IsVisible = false;

                //Hide FloatMenuItem2
                await FloatMenuItem2.TranslateTo(0, 0, 100);
                await FloatMenuItem2.TranslateTo(0, -20, 100);
                await FloatMenuItem2.TranslateTo(0, 0, 200);
                FloatMenuItem2.IsVisible = false;

                //Hide FloatMenuItem3
                await FloatMenuItem3.TranslateTo(0, 0, 100);
                await FloatMenuItem3.TranslateTo(0, -20, 100);
                await FloatMenuItem3.TranslateTo(0, 0, 200);
                FloatMenuItem3.IsVisible = false;
            }
            
        }

        private void FloatMenuItem1Tap_OnTapped(object sender, EventArgs e)
        {
            LabelStatus.Text = "Menu 1";
        }

        private void FloatMenuItem2Tap_OnTapped(object sender, EventArgs e)
        {
            LabelStatus.Text = "Menu 3";
        }

        private void FloatMenuItem3Tap_OnTapped(object sender, EventArgs e)
        {
            LabelStatus.Text = "Menu 3";
        }
    }
}
