using Personal.Domain.Entities.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Repositories.Personal
{
    public interface ICursoRepository
    {
        Livro GetById(int livroId);
        IEnumerable<Livro> GetAll();
        int Add(LivroToInsertVM livro);
        void Update(LivroToUpdateVM livro);
        void Delete(int livroId);
    }
}
