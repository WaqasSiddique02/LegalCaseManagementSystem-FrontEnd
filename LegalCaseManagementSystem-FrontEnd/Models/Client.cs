namespace LegalCaseManagementSystem_FrontEnd.Models
{
    public class Client
{
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ContactInfo { get; set; } = string.Empty;
    }
}
