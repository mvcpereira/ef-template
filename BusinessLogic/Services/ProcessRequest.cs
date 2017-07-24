using BusinessLogic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Core.EntityDataModel;
using BusinessLogic.Persistence;

namespace BusinessLogic.Services
{
    public class ProcessRequest : IProcessRequest
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public ProcessRequest(UnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public List<User> GetAllUsers()
        {
            return _unitOfWork.Users.GetAll().ToList();
        }

        public void AddNewUser(User user)
        {
            user.CreatedDate = DateTime.Now; 
            _unitOfWork.Users.Add(user);
            _unitOfWork.SaveChanges();
        }



        public User GetUserById(int id)
        {
            return _unitOfWork.Users.Get(id);
        }

        public void UpdateUserData(User user)
        {
            var currentUser = _unitOfWork.Users.Get(user.IdUser);
            currentUser.Name = user.Name;
            currentUser.Email = user.Email;
            currentUser.Password = user.Password;
            _unitOfWork.SaveChanges();
        }
    }
}
