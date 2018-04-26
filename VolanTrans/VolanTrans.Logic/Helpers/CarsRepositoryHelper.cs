using System;
using System.Collections.Generic;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public class CarsRepositoryHelper : ICarsRepositoryHelper
    {
        
        public bool AddCar(CarModel model)
        {
            return true;
        }

        public bool UpdateCar(CarModel model)
        {
            return true;
        }

        public bool DeleteCar(CarModel model)
        {
            return true;
        }

        public bool DeleteCar(int id)
        {
            return true;
        }

        public List<CarModel> GetCars()
        {
        
            return new List<CarModel> { new CarModel { Id = 1, Proprietar = "Test", AsigPers = DateTime.Now, ITP = DateTime.Now, RCA = DateTime.Now, Marca = "Test", Tip = "Test"},
                new CarModel
                {
                    Id = 2,
                    Proprietar = "Test",
                    AsigPers = DateTime.Now,
                    ITP = DateTime.Now,
                    RCA = DateTime.Now,
                    Marca = "Test",
                    Tip = "Test"
                }
            };

        }




    }
}