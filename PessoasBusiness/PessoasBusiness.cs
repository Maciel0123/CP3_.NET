using PessoasModel;
using PessoasData;
using Microsoft.EntityFrameworkCore;

namespace PessoasBusiness;

public class PessoasService : IPessoasService
{
    private readonly ApplicationDbContext _context;

    public PessoasService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<PessoasModel.PessoasModel> ListarTodos() =>
        _context.Pessoas.ToList(); // Retorna a lista de todas as pessoas

    public PessoasModel.PessoasModel? ObterPorId(string id)
    {
        if (!Guid.TryParse(id, out var parsedId)) // Converte string para Guid
            return null; // Se a conversão falhar, retorna null

        return _context.Pessoas.FirstOrDefault(c => c.Id == parsedId); // Comparando Guid com Guid
    }

    public PessoasModel.PessoasModel Criar(PessoasModel.PessoasModel pessoas)
    {
        _context.Pessoas.Add(pessoas);
        _context.SaveChanges();
        return pessoas;
    }

    public bool Atualizar(PessoasModel.PessoasModel pessoas)
    {
        var existente = _context.Pessoas.Find(pessoas.Id);
        if (existente == null) return false;

        existente.Nome = pessoas.Nome;
        existente.EstadoCivil = pessoas.EstadoCivil;
        existente.Idade = pessoas.Idade;

        _context.SaveChanges();
        return true;
    }

    public bool Remover(string id)
    {
        if (!Guid.TryParse(id, out var parsedId)) // Verifica se o id é um Guid válido
            return false;

        var pessoa = _context.Pessoas.Find(parsedId); // Busca pela chave Guid
        if (pessoa == null) return false;

        _context.Pessoas.Remove(pessoa);
        _context.SaveChanges();
        return true;
    }
}