using System.ComponentModel.DataAnnotations;

namespace DojoKitao.Data.Models;

public class Aluno
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Nome do Aluno")]
    [Required(ErrorMessage = "{0} é obrigatório")]
    [MaxLength(50, ErrorMessage = "{0} não pode exceder {1} caracteres!")]
    public string Nome { get; set; }

    public int MatriculaId { get; set; }

    public virtual Matricula Matricula { get; set; }

    public virtual ICollection<Treino> Treinos { get; set; }
}
