using SimpleAro.Domain.Core.Entities;

namespace SimpleAro.Domain.Modules.ExpenseTracker.Entities
{
    public class MerchantEntity : AuditableEntity
    {
        public int Merchant_Id { get; set; }
        public string MerchantName { get; set; }
        public string LogoPath { get; set; }
    }
}