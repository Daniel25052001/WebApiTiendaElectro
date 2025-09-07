public class TiendaModel
{
    public TiendaModel()
    {
    }

    public int IdTienda { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public int IdPais { get; set; } // Relación con Pais
}
