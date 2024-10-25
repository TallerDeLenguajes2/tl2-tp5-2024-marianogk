namespace EspacioPresupuestoDetalle
{
    public class PresupuestoDetalle
    {
        private Producto producto;
        public int Cantidad { get; set; }
        public Producto Producto { get => producto; }
        public void CargarProducto(Producto prod)
        {
            producto = prod;
        }
    }
}