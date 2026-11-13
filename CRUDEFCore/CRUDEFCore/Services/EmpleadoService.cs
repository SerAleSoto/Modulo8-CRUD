using CRUDEFCore.Entities;
using CRUDEFCore.Repositories;

namespace CRUDEFCore.Services;
public class EmpleadoService
{
    private readonly EmpleadoRepository _repository;

    public EmpleadoService()
    {
        _repository = new EmpleadoRepository();
    }

    public List<Empleado> ObtenerTodas()
    {
        return _repository.ObtenerTodas();
    }

    public List<Empleado> Buscar(string texto)
    {
        return _repository.Buscar(texto);
    }

    public void Insertar(Empleado empleado)
    {
        Validar(empleado);

        _repository.Insertar(empleado);
    }

    public void Actualizar(Empleado empleado)
    {
        Validar(empleado);

        _repository.Actualizar(empleado);
    }

    public void Eliminar(int id)
    {
        _repository.Eliminar(id);
    }

    private void Validar(Empleado empleado)
    {
        if (string.IsNullOrWhiteSpace(empleado.NombreCompleto))
        {
            throw new Exception(
            "El nombre es obligatorio.");
        }

        if (string.IsNullOrWhiteSpace(empleado.NumeroDocumento))
        {
            throw new Exception(
            "El número de documento es obligatorio.");
        }

        if (empleado.Sueldo < 0)
        {
            throw new Exception(
            "El sueldo no puede ser negativo.");
        }
    }

}
