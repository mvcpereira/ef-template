using BusinessLogic.Core;
using BusinessLogic.Core.EntityDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Template.WebAPI.Models;

namespace Template.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {

        private IProcessRequest _service;

        public UserController(IProcessRequest service)
        {
            this._service = service;
        }

        // GET api/values
        public IEnumerable<UserModel> Get()
        {
            var result = new List<UserModel>();
            _service.GetAllUsers().ForEach(x => result.Add(new UserModel() { name = x.Name, email = x.Email, idUser = x.IdUser, createdDate = x.CreatedDate, password = x.Password }));
            return result;
        }

        // GET api/values/5
        public UserModel Get(int id)
        {
            var userToEdit = _service.GetUserById(id);
            return new UserModel() { name = userToEdit.Name, email = userToEdit.Email, idUser = userToEdit.IdUser, createdDate = userToEdit.CreatedDate, password = userToEdit.Password };
        }

        // POST / Insert
        public void Post([FromBody] UserModel value)
        {
            var userToCreate = new User() { Name = value.name, Email = value.email, Password = value.password };
            _service.AddNewUser(userToCreate);  
        }

        // PUT / Update
        public void Put([FromBody] UserModel value)
        {
            try
            {
                var userToUpdate = new User() { Name = value.name, Email = value.email, IdUser = value.idUser.GetValueOrDefault(), Password = value.password };
                _service.UpdateUserData(userToUpdate);

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var xx = id;
        }
    }
}
