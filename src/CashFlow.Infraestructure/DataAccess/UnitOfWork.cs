using CashFlow.Domain.Repositories;

namespace CashFlow.Infraestructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    private readonly CashFlowContext _dbContext;

    public UnitOfWork(CashFlowContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Commit() => _dbContext.SaveChanges();
    
}
