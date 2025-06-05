using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IActionResult> List()
        {
            var regioes = await _regiaoService.ListAsync();
            return Ok(regioes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ListarRegiaoDto>> Get(Guid id)
        {
            var regiao = await _regiaoService.GetAsync(id);
            if (regiao == null) return NotFound();
            return Ok(regiao);
        }

        [HttpPost]
        public async Task<ActionResult<ListarRegiaoDto>> Create([FromBody] CriarRegiaoDto regiao)
        {
            try
            {
                var result = await _regiaoService.CreateAsync(regiao);
                return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ListarRegiaoDto>> Put(Guid id, [FromBody] AtualizarRegiaoDto dto)
        {
            if (id != dto.Id)
                return BadRequest("ID da URL difere do corpo.");

            try
            {
                var result = await _regiaoService.UpdateAsync(dto);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("ID inválido.");
            }
            await _regiaoService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> PatchStatus(Guid id, [FromBody] AtualizarRegiaoStatusDto dto)
        {
            if (id != dto.Id)
                return BadRequest("ID da URL difere do corpo.");

            try
            {
                await _regiaoService.AtualizarStatusAsync(dto);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
