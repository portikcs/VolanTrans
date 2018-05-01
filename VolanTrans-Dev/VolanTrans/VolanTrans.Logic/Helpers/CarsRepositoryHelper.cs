using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public class CarsRepositoryHelper : ICarsRepositoryHelper
    {
        private string _path = ConfigurationManager.AppSettings["WorkFolder"] + @"\Cars\";
        public bool AddCar(CarModel model)
        {
            try
            {
                if (!Directory.Exists(_path)) Directory.CreateDirectory(_path);

                using(StreamWriter sw = new StreamWriter(_path + model.Id + ".json"))
                {
                    string sm = JsonConvert.SerializeObject(model);
                    sw.Write(sm);
                    sw.Flush();
                    sw.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCar(CarModel model)
        {
            try
            {
                return DeleteCar(model) && AddCar(model);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCar(CarModel model)
        {
            try
            {
                File.Delete(_path + model.Id + ".json");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCar(Guid id)
        {
            try
            {
                File.Delete(_path + id + ".json");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<CarModel> GetCars()
        {

            List<CarModel> result = new List<CarModel>();

            if (!Directory.Exists(_path)) Directory.CreateDirectory(_path);

            foreach (var file in Directory.EnumerateFiles(_path, "*.json"))
            {

                string item = File.ReadAllText(file);
                var car = JsonConvert.DeserializeObject<CarModel>(item);
                result.Add(car);

            }

            return result;

        }




    }
}