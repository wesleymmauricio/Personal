using System;
using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Persona.Curso
{
    public class CursoToInsertVM
    {
        [Required(ErrorMessage = "NomeCurso required")]
        public string NomeCurso { get; set; }

        [Required(ErrorMessage = "DataInicio required")]
        public DateTime DataInicio { get; set; }

        public DateTime DataFinal { get; set; }

    }
}
