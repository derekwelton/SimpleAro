using SimpleAro.Domain.Core.Entities;

namespace SimpleAro.Domain.Modules.ExpenseTracker.Entities
{
    public class ExpenseAccountEntity : AuditableEntity
    {
        public int ExpenseAccount_Id { get; set; }
        public string AccountName { get; set; }
        public AccountType Type { get; set; }
    }
}