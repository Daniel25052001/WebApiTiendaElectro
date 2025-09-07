
using domain.producto.categoria;

public class ApiCategoria
{
    public ApiCategoria() { }

    public CategoriaModel IngresarCategoria(CategoriaModel categoriaModel)
    {
        // Aquí podrías agregar lógica para guardar la categoría
        return categoriaModel;
    }

    public CategoriaModel ModificarCategoria(int idcategoria, CategoriaModel categoriaModel)
    {
        // Aquí podrías buscar por id y modificar
        return categoriaModel;
    }

    public int EliminarCategoria(int idcategoria)
    {
        // Aquí podrías eliminar la categoría por id
        return idcategoria;
    }

    public string ConsultarCategoria()
    {
        // Aquí podrías devolver una lista en JSON, por ejemplo
        return "";
    }
}
