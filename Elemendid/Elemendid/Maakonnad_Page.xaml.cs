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
    public partial class Maakonnad_Page : ContentPage
    {
        TableView table;
        Picker picker_M, picker_P;
        StackLayout st1, st2;
        SwitchCell sc;
        TextCell lbl_info_rahv, lbl_info_pindala;
        TableSection rohkem_info;
        Image img_map, img_arms;
        public Maakonnad_Page()
        {

            lbl_info_rahv = new TextCell { Text = "" };
            lbl_info_pindala = new TextCell { Text = "" };

            sc = new SwitchCell { Text = "Näita veel" };
            sc.OnChanged += Sc_OnChanged;

            picker_M = new Picker
            {
                Title = "Maakonnad",
                BackgroundColor = Color.Lavender,
                WidthRequest = 150,
                ItemsSource = { "Harju maakond", "Hiiu maakond", "Ida-Viru maakond", "Jõgeva maakond", "Järva maakond", "Lääne maakond", "Lääne-Viru maakond", "Põlva maakond", "Pärnu maakond", "Rapla maakond", "Saare maakond", "Tartu maakond", "Valga maakond", "Viljandi maakond", "Võru maakond" }
            };
            picker_M.SelectedIndexChanged += Picker_M_SelectedIndexChanged;

            picker_P = new Picker
            {
                Title = "Pealinnad",
                BackgroundColor = Color.SpringGreen,
                WidthRequest = 150,
                ItemsSource = { "Tallinn", "Kärdla", "Jõhvi", "Jõgeva", "Paide", "Haapsalu", "Rakvere", "Põlva", "Pärnu", "Rapla", "Kuressaare", "Tartu", "Valga", "Viljandi", "Võru" }
            };
            picker_P.SelectedIndexChanged += Picker_P_SelectedIndexChanged;

            st1 = new StackLayout
            {
                Children = { picker_M, picker_P },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            img_map = new Image { };
            img_arms = new Image { };

            st2 = new StackLayout
            {
                Children = { img_map, img_arms },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center
            };

            rohkem_info = new TableSection();

            table = new TableView
            {
                Root = new TableRoot("Maakonnad ja nende pealinnad")
                {
                    new TableSection("Palun, vali andmed")
                    {
                        new ViewCell
                        {
                            View = st1
                        },
                        new ViewCell
                        {
                            View = st2
                        },
                        sc
                    },
                    rohkem_info
                }
            };
            Content = table;
        }
        private void imagesChange()
        {
            var value = (string)picker_M.SelectedItem;

            if (value == "Harju maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Tartu maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Ida-Viru maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Pärnu maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Lääne-Viru maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Viljandi maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Võru maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Rapla maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Saare maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Järva maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Jõgeva maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Valga maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Põlva maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "Lääne maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }
            else if (value == "	Hiiu maakond")
            {
                img_map.Source = ImageSource.FromFile("harjumaa.png");
                img_arms.Source = ImageSource.FromFile("harjumaa_vapp.png");
            }

        }
        private void info()
        {
            var value = (string)picker_M.SelectedItem;
           
            if (value == "Harju maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 605 029";
                lbl_info_pindala.Text = "Pindala - 4 327 km2";
            }
            else if (value == "Tartu maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 153 317";
                lbl_info_pindala.Text = "Pindala - 3 349 km2";
            }
            else if (value == "Ida-Viru maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 134 259";
                lbl_info_pindala.Text = "Pindala - 2 972 km2";
            }
            else if (value == "Pärnu maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 86 185";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Lääne-Viru maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 58 862";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Viljandi maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 46 161";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Võru maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 35 415";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Rapla maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 33 282";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Saare maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 33 083";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Järva maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 30 174";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Jõgeva maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 28 442";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Valga maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 28 204";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Põlva maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 24 647";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "Lääne maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 20 444";
                lbl_info_pindala.Text = "Pindala -  km2";
            }
            else if (value == "	Hiiu maakond")
            {
                lbl_info_rahv.Text = "Rahvaarv (2020) - 9 315";
                lbl_info_pindala.Text = "Pindala -  km2";
            }

        }

        private void Sc_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                info();
                rohkem_info.Add(lbl_info_rahv);
                rohkem_info.Add(lbl_info_pindala);
                sc.Text = "Peida";
            }
            else
            {
                rohkem_info.Remove(lbl_info_rahv);
                rohkem_info.Remove(lbl_info_pindala);
                sc.Text = "Näita veel";
            }
        }

        private void Picker_P_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker_P.SelectedIndex = picker_M.SelectedIndex;
        }

        private void Picker_M_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker_M.SelectedIndex = picker_P.SelectedIndex;
        }
    }
}