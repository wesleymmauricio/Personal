using System;

namespace Personal.Domain.ViewModel.Admin.User
{
    public class UserToQueryVM
    {
        public int UserId { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public string LastUpdatedName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
