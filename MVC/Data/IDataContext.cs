namespace MVC;
public interface IDataContext{
    public Task<List<Producto>> ObtenProductosAsync();
}