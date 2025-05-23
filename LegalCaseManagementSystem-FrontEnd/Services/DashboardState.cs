using System;
using System.Collections.Generic;
using LegalCaseManagementSystem_FrontEnd.Models;

namespace LegalCaseManagementSystem_FrontEnd.Services
{
    public class DashboardState
    {
        public bool IsDarkMode { get; set; }
        public string? LawyerName { get; set; }
        public int? LawyerId { get; set; }
        public List<Case> Cases { get; set; } = new();
        public List<Hearing> UpcomingHearings { get; set; } = new();
        public List<CaseTask> RecentTasks { get; set; } = new();
        public List<Activity> RecentActivities { get; set; } = new();
        public string? ErrorMessage { get; set; }
        public bool IsLoading { get; set; }

        public event Action? OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();

        public class Activity
        {
            public string Description { get; set; } = string.Empty;
            public DateTime Timestamp { get; set; }
            public string Icon { get; set; } = string.Empty;
        }
    }
}