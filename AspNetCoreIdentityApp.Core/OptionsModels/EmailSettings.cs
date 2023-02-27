namespace AspNetCoreIdentityApp.Core.OptionsModels
{
    public class EmailSettings
    {
        public string Host { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}