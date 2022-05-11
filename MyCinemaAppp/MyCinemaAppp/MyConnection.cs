using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace MyCinemaAppp
{
    public interface MyConnection
    {
        SQLiteConnection GetConnection();
    }
}
