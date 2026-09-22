using JcDomainAPIs.Models;
using System.Net.NetworkInformation;

namespace JcDomainAPIs.ClientRepository
{
    public static class ClientRepo
    {
        public static int i = 0;

        public static List<EslClient> ClientRepository { get; set; } = new()
        {
            new EslClient() { EslId = Guid.NewGuid(), ClientId ="BC0001", First_Name = "First_Name 1", Last_Name = "Last_Name 1" },
            new EslClient() { EslId = Guid.NewGuid(), ClientId ="BC0002", First_Name = "First_Name 2", Last_Name = "Last_Name 2" }
        };
    }
}
