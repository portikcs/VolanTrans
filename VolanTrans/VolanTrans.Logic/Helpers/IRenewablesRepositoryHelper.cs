using System;
using System.Collections.Generic;
using VolanTrans.Logic.Model;

namespace VolanTrans.Logic.Helpers
{
    public interface IRenewablesRepositoryHelper
    {
        bool AddRenewModel(RenewableModel model);
        bool UpdateRenewModel(RenewableModel model);
        bool DeleteRenewModel(RenewableModel model);
        bool DeleteRenewModel(Guid id);
        List<RenewableModel> GetRenewables();
    }
}