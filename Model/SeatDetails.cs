using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinamenCinema.Model
{
    public class SeatDetails
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public string SeatColumn { get; set; }
        public string SeatNo { get; set; }
        public bool IsBooked { get; set; }
    }
}
