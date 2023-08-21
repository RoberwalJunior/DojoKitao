using System.ComponentModel.DataAnnotations;

namespace DojoKitao.Data.Models;

public class Aula
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Display(Name = "Data da Aula")]
    [Required(ErrorMessage = "{0} é obrigatório")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime Data { get; set; }

    public virtual ICollection<Treino> Treinos { get; set; }
}
