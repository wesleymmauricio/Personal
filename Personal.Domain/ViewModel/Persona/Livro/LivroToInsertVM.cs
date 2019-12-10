using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Persona.Livro
{
    public class LivroToInsertVM
    {
        [Required(ErrorMessage = "Titulo required")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Editora required")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Escritor")]
        public string Escritor { get; set; }
    }
}
