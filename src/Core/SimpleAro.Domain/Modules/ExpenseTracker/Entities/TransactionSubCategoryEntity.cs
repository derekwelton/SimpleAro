using SimpleAro.Domain.Core.Entities;

namespace SimpleAro.Domain.Modules.ExpenseTracker.Entities
{
    public class TransactionSubCategoryEntity : AuditableEntity
    {
        public int TransactionSubCategory_Id { get; set; }
        public int TransactionCategory_Id { get; set; }
        public string SubCategoryName { get; set; }
    }
}