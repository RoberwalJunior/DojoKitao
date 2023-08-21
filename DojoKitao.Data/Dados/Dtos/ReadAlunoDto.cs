﻿namespace DojoKitao.Data.Dados.Dtos;

public class ReadAlunoDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadMatriculaDto Matricula { get; set; }
    public ICollection<ReadTreinoDto> Treinos { get; set; }
}
