using System.Net;
using Microsoft.AspNetCore.Mvc;
using VersionamentoApi.ViewModels.Cliente;

namespace VersionamentoApi.Controllers.Cliente.V2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [MapToApiVersion("2.0")]
        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            //clienteService.Excluir(codigo);

            return NoContent();
        }

        [MapToApiVersion("2.0")]
        [HttpPost]
        public IActionResult Post(ClienteVmV2 cliente)
        {
            //clienteService.Inserir(cliente);

            return StatusCode((int)HttpStatusCode.Created);
        }
    }
}