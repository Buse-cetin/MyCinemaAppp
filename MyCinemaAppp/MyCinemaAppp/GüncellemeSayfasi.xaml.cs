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
    public partial class GüncellemeSayfasi : ContentPage
    {
        public GüncellemeSayfasi()
        {
            InitializeComponent();
        }
        VeriTabani baglanti = new VeriTabani();
        Film ornekFilm = new Film();
        private void BulYap(object sender, EventArgs e)
        {
            string arananfilm =txtFilmAd.Text;


            ornekFilm = baglanti.Bulma(arananfilm);
            txtFilmAd.Text = ornekFilm.MovieTitle;
            txtFilmResim.Text = ornekFilm.Image;
            txtGösterimTarih.Text = ornekFilm.ShowingDate.ToString();
            txtBosKoltuk.Text = ornekFilm.Seats.ToList().ToString();
        }
        private void GüncelleYap(object sender, EventArgs e)
        {
            txtFilmAd.Text = ornekFilm.MovieTitle;
            txtFilmResim.Text = ornekFilm.Image;
            txtGösterimTarih.Text = ornekFilm.ShowingDate.ToString();
            txtBosKoltuk.Text = ornekFilm.Seats.ToList().ToString();
            int sonuc = baglanti.Guncelleme(ornekFilm);
            if (sonuc > 0)
            {
                DisplayAlert(" Güncelleme durmu ", " başarılı ", " ok ");
            }
            else
            {
                DisplayAlert(" Güncelleme durmu ", " başarısız ", " ok ");
            }
        }
        private void SilYap(object sender, EventArgs e)
        {
            int secilen =Convert.ToInt32(txtFilmId.Text);
            int sonuc = baglanti.Sil(secilen);
            if (sonuc > 0)
            {
                DisplayAlert("Silme", "Silme başarılı", "cıkıs");
            }
            else
            {
                DisplayAlert("Silme", "Silme başarısız", "cıkıs");
            }



        }
    }
}