using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using VolanTrans.Logic.Helpers;

namespace VolanTrans.Logic.Model
{
    public class Renewables : List<RenewableModel>
    {
        private readonly List<RenewableModel> _renewableModels;
        private readonly IRenewablesRepositoryHelper _renewablesRepositoryHelper;

        public Renewables()
        {
            _renewableModels = new List<RenewableModel>();
            _renewablesRepositoryHelper = new RenewablesRepositoryHelper();

        }

        public new bool Add(RenewableModel model)
        {
            bool result = true;
            try
            {
                if (_renewableModels.Any(w => w.Id == model.Id))
                {
                    _renewableModels.Remove(_renewableModels.FirstOrDefault(w => w.Id == model.Id));
                    result = _renewablesRepositoryHelper.UpdateRenewModel(model);

                }
                else
                    result = _renewablesRepositoryHelper.AddRenewModel(model);

                if (!result) return result;
                _renewableModels.Add(model);
                return _renewableModels.Any(w => w.Id == model.Id);
            }
            catch
            {
                //do not handle
                return false;
            }
        }

        public new bool Remove(RenewableModel model)
        {
            try
            {
                if (_renewablesRepositoryHelper.DeleteRenewModel(model))
                {
                    _renewableModels.Remove(model);
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
                if (_renewablesRepositoryHelper.DeleteRenewModel(id))
                {
                    _renewableModels.Remove(_renewableModels.FirstOrDefault(w=> w.Id.Equals(id)));
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

        public void InitAdd(RenewableModel model) => _renewableModels.Add(model);

        public List<RenewableModel> GetList() => _renewableModels;
    }
}
