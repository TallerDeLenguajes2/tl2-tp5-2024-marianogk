public class PresupuestoRepository : IRepository
{
    private List<Presupuesto> presupuestos;

    public PresupuestoRepository()
    {
        presupuestos = new List<Presupuesto>();
    }
    public void Insert(Presupuesto presupuesto)
    {
        presupuestos.Add(presupuesto);
    }

    public void Update(Presupuesto presupuesto, int idPresupuesto)
    {
        var presupuestoBuscado = presupuestos.FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
        if (PresupuestoBuscado != null)
        {
            presupuestoBuscado.Descripcion = presupuesto.Descripcion;
            presupuestoBuscado.Precio = presupuesto.Precio;
        }
    }
    public List<Presupuesto> FindAll()
    {
        return presupuestos;
    }
    public Presupuesto FindById(int idPresupuesto)
    {
        return presupuestos.FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
    }


    public void Delete(int idPresupuesto)
    {
        var presupuesto = presupuestos.FirstOrDefault(p => p.IdPresupuesto == idPresupuesto);
        if (presupuesto != null)
        {
            presupuestos.Remove(presupuesto);
        }
    }

}

public interface IRepository
{

    Presupuesto FindById(int idPresupuesto);
    List<Presupuesto> FindAll();
    void Insert(Presupuesto presupuesto);
    void Update(Presupuesto presupuesto, int idPresupuesto);
    void Delete(int idPresupuesto);
}