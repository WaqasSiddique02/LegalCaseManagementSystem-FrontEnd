using LegalCaseManagementSystem_FrontEnd.Models.Auth;

namespace LegalCaseManagementSystem_FrontEnd.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private string _token = string.Empty;
        private string _role = string.Empty;
        private int _userId;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AuthResponse?> LoginAsync(string username, string password)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/api/Auth/login", new
                {
                    Username = username,
                    Password = password
                });

                Console.WriteLine($"Response status: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<AuthResponse>();
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error response: {errorContent}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
                throw;
            }
        }

        public void SetAuthToken(string token, string role, int userId)
        {
            _token = token;
            _role = role;
            _userId = userId;

            // Update HttpClient headers with the token
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        public void ClearAuthToken()
        {
            _token = string.Empty;
            _role = string.Empty;
            _userId = 0;
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public string GetToken() => _token;
        public string GetRole() => _role;
        public int GetUserId() => _userId;
        public bool IsAuthenticated() => !string.IsNullOrEmpty(_token);
    }
}