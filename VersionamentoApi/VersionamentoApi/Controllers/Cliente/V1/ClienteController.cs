using Microsoft.AspNetCore.Mvc;
using System.Net;
using VersionamentoApi.ViewModels.Cliente;

namespace VersionamentoApi.Controllers.Cliente.V1
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(ClienteVm cliente)
        {
            //clienteService.Inserir(cliente);

            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}