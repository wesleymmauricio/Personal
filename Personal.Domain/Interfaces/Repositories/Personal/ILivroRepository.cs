using Personal.Domain.ViewModel.Persona.Livro;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Repositories.Personal
{
    public interface ILivroRepository
    {
        LivroToQueryVM GetById(int livroId);
        IEnumerable<LivroToQueryVM> GetAll();
        int Add(LivroToInsertVM livro);
        void Update(LivroToUpdateVM livroId);
        void Delete(int livroId);
    }
}
