using Personal.Domain.ViewModel.Persona.Livro;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Applications.Personal
{
    public interface ILivroApplication
    {
        LivroToQueryVM GetById(int livroId);
        IEnumerable<LivroToQueryVM> GetAll();
        int Add(LivroToInsertVM livro);
        void Update(LivroToUpdateVM livro);
        void Delete(int livroId);
    }
}
