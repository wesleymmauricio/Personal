using System;

namespace Personal.Domain.Entities.Personal
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string NomeCurso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
