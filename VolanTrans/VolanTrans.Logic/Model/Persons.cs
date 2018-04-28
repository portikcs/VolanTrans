using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using VolanTrans.Logic.Helpers;

namespace VolanTrans.Logic.Model
{
    public class Persons : List<PersonModel>
    {
        private readonly List<PersonModel> _personModels;
        private readonly IPersonsRepositoryHelper _personsRepositoryHelper;

        public Persons()
        {
            _personModels = new List<PersonModel>();
            _personsRepositoryHelper = new PersonsRepositoryHelper();

        }

        public new bool Add(PersonModel model)
        {
            bool result = true;
            try
            {
                if (_personModels.Any(w => w.Id == model.Id))
                {
                    _personModels.Remove(_personModels.FirstOrDefault(w => w.Id == model.Id));
                    result = _personsRepositoryHelper.UpdatePerson(model);

                }
                else
                    result = _personsRepositoryHelper.AddPerson(model);

                if (!result) return result;
                _personModels.Add(model);
                return _personModels.Any(w => w.Id == model.Id);
            }
            catch
            {
                //do not handle
                return false;
            }
        }

        public new bool Remove(PersonModel model)
        {
            try
            {
                if (_personsRepositoryHelper.DeletePerson(model))
                {
                    _personModels.Remove(model);
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
                if (_personsRepositoryHelper.DeletePerson(id))
                {
                    _personModels.Remove(_personModels.FirstOrDefault(w=> w.Id == id));
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

        public void InitAdd(PersonModel model) => _personModels.Add(model);

        public List<PersonModel> GetList() => _personModels;
    }
}
