using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCinemaAppp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmEkle : ContentPage
    {
        public FilmEkle()
        {
            InitializeComponent();
            txtGösterimTarih.Text = DateTime.Now.ToString();
        }
        private void eklebutonu(object sender, EventArgs e)
        {
            Film myMovie = new Film();
            myMovie.MovieTitle = txtFilmAd.Text;
            myMovie.Seats = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            myMovie.Image = txtFilmResim.Text;
            myMovie.ShowingDate = DateTime.Now.AddDays(15);

            VeriTabani bag = new VeriTabani();
            int sonuc = bag.Ekle(myMovie);
            if (sonuc > 0)
            {
                DisplayAlert("ekleme durumu", "ekleme başarılı", "ok");

                CrossLocalNotifications.Current.Show("Film Başari ile eklendi",txtFilmAd.Text.ToString() +  " Adli film eklendi !  ", 1, DateTime.Now.AddSeconds(5));

            }
            else
            {
                DisplayAlert("ekleme durumu", "başarısız", "ok");
            }

        }
        private void filmListele(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new GirisPaneli());
        }
        private void filmGüncelle(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new GüncellemeSayfasi());
        }
    }
}