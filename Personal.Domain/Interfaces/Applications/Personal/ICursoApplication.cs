using Personal.Domain.ViewModel.Persona.Curso;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Applications.Personal
{
    public interface ICursoApplication
    {
        CursoToQueryVM GetById(int cursoId);
        IEnumerable<CursoToQueryVM> GetAll();
        int Add(CursoToInsertVM curso);
        void Update(CursoToUpdateVM curso);
        void Delete(int livroId);
    }
}
