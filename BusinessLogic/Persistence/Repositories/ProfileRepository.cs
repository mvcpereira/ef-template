using BusinessLogic.Core.EntityDataModel;
using BusinessLogic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Persistence.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(TemplateContext context) : base(context)
        {
        }

        public TemplateContext TemplateContext
        {
            get { return Context as TemplateContext; }
        }
    }
}
