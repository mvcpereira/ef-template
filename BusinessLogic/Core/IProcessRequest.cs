using BusinessLogic.Core.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Core
{
    public interface IProcessRequest
    {
        List<User> GetAllUsers();
        User GetUserById(int id);

        void AddNewUser(User user);

        void UpdateUserData(User user);

    }
}
