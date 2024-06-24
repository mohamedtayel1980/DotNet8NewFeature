namespace IdentityApiSample.Models
{
    public class ResetPasswordModel
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
