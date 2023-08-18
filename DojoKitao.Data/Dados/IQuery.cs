namespace DojoKitao.Data.Dados;

public interface IQuery<T> where T : class
{
    IEnumerable<T> BuscarTodos();
    T? BuscarPorId(int id);
}
