namespace DojoKitao.Data.Dados;

public interface ICommand<T> where T : class
{
    void Incluir(T obj);
    void Alterar(T obj);
    void Excluir(T obj);
}
