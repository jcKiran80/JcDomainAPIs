using JcDomainAPIs.ClientRepository;
using JcDomainAPIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace JcDomainAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public int GetClientsCount()
        {
            return ClientRepo.ClientRepository.Count();
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetAllClients")]
        public List<EslClient> GetAllClients(int id)
        {

            return ClientRepo.ClientRepository;
        }

        [HttpPost]
        public int CreateNewClient()
        {
            ClientRepo.ClientRepository.Add(new EslClient()
            {
                EslId = Guid.NewGuid(),
                ClientId = string.Concat("BC000", ++ClientRepository.ClientRepo.i),
                First_Name = string.Concat("First_Name", ClientRepository.ClientRepo.i),
                Last_Name = string.Concat("Last_Name", ClientRepository.ClientRepo.i),
                ClientData = string.Empty
            });

            return ClientRepository.ClientRepo.i;
        }
    }
}
