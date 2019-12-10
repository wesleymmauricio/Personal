using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Persona.Livro
{
    public class LivroToUpdateVM
    {
        [Key]
        [Required(ErrorMessage = "LivroId required")]
        public int LivroId { get; set; }

        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Escritor { get; set; }
    }
}
