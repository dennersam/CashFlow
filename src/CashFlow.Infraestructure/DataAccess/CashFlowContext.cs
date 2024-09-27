using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infraestructure.DataAccess;
public class CashFlowContext : DbContext
{
    public CashFlowContext(DbContextOptions options) : base(options){ }
    public DbSet<Expense> Expenses { get; set; }

}
