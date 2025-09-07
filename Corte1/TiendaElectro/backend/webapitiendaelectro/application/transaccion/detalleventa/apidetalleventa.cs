
using dominio.transaccion.detalleventa; // Asegúrate de usar el namespace correcto del modelo

class ApiDetalleVenta
{
    public ApiDetalleVenta() { }

    public DetalleVentaModel IngresarDetalleVenta(DetalleVentaModel detalleVentaModel)
    {
        return detalleVentaModel;
    }

    public DetalleVentaModel ModificarDetalleVenta(int idDetalleVenta, DetalleVentaModel detalleVentaModel)
    {
        return detalleVentaModel;
    }

    public int EliminarDetalleVenta(int idDetalleVenta)
    {
        return idDetalleVenta;
    }

    public string ConsultarDetalleVenta()
    {
        return "";
    }
}
