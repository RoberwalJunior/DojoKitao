namespace DojoKitao.Data.Dados.Dtos;

public class ReadAulaDto
{
    public int Id { get; set; }
    public string Data { get; set; }
    public ICollection<string> Alunos { get; set; }
}
