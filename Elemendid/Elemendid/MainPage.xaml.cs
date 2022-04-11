using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        Button laul_btn, maakond_btn;
        public MainPage()
        {
            laul_btn = new Button
            {
                Text = "Laulud",
                BackgroundColor = Color.Orange,
                TextColor = Color.White,
                CornerRadius = 90
            };
            laul_btn.Clicked += ButtonClicked;

            maakond_btn = new Button
            {
                Text = "Maakonnad",
                BackgroundColor = Color.Red,
                TextColor = Color.White,
                CornerRadius = 90
            };
            maakond_btn.Clicked += ButtonClicked;

            StackLayout st = new StackLayout
            {
                Children = {maakond_btn, laul_btn},
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center
            };

            Content = st;
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {
            if(sender == laul_btn)
            {
                await Navigation.PushAsync(new Song_Page());
            }
            else if(sender == maakond_btn)
            {
                await Navigation.PushAsync(new Maakonnad_Page());
            }
           
        }
    }
}
