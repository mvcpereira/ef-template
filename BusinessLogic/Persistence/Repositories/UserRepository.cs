using BusinessLogic.Core.EntityDataModel;
using BusinessLogic.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TemplateContext context) : base(context)
        {
        }

        public TemplateContext TemplateContext
        {
            get { return Context as TemplateContext; }
        }

        public User GetByEmail(string email)
        {
            return TemplateContext.Users.FirstOrDefault(s => s.Email.Equals(email));
        }

        public IEnumerable<User> GetNewestUsers(int count)
        {
            return TemplateContext.Users.OrderByDescending(c => c.CreatedDate).Take(count).ToList();
        }
    }
}
