using System;
using System.Collections.Generic;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public interface ICarsRepositoryHelper
    {
        bool AddCar(CarModel model);
        bool UpdateCar(CarModel model);
        bool DeleteCar(CarModel model);

        bool DeleteCar(Guid id);

        List<CarModel> GetCars();
    }
}