using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Mashina
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Nomer { get; set; }

        public int Narxi { get; set; }

        public int  Yili { get; set; }

        public string Rangi { get; set; }

        public int MijozId { get; set; }

        public bool Bandmi { get; set; } = false;
    }
}
