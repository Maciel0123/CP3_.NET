namespace PessoasModel;
public class PessoasModel
{
    public Guid? Id { get; set; }  
    public required string Nome { get; set; }
    public int Idade { get; set; }
    public required string EstadoCivil { get; set; }
}