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
    public partial class GirisPaneli : ContentPage
    {
        VeriTabani baglanti = new VeriTabani();
        public GirisPaneli()
        {
            InitializeComponent();

            Tickets = GetTickets();
            this.BindingContext = this;


        }
        public ObservableCollection<Film> Tickets { get; set; }
        public Film SelectedTicket { get; set; }

        private ObservableCollection<Film> GetTickets()
        {
            List<Film> gelenliste = new List<Film>();
            gelenliste = baglanti.tumliste().ToList();
            ObservableCollection<Film> collection = new ObservableCollection<Film>(gelenliste);
            return collection;
        }

        private void TicketSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                this.Navigation.PushModalAsync(new KoltukSayfasi(SelectedTicket));
            }
        }

        public class Ticket
        {
            public string MovieTitle { get; set; }
            public DateTime ShowingDate { get; set; }
            public string Image { get; set; }
            public int[] Seats { get; set; }
        }
    }
}
