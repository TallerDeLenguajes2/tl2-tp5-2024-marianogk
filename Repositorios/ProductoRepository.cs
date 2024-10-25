public class ProductoRepository : IRepository
{

    public void Create(Producto producto)
    {

    }

    public void Update(Producto producto, int idProducto)
    {

    }
    public List<Producto> GetAll()
    {
        return List<Producto>();
    }
    public Producto GetById(int idProducto)
    {
        Producto producto;
        return producto;
    }


    public void Delete(Producto producto, int idProducto)
    {

    }
}

public interface IRepository
{
    
    Producto FindById(int idProducto);
    IRepository FindAll();
    void Insert(Producto producto);
    void Update(Producto producto);
    void Delete(int idProducto);
}