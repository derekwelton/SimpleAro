using System;
using SimpleAro.Domain.Core.Entities;

namespace SimpleAro.Domain.Modules.ExpenseTracker.Entities
{
    public class SubTransactionEntity : AuditableEntity
    {
        public int SubTransaction_Id { get; set; }
        public int Transaction_Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ItemName { get; set; }
        public decimal Amount { get; set; }

        public TransactionCategoryEntity Category { get; set; }
        public TransactionSubCategoryEntity SubCategory { get; set; }

    }
}