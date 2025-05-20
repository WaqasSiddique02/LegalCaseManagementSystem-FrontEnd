﻿namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public int CaseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Case Case { get; set; } = null!;
    }
}