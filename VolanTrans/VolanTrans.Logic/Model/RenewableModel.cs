using System;

namespace VolanTrans.Logic.Model
{
    public class RenewableModel
    {
        public string Name { get; set; }
        public string AppliesTo { get; set; }
        public string  Remarks { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid Id { get; set; }
    }
}