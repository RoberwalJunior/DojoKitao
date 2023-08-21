namespace DojoKitao.Data.Models;

public class Treino
{
    public int? AlunoId { get; set; }
    public virtual Aluno Aluno { get; set; }

    public int? AulaId { get; set; }
    public virtual Aula Aula { get; set; }
}
