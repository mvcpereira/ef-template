using System;

namespace Template.WebAPI.Models
{
    public class UserModel
    {
        public int? idUser { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime? createdDate { get; set; }
    }
}