
using System.Collections.Generic;

class ApiComprador
{
    public ApiComprador() { }

    public List<CompradorModel> Consultarcomprador()
    {
        
        return new List<CompradorModel>()
        {
            new CompradorModel { IdComprador = 1, Nombre = "Juan Perez" },
            new CompradorModel { IdComprador = 2, Nombre = "Maria Lopez" }
        };
    }

    public CompradorModel IngresarComprador(CompradorModel compradorModel)
    {
        return compradorModel;
    }

    public CompradorModel ModificarComprador(int idComprador, CompradorModel compradorModel)
    {
        return compradorModel;
    }

    public int EliminarComprador(int idComprador)
    {
        return idComprador;
    }
}
