using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SleepApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.firstSlider.ValueChanged += (sender, args) =>
            {
                var slidervalue = Math.Floor(args.NewValue);
                this.sliderLable.Text = "Slider Value" + slidervalue;
            };

            var boxTapHandler = new TapGestureRecognizer();
            boxTapHandler.Tapped += ChangeColor;
            this.viewBox.GestureRecognizers.Add(boxTapHandler);
        }

        private void ChangeColor(object sender, EventArgs args)
        {
            if (this.viewBox.Color == Color.Red)
            {
                this.viewBox.Color = Color.Black;
            }
            else
            {
                this.viewBox.Color = Color.Red;

            }
        }
    }
}
