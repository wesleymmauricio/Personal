using Personal.Domain.Interfaces.Applications.Personal;
using Personal.Domain.Interfaces.Repositories.Personal;
using Personal.Domain.ViewModel.Persona.Livro;
using System;
using System.Collections.Generic;

namespace Personal.Application.Application.Livro
{
    public class LivroApplication : ILivroApplication
    {
        private readonly ILivroRepository _repo;

        public LivroApplication(ILivroRepository repo)
        {
            _repo = repo;
        }

        public int Add(Domain.Entities.Personal.Livro livro)
        {
            try
            {
                if (livro == null)
                    throw new ArgumentException("Livro invalido");

                var livroId = _repo.Add(livro);
                return livroId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int livroId)
        {
            try
            {
                if (livroId == 0)
                    throw new ArgumentException("LivroId invalido");

                _repo.Delete(livroId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<LivroToQueryVM> GetAll()
        {
            try
            {
                var livros = _repo.GetAll();
                return livros;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public LivroToQueryVM GetById(int livroId)
        {
            try
            {
                if (livroId == 0)
                    throw new ArgumentException("LivroId invalido");

                var livro = _repo.GetById(livroId);
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Domain.Entities.Personal.Livro livro)
        {
            try
            {
                if (livro == null)
                    throw new ArgumentException("Livro invalido");

                _repo.Update(livro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
