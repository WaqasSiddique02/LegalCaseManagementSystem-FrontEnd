﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class CaseTask
    {
        [Key]
        public int TaskId { get; set; }
        public int CaseId { get; set; }
        public int? AssignedToLawyerId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        public string Status { get; set; } = "Pending";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }
        public Case Case { get; set; } = null!;
        public Lawyer? AssignedToLawyer { get; set; }
    }
}
