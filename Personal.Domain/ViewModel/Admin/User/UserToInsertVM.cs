using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Admin.User
{
    public class UserToInsertVM
    {
        [Required(ErrorMessage = "PrimeiroNome required")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "UltimoNome required")]
        public string UltimoNome { get; set; }
    }
}
