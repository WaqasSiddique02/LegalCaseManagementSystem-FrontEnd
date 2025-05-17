namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class Case
{
        public int CaseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ClientId { get; set; }
        public int LawyerId { get; set; }
    }
}
