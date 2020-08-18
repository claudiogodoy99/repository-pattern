
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern_Domain.Entites;
using Repository_Pattern_Domain.Interfaces.Services;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Respository_Pattern_Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult>  Get([FromRoute] int id)
        {
            return Ok(await clienteService.Get(id));
        }

        [HttpGet]
        public async Task<ActionResult> Get() 
        {
            return Ok(await clienteService.Get());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Cliente cliente)
        {
            return Ok(await clienteService.Insert(cliente));
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Cliente cliente)
        {
            await clienteService.Update(cliente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            await clienteService.Delete(id);
            return Ok();
        }
    }
}
