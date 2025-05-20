using System.Reflection.Metadata;
<<<<<<< HEAD
=======

>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public enum CaseStatus
    {
<<<<<<< HEAD
        Pending,
        Active,
        Completed,
        InProgress,
        Open,
        Closed
=======
        Open,
        Closed,
        Pending
>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
    }

    public class Case
    {
        public int CaseId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public CaseStatus Status { get; set; } = CaseStatus.Open;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int ClientId { get; set; }

        public int LawyerId { get; set; }

        public Client Client { get; set; } = null!;

        public Lawyer Lawyer { get; set; } = null!;

        public ICollection<CaseTask> CaseTasks { get; set; } = [];

        public ICollection<Document> Documents { get; set; } = [];

        public ICollection<Hearing> Hearings { get; set; } = [];

        public ICollection<Invoice> Invoices { get; set; } = [];
    }
}
