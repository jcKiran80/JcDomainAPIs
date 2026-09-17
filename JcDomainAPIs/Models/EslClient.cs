namespace JcDomainAPIs.Models
{
    public class EslClient
    {
        public Guid EslId { get; set; }

        public string ClientId  { get; set; }

        public string First_Name { get; set; } = string.Empty;

        public string Last_Name { get; set; } = string.Empty;

        public string ClientData { get; set; } = string.Empty;
    }
}
