using System.ComponentModel.DataAnnotations;

namespace DojoKitao.Data.Models;

public class Matricula
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Data de Incrição")]
    [Required(ErrorMessage = "{0} é obrigatório")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime DataIncricao { get; set; }

    public virtual Aluno Aluno { get; set; }
}
