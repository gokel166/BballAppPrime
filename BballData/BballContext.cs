using System;
using Npgsql;
using Npgsql.EntityFrameworkCore;

namespace BballData
{
    public class BballContext
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public int  JerseyNo { get; set; }
        public string Position { get; set; }
        public double Height { get; set; }
        public DateTime DOB { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Drafted { get; set; }
    }
}
