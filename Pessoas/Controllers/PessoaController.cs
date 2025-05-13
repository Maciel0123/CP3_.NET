using Microsoft.AspNetCore.Mvc;
using PessoasBusiness;
using Model = PessoasModel.PessoasModel;

namespace PessoasApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoasController(IPessoasService pessoasService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var pessoas = pessoasService.ListarTodos();
        return pessoas.Count == 0 ? NoContent() : Ok(pessoas);
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
        var pessoa = pessoasService.ObterPorId(id);
        return pessoa == null ? NotFound() : Ok(pessoa);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Model pessoa)
    {
        if (string.IsNullOrWhiteSpace(pessoa.Nome))
            return BadRequest("Nome é obrigatório.");
        var criado = pessoasService.Criar(pessoa);
        return CreatedAtAction(nameof(Get), new { id = criado.Id }, criado);
    }

    [HttpPut]
    public IActionResult Put([FromBody] Model pessoa)
    {
        if (pessoa == null)
            return BadRequest("Dados inconsistentes.");
        return pessoasService.Atualizar(pessoa) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        return pessoasService.Remover(id) ? NoContent() : NotFound();
    }
}
