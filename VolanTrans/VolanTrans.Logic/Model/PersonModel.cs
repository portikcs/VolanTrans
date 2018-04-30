using System;

namespace VolanTrans.Logic.Model
{
    public class PersonModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
        public Guid Id { get; set; }
    }
}