using System;
using System.Collections.Generic;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public interface IPersonsRepositoryHelper
    {
        bool AddPerson(PersonModel model);
        bool UpdatePerson(PersonModel model);
        bool DeletePerson(PersonModel model);
        bool DeletePerson(Guid id);
        List<PersonModel> GetPersons();
    }
}