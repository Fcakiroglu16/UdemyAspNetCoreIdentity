namespace AspNetCoreIdentityApp.Core.ViewModels
{
    public class ClaimViewModel
    {


        public string Issuer { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
