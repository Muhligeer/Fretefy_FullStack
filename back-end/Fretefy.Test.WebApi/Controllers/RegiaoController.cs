using Fretefy.Test.Domain.DTO;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public ActionResult<ListarRegiaoDto> Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);
            if (regiao == null) return NotFound();
            return Ok(regiao);
        }

        [HttpPost]
        public ActionResult<ListarRegiaoDto> Create([FromBody] CriarRegiaoDto regiao)
        {
            try
            {
                var result = _regiaoService.Create(regiao);
                return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<ListarRegiaoDto> Put(Guid id, [FromBody] AtualizarRegiaoDto dto)
        {
            if (id != dto.Id)
                return BadRequest("ID da URL difere do corpo.");

            try
            {
                var result = _regiaoService.Update(dto);
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
