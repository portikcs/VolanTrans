using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using VolanTrans.Logic.Helpers;

namespace VolanTrans.Logic.Model
{
    public class Cars : List<CarModel>
    {
        private readonly List<CarModel> _cars;
        private readonly ICarsRepositoryHelper _carsRepositoryHelper;

        public Cars()
        {
            _cars = new List<CarModel>();
            _carsRepositoryHelper = new CarsRepositoryHelper();

        }

        public new bool Add(CarModel model)
        {
            bool result = true;
            try
            {
                if (_cars.Any(w => w.Id == model.Id))
                {
                    _cars.Remove(_cars.FirstOrDefault(w => w.Id == model.Id));
                    result = _carsRepositoryHelper.UpdateCar(model);

                }
                else
                    result = _carsRepositoryHelper.AddCar(model);

                if (!result) return result;
                _cars.Add(model);
                return _cars.Any(w => w.Id == model.Id);
            }
            catch
            {
                //do not handle
                return false;
            }
        }

        public new bool Remove(CarModel model)
        {
            try
            {
                if (_carsRepositoryHelper.DeleteCar(model))
                {
                    _cars.Remove(model);
                    return true;
                }
                else return false;
            }
            catch
            {
                //do not handle
                return false;
            }

        }

        public bool Remove(Guid id)
        {
            try
            {
                if (_carsRepositoryHelper.DeleteCar(id))
                {
                    _cars.Remove(_cars.FirstOrDefault(w=> w.Id == id));
                    return true;
                }
                else return false;
            }
            catch
            {
                //do not handle
                return false;
            }

        }

        public void InitAdd(CarModel model) => _cars.Add(model);

        public List<CarModel> GetList() => _cars;
    }
}
