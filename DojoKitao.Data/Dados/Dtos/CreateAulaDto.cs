using System.ComponentModel.DataAnnotations;

namespace DojoKitao.Data.Dados.Dtos;

public class CreateAulaDto
{
    [Display(Name = "Data da Aula")]
    [Required(ErrorMessage = "{0} é obrigatório")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime Data { get; set; }
}
