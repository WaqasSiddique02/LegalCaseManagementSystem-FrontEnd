namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public enum CaseStatus
    {
        Open,    // 0
        Closed,  // 1
        Pending,  // 2
        Active,
        Completed,
        InProgress,
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
        public Client? Client { get; set; }
        public Lawyer? Lawyer { get; set; }
        public ICollection<CaseTask> CaseTasks { get; set; } = [];
        public ICollection<Document> Documents { get; set; } = [];
        public ICollection<Hearing> Hearings { get; set; } = [];
        public ICollection<Invoice> Invoices { get; set; } = [];
    }
}