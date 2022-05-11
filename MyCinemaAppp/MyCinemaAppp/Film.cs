using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCinemaAppp
{
    public class Film
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ShowingDate { get; set; }
        public string Image { get; set; }
        public byte[] Seats { get; set; }
    }
}
