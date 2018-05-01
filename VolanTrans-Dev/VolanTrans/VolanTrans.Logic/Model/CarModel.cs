using System;
using System.Collections.Generic;
using System.Linq;

namespace VolanTrans.Logic.Model
{
    public class CarModel
    {
        public string LicencePlate { get; set; }
        public string ModelAndMake { get; set; }
        public string Year { get; set; }
        public Guid Id { get; set; }
    }
}
