using PessoasModel;

namespace PessoasBusiness
{
    public interface IPessoasService
    {
        List<PessoasModel.PessoasModel> ListarTodos();
        PessoasModel.PessoasModel? ObterPorId(string id);
        PessoasModel.PessoasModel Criar(PessoasModel.PessoasModel pessoas);
        bool Atualizar(PessoasModel.PessoasModel pessoas);
        bool Remover(string id);
    }
}
