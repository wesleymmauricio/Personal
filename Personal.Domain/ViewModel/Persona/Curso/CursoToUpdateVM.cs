using System;
using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Persona.Curso
{
    class CursoToUpdateVM
    {
        [Key]
        [Required(ErrorMessage = "CursoId required")]
        public int CursoId { get; set; }

        public string NomeCurso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

    }
}
