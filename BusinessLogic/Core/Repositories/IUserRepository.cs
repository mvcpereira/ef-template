using BusinessLogic.Core.EntityDataModel;
using System.Collections.Generic;

namespace BusinessLogic.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);

        IEnumerable<User> GetNewestUsers(int count);
    }
}
