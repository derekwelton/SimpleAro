using SimpleAro.Domain.Core.Entities;

namespace SimpleAro.Domain.Modules.ExpenseTracker.Entities
{
    public class TransactionCategoryEntity : AuditableEntity
    {
        public int TransactionCategory_Id { get; set; }
        public string CategoryName { get; set; }
    }
}