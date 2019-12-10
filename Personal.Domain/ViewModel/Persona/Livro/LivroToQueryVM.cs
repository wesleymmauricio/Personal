using System;

namespace Personal.Domain.ViewModel.Persona.Livro
{
    public class LivroToQueryVM
    {
        public int LivrosId { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Escritor { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public string LastUpdatedName { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
