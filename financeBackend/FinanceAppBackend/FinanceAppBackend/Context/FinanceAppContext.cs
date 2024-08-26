using FinanceAppBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceAppBackend.Context;

public class FinanceAppContext : DbContext
{
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options)
    {
    }
    
    public DbSet<Account> Accounts { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Transaction> Transactions { get; set; } 

    public DbSet<User> Users { get; set; }
    
}