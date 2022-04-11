using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Song_Page : ContentPage
    {
        DatePicker date;
        Label lbl;
        StackLayout st;
        String link;
        WebView veeb;

        public Song_Page()
        {
            
            date = new DatePicker
            {
                Format = "YYYY",
                MaximumDate = new DateTime(1974, 1, 1),
                MinimumDate = new DateTime(2020, 31, 31)
            };
            date.DateSelected += Date_DateSelected;

            lbl = new Label
            {
                Text = "Palun, vali aeg ja ma näitan sulle populaarsem aasta laulu! :)"
            };

            st = new StackLayout
            {
                Children = {date, lbl},
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.Center
            };


            Content = st;

        }

        private void Date_DateSelected(object sender, DateChangedEventArgs e)
        {
            UuendaVeeb();

            var y = e.NewDate.Year;
            if (y==1974)
            {
                lbl.Text = "Barbra Streisand - The Way We Were";
                link = "https://www.youtube.com/watch?v=ifWOSnoCS0M";
            }
            else if (y == 1975)
            {
                lbl.Text = "CAPTAIN & TENNILLE - love will keep us together ";
                link = "https://www.youtube.com/watch?v=_QNEf9oGw8o";
            }
            else if (y == 1976)
            {
                lbl.Text = "Wings - Silly Love Songs ";
                link = "https://www.youtube.com/watch?v=ap87QgZKTNw";
            }
            else if (y == 1977)
            {
                lbl.Text = "Rod Stewart – Tonight's The Night";
                link = "https://www.youtube.com/watch?v=IZr6AE-u2UM";
            }
            else if (y == 1978)
            {
                lbl.Text = "Andy Gibb - Shadow dancing";
                link = "https://www.youtube.com/watch?v=PZxA3FVUwvk";
            }
            else if (y == 1979)
            {
                lbl.Text = "The Knack - My Sharona";
                link = "https://www.youtube.com/watch?v=BR2JtsVumFA";
            }
            else if (y == 1980)
            {
                lbl.Text = "Blondie - Call Me";
                link = "https://www.youtube.com/watch?v=StKVS0eI85I";
            }
            else if (y == 1981)
            {
                lbl.Text = "Kim Carnes - Bette Davis Eyes";
                link = "https://www.youtube.com/watch?v=EPOIS5taqA8";
            }
            else if (y == 1982)
            {
                lbl.Text = "Olivia Newton-John - Physical";
                link = "https://www.youtube.com/watch?v=vWz9VN40nCA";
            }
            else if (y == 1983)
            {
                lbl.Text = "The Police - Every Breath You Take";
                link = "https://www.youtube.com/watch?v=OMOGaugKpzs";
            }
            else if (y == 1984)
            {
                lbl.Text = "Prince - When Doves Cry";
                link = "https://www.youtube.com/watch?v=UG3VcCAlUgE";
            }
            else if (y == 1985)
            {
                lbl.Text = "George Michael - Careless Whisper";
                link = "https://www.youtube.com/watch?v=izGwDsrQ1eQ";
            }
            else if (y == 1986)
            {
                lbl.Text = "lionel richie - say you say me ";
                link = "https://www.youtube.com/watch?v=we0mk_J0zyc";
            }
            else if (y == 1987)
            {
                lbl.Text = "The Bangles - Walk Like an Egyptian";
                link = "https://www.youtube.com/watch?v=Cv6tuzHUuuk";
            }
            else if (y == 1988)
            {
                lbl.Text = "George Michael - Faith";
                link = "https://www.youtube.com/watch?v=6Cs3Pvmmv0E";
            }
            else if (y == 1989)
            {
                lbl.Text = "Chicago - Look Away";
                link = "https://www.youtube.com/watch?v=2uKLTtVqQpE";
            }
            else if (y == 1990)
            {
                lbl.Text = "Wilson Phillips - Hold On";
                link = "https://www.youtube.com/watch?v=uIbXvaE39wM";
            }
            else if (y == 1991)
            {
                lbl.Text = "Bryan Adams - (Everything I Do) I Do It for You";
                link = "https://www.youtube.com/watch?v=Y0pdQU87dc8";
            }
            else if (y == 1992)
            {
                lbl.Text = "Boyz II Men - End Of The Road";
                link = "https://www.youtube.com/watch?v=zDKO6XYXioc";
            }
            else if (y == 1993)
            {
                lbl.Text = "Whitney Houston - I Will Always Love You";
                link = "https://www.youtube.com/watch?v=3JWTaaS7LdU";
            }
            else if (y == 1994)
            {
                lbl.Text = "Ace of Base - The Sign";
                link = "https://www.youtube.com/watch?v=iqu132vTl5Y";
            }
            else if (y == 1995)
            {
                lbl.Text = "Coolio - Gangsta's Paradise";
                link = "https://www.youtube.com/watch?v=fPO76Jlnz6c";
            }
            else if (y == 1996)
            {
                lbl.Text = "Los Del Rio - Macarena";
                link = "https://www.youtube.com/watch?v=zWaymcVmJ-A";
            }
            else if (y == 1997)
            {
                lbl.Text = "Jewel - Foolish Games ";
                link = "https://www.youtube.com/watch?v=UNoouLa7uxA";
            }
            else if (y == 1998)
            {
                lbl.Text = "Next - Too Close";
                link = "https://www.youtube.com/watch?v=kwEZRPkAAu8";
            }
            else if (y == 1999)
            {
                lbl.Text = "Cher - Believe";
                link = "https://www.youtube.com/watch?v=nZXRV4MezEw";
            }
            else if (y == 2000)
            {
                lbl.Text = "Faith Hill - Breathe ";
                link = "https://www.youtube.com/watch?v=yCmsZUN4r_s";
            }
            else if (y == 2001)
            {
                lbl.Text = "Lifehouse - Hanging By A Moment";
                link = "https://www.youtube.com/watch?v=tPnK39ax_AM";
            }
            else if (y == 2002)
            {
                lbl.Text = "Nickelback - How You Remind Me";
                link = "https://www.youtube.com/watch?v=1cQh1ccqu8M";
            }
            else if (y == 2003)
            {
                lbl.Text = "50 Cent - In Da Club";
                link = "https://www.youtube.com/watch?v=5qm8PH4xAss";
            }
            else if (y == 2004)
            {
                lbl.Text = "Usher - Yeah!";
                link = "https://www.youtube.com/watch?v=GxBSyx85Kp8";
            }
            else if (y == 2005)
            {
                lbl.Text = "Mariah Carey - We Belong Together";
                link = "https://www.youtube.com/watch?v=0habxsuXW4g";
            }
            else if (y == 2006)
            {
                lbl.Text = "Daniel Powter - Bad Day";
                link = "https://www.youtube.com/watch?v=gH476CxJxfg";
            }
            else if (y == 2007)
            {
                lbl.Text = "Beyoncé - Irreplaceable";
                link = "https://www.youtube.com/watch?v=2EwViQxSJJQ";
            }
            else if (y == 2008)
            {
                lbl.Text = "Flo Rida - Low";
                link = "https://www.youtube.com/watch?v=U2waT9TxPU0";
            }
            else if (y == 2009)
            {
                lbl.Text = "The Black Eyed Peas - Boom Boom Pow";
                link = "https://www.youtube.com/watch?v=4m48GqaOz90";
            }
            else if (y == 2010)
            {
                lbl.Text = "Ke$ha - TiK ToK";
                link = "https://www.youtube.com/watch?v=iP6XpLQM2Cs";
            }
            else if (y == 2011)
            {
                lbl.Text = "Adele - Rolling in the Deep";
                link = "https://www.youtube.com/watch?v=rYEDA3JcQqw";
            }
            else if (y == 2012)
            {
                lbl.Text = "Gotye featuring Kimbra - Somebody That I Used to Know";
                link = "https://www.youtube.com/watch?v=8UVNT4wvIGY";
            }
            else if (y == 2013)
            {
                lbl.Text = "MACKLEMORE & RYAN LEWIS - THRIFT SHOP";
                link = "https://www.youtube.com/watch?v=QK8mJJJvaes";
            }
            else if (y == 2014)
            {
                lbl.Text = "Pharrell Williams - Happy";
                link = "https://www.youtube.com/watch?v=ZbZSe6N_BXs";
            }
            else if (y == 2015)
            {
                lbl.Text = "Mark Ronson - Uptown Funk";
                link = "https://www.youtube.com/watch?v=OPf0YbXqDm0";
            }
            else if (y == 2016)
            {
                lbl.Text = "Justin Bieber - Love Yourself";
                link = "https://www.youtube.com/watch?v=oyEuk8j8imI";
            }
            else if (y == 2017)
            {
                lbl.Text = "Ed Sheeran - Shape of You";
                link = "https://www.youtube.com/watch?v=JGwWNGJdvx8";
            }
            else if (y == 2018)
            {
                lbl.Text = "Drake - God's Plan";
                link = "https://www.youtube.com/watch?v=xpVfcZ0ZcFM";
            }
            else if (y == 2019)
            {
                lbl.Text = "Lil Nas X - Old Town Road";
                link = "https://www.youtube.com/watch?v=w2Ov5jzm3j8";
            }
            else if (y == 2020)
            {
                lbl.Text = "The Weeknd - Blinding Lights";
                link = "https://www.youtube.com/watch?v=4NRXx6U8ABQ";
            }

            UuendaVeeb();

        }
        private void UuendaVeeb()
        {
            if (veeb != null)
            {
                st.Children.Remove(veeb);
            }
            veeb = new WebView
            {
                Source = new UrlWebViewSource { Url = link },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            st.Children.Add(veeb);
        }
    }
}