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
            return 100;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetAllClients")]
        public List<EslClient> GetAllClients(int id)
        {

            return ClientRepo.ClientRepository;
        }
    }
}
