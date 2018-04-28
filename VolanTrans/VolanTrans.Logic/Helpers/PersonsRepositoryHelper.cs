using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public class PersonsRepositoryHelper : IPersonsRepositoryHelper
    {

        private string _path = ConfigurationManager.AppSettings["WorkFolder"] + @"\Persons\";
        public bool AddPerson(PersonModel model)
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

        public bool UpdatePerson(PersonModel model)
        {
            try
            {
                return DeletePerson(model) && AddPerson(model);
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePerson(PersonModel model)
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

        public bool DeletePerson(Guid id)
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

        public List<PersonModel> GetPersons()
        {

            List<PersonModel> result = new List<PersonModel>();

            if (!Directory.Exists(_path)) Directory.CreateDirectory(_path);

            foreach (var file in Directory.EnumerateFiles(_path, "*.json"))
            {

                string item = File.ReadAllText(file);
                var person = JsonConvert.DeserializeObject<PersonModel>(item);
                result.Add(person);

            }

            return result;

        }
         
    }
}