using LegalCaseManagementSystem_FrontEnd.Models;
using System;
using System.Collections.Generic;

public class DashboardState
{
    public int UserId { get; set; } = 0;
    public int LawyerId { get; set; } = 0; // Initialize to 0 (invalid)
    public string LawyerName { get; set; } = string.Empty;
    public bool IsDarkMode { get; set; } = false;
    public bool IsLoading { get; set; } = false;
    public string ErrorMessage { get; set; } = string.Empty;
    public List<Case> Cases { get; set; } = new List<Case>();
    public List<Hearing> UpcomingHearings { get; set; } = new List<Hearing>();
    public List<CaseTask> RecentTasks { get; set; } = new List<CaseTask>();
    public List<Activity> RecentActivities { get; set; } = new List<Activity>();
    public List<Invoice> Invoices { get; set; } = new List<Invoice>();

    public event Action? OnChange = null;

    public void NotifyStateChanged() => OnChange?.Invoke();

    public class Activity
    {
        public string Description { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string Icon { get; set; } = string.Empty;
    }
}