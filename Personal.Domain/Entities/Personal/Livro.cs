using System;

namespace Personal.Domain.Entities.Personal
{
    public class Livro
    {
        public int LivrosId { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Escritor { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

    }
}
