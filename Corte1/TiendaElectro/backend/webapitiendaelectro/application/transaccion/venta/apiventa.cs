

using Dominio.Transaccion.Venta; 

class ApiVenta
{
    public ApiVenta() { }

    public VentaModel IngresarVenta(VentaModel ventaModel)
    {
        return ventaModel;
    }

    public VentaModel ModificarVenta(int idventa, VentaModel ventaModel)
    {
        return ventaModel;
    }

    public int EliminarVenta(int idventa)
    {
        return idventa;
    }

    public string ConsultarVenta()
    {
        return "";
    }
}
