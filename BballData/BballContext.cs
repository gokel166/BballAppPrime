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
        public string TeamLoc { get; set; }
    }
}
