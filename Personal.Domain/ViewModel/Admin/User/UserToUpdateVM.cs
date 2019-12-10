using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Admin.User
{
    public class UserToUpdateVM
    {
        [Key]
        [Required(ErrorMessage = "UserId required!!")]
        public int UserId { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}
