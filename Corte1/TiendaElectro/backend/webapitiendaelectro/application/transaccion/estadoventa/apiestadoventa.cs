
using Dominio.Transaccion.EstadoVenta; 

class ApiEstadoVenta
{
    public ApiEstadoVenta() { }

    public EstadoVentaModel IngresarEstadoVenta(EstadoVentaModel estadoVentaModel)
    {
        return estadoVentaModel;
    }

    public EstadoVentaModel ModificarEstadoVenta(int idEstadoVenta, EstadoVentaModel estadoVentaModel)
    {
        return estadoVentaModel;
    }

    public int EliminarEstadoVenta(int idEstadoVenta)
    {
        return idEstadoVenta;
    }

    public string ConsultarEstadoVenta()
    {
        return "";
    }
}
