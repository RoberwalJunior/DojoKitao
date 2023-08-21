namespace DojoKitao.Data.Dados.Dtos;

public class ReadAulaDto
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public ICollection<ReadTreinoDto> Treinos { get; set; }
}
