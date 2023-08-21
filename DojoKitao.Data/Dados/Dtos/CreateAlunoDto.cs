using System.ComponentModel.DataAnnotations;

namespace DojoKitao.Data.Dados.Dtos;

public class CreateAlunoDto
{
    [Display(Name = "Nome do Aluno")]
    [Required(ErrorMessage = "{0} é obrigatório")]
    [StringLength(50, ErrorMessage = "{0} não pode exceder {1} caracteres!")]
    public string Nome { get; set; }
}
