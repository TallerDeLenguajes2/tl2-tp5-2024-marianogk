public class Presupuesto
{
    private int idPresupuesto;
    private string nombreDestinatario;
    private List<PresupuestoDetalle> detalles;
    public int IdPresupuesto { get => idPresupuesto; set => idPresupuesto = value; }
    public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }
    public List<PresupuestoDetalle> Detalles { get => detalles; set => detalles = value; }

    public Presupuesto()
    {
        detalles = new List<PresupuestoDetalle>();
    }
    public float MontoPresupuesto()
    {
        float total = 0;
        foreach (var p in detalles)
        {
            total = p.Cantidad * p.Producto.Precio;
        }
        return total;
    }
    public double MontoPresupuestoConIva()
    {
        double total = 0;
        const double iva = 1.21;
        foreach (var p in detalles)
        {
            total = p.Cantidad * p.Producto.Precio * iva;
        }
        return total;
    }

    public int CantidadProductos()
    {
        return detalles.Count;
    }
}