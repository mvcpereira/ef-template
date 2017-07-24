using BusinessLogic.Core.Repositories;
using System;

namespace BusinessLogic.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IProfileRepository Profiles { get; }

        int SaveChanges();
    }
}
