using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var regioes = _regiaoService.List();
            return Ok(regioes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);
            if (regiao == null)
            {
                return NotFound();
            }
            return Ok(regiao);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Domain.Entities.Regiao regiao)
        {
            if (regiao == null)
            {
                return BadRequest("Região não pode ser null.");
            }
            var createdRegiao = _regiaoService.Create(regiao);
            return CreatedAtAction(nameof(Get), new { id = createdRegiao.Id }, createdRegiao);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Domain.Entities.Regiao regiao)
        {
            if (regiao == null || regiao.Id != id)
            {
                return BadRequest("Dados inválidos para atualização.");
            }
            var updatedRegiao = _regiaoService.Update(regiao);
            return Ok(updatedRegiao);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("ID inválido.");
            }
            _regiaoService.Delete(id);
            return NoContent();
        }
    }
}
