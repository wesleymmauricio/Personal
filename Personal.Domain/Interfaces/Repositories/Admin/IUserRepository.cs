using Personal.Domain.ViewModel.Admin.User;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Repositories.Admin
{
    public interface IUserRepository
    {
        UserToQueryVM GetById(int livroId);
        IEnumerable<UserToQueryVM> GetAll();
        int Add(UserToInsertVM user);
        void Update(UserToUpdateVM user);
        void Delete(int livroId);
    }
}
