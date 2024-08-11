using Application.Interfaces;
using Infrastructure.Context;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            await _databaseContext.SaveChangesAsync(cancellationToken);
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
