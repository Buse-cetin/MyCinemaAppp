using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using MyCinemaAppp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(VeriTabaniAyari))]
namespace MyCinemaAppp.Droid
{

    public class VeriTabaniAyari:MyConnection
    {
        public static string VeriTabaniAdi { get; set; } = "örnek.db3";
        public SQLiteConnection GetConnection()
        {
            string yol = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var baglihal = System.IO.Path.Combine(yol, VeriTabaniAdi);
            var gidecek = new SQLiteConnection(baglihal);
            return gidecek;
        }
    }
}