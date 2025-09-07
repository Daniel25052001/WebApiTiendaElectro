

using domain.geografia.departamento;

public class ApiDepartamento
{
    public ApiDepartamento() { }

    public DepartamentoModel IngresarDepartamento(DepartamentoModel departamentoModel)
    {
        // Aquí podrías agregar lógica para guardar el departamento
        return departamentoModel;
    }

    public DepartamentoModel ModificarDepartamento(int iddepartamento, DepartamentoModel departamentoModel)
    {
        // Aquí podrías buscar por id y modificar
        return departamentoModel;
    }

    public int EliminarDepartamento(int iddepartamento)
    {
        // Aquí podrías eliminar el departamento por id
        return iddepartamento;
    }

    public string ConsultarDepartamento()
    {
        // Aquí podrías devolver una lista en JSON, por ejemplo
        return "";
    }
}
