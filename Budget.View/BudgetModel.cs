using Budget.View.Models;
using System.Data.Entity;

namespace Budget.View
{
    public class BudgetModel : DbContext
    {
        public BudgetModel()
            : base("name=BudgetModel") { }

        public DbSet<Person> People { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Extraneous> Extraneouses { get; set; }
    }
}