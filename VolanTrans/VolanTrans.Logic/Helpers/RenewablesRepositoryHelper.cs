using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public class RenewablesRepositoryHelper : IRenewablesRepositoryHelper
    {

        private string _path = ConfigurationManager.AppSettings["WorkFolder"]+@"\Renewables\";

        public bool AddRenewModel(RenewableModel model)
        {
            try
            {
                if (!Directory.Exists(_path)) Directory.CreateDirectory(_path);

                using(StreamWriter sw = new StreamWriter(_path+model.Id+".json"))
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

        public bool UpdateRenewModel(RenewableModel model)
        {
            try
            {
                return DeleteRenewModel(model) && AddRenewModel(model);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteRenewModel(RenewableModel model)
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

        public bool DeleteRenewModel(Guid id)
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

        public List<RenewableModel> GetRenewables()
        {
           List<RenewableModel> result = new List<RenewableModel>();

            if (!Directory.Exists(_path)) Directory.CreateDirectory(_path);

            foreach (var file in Directory.EnumerateFiles(_path, "*.json"))
            {

                string item = File.ReadAllText(file);
                var renew = JsonConvert.DeserializeObject<RenewableModel>(item);
                result.Add(renew);

            }

           return result;
           
        }
         
    }
}