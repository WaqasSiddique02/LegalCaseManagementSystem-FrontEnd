namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class Document
<<<<<<< HEAD
    {
=======
{
>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
        public int DocumentId { get; set; }
        public int CaseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Case Case { get; set; } = null!;
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> bff96e2785d853b5d56cfae98c8fb8607b07d282
