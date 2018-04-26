using System;
using System.Collections.Generic;
using System.Linq;

namespace VolanTrans.Logic.Model
{
    public class CarModel
    {
        public string Proprietar { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Tip { get; set; }
        public string NrdeImatriculare { get; set; }
        public string NumarSasiu { get; set; }
        public DateTime ITP { get; set; }
        public DateTime RCA { get; set; }
        public DateTime AsigPers { get; set; }
        public int Id { get; set; }
    }
}
