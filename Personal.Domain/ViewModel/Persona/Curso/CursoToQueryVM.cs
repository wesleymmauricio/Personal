using System;
using System.ComponentModel.DataAnnotations;

namespace Personal.Domain.ViewModel.Persona.Curso
{
    public class CursoToQueryVM
    {
        public int CursoId { get; set; }
        public string NomeCurso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public string LastUpdatedName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
