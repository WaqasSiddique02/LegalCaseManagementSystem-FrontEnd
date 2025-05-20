namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class Invoice
<<<<<<< HEAD
    {
=======
{
>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
        public int InvoiceId { get; set; }
        public int CaseId { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Unpaid";

        public Case Case { get; set; } = null!;
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
