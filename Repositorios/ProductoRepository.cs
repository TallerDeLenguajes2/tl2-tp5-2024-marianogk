public class ProductoRepository : IRepository
{
    private List<Producto> productos;

    public ProductoRepository()
    {
        productos = new List<Producto>();
    }
    public void Insert(Producto producto)
    {
        productos.Add(producto);
    }

    public void Update(Producto producto, int idProducto)
    {
        var productoBuscado = productos.FirstOrDefault(p => p.IdProducto == idProducto);
        if (productoBuscado != null)
        {
            productoBuscado.Descripcion = producto.Descripcion;
            productoBuscado.Precio = producto.Precio;
        }
    }
    public List<Producto> FindAll()
    {
        return productos;
    }
    public Producto FindById(int idProducto)
    {
        return productos.FirstOrDefault(p => p.IdProducto == idProducto);
    }


    public void Delete(int idProducto)
    {
        var producto = productos.FirstOrDefault(p => p.IdProducto == idProducto);
        if (producto != null)
        {
            productos.Remove(producto);
        }
    }

}

public interface IRepository
{

    Producto FindById(int idProducto);
    List<Producto> FindAll();
    void Insert(Producto producto);
    void Update(Producto producto, int idProducto);
    void Delete(int idProducto);
}