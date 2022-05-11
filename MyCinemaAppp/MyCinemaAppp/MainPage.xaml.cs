using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCinemaAppp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void giriss(object sender, EventArgs e)
        {
            string ad = A.Text;
            int sifre = Convert.ToInt32(S.Text);
            if (ad == "Admin" || sifre == 1234)
            {
                this.Navigation.PushModalAsync(new FilmEkle());
            }
            else
            {
                DisplayAlert("hata", "giriş başarısız", "cıkıs");
            }
        }
        private void kullanicigiriss(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GirisPaneli());
        }
    }
}
