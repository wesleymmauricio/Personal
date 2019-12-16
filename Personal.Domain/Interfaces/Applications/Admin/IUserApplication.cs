using Personal.Domain.ViewModel.Admin.User;
using System.Collections.Generic;

namespace Personal.Domain.Interfaces.Applications.Admin
{
    public interface IUserApplication
    {
        UserToQueryVM GetById(int userId);
        IEnumerable<UserToQueryVM> GetAll();
        int Add(UserToInsertVM user);
        void Update(UserToUpdateVM user);
        void Delete(int userId);
    }
}
