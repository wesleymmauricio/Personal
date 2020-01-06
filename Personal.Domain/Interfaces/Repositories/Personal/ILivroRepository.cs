using Personal.Domain.Entities.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Repositories.Personal
{
    public interface ILivroRepository
    {
        LivroToQueryVM GetById(int livroId);
        IEnumerable<LivroToQueryVM> GetAll();
        int Add(Livro livro);
        void Update(Livro livro);
        void Delete(int livroId);
    }
}
