using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace MyCinemaAppp
{
    public class VeriTabani
    {
        SQLiteConnection baglanti;
        public VeriTabani()
        {
            baglanti = DependencyService.Get<MyConnection>().GetConnection();
            baglanti.CreateTable<Film>();

        }
        public int Ekle(Film ornek)
        {
            return baglanti.Insert(ornek);
        }
        public IEnumerable<Film> tumliste()
        {
            return baglanti.Table<Film>();
        }

        public Film Bulma(string gelenId)
        {
            return baglanti.Table<Film>().Where(x => x.MovieTitle == gelenId).FirstOrDefault();
        }
        public int Guncelleme(Film ornekkisi)
        {
            return baglanti.Update(ornekkisi);
        }
        public int Sil(int id)
        {
            return baglanti.Delete<Film>(id);
        }
    }
}
