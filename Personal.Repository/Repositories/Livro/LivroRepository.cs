using Personal.Domain.Interfaces.Repositories.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System.Collections.Generic;

namespace Personal.Repository.Repositories.Livro
{
    public class LivroRepository : ILivroRepository
    {
        public int Add(LivroToInsertVM livro)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int livroId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LivroToQueryVM> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public LivroToQueryVM GetById(int livroId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(LivroToUpdateVM livroId)
        {
            throw new System.NotImplementedException();
        }
    }
}
