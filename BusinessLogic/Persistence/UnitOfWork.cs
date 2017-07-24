using BusinessLogic.Core;
using BusinessLogic.Core.EntityDataModel;
using BusinessLogic.Core.Repositories;
using BusinessLogic.Persistence.Repositories;
using System;

namespace BusinessLogic.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TemplateContext _context;

        public UnitOfWork(TemplateContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Profiles = new ProfileRepository(_context);
        }
        public IUserRepository Users { get; private set; }

        public IProfileRepository Profiles { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
