using CRUDEFCore.Entities;
using CRUDEFCore.Data;

namespace CRUDEFCore.Repositories;

public class EmpleadoRepository
{
    private readonly AppDbContext _context;

    public EmpleadoRepository()
    {
        _context = new AppDbContext();
    }

    public List<Empleado> ObtenerTodas()
    {
        return _context.Empleado.ToList();
    }

    public Empleado? ObtenerPorId(int id)
    {
        return _context.Empleado.Find(id);
    }

    public List<Empleado> Buscar(string texto)
    {
        return _context.Empleado
        .Where(p => p.NombreCompleto.Contains(texto))
        .ToList();
    }

    public void Insertar(Empleado empleado)
    {
        _context.Empleado.Add(empleado);

        _context.SaveChanges();
    }

    public void Actualizar(Empleado empleado)
    {
        _context.Empleado.Update(empleado);

        _context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var empleado = _context.Empleado.Find(id);

        if (empleado != null)
        {
            _context.Empleado.Remove(empleado);

            _context.SaveChanges();
        }
    }
}
