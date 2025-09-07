
namespace Dominio.Transaccion.Venta
{
    public class VentaModel
    {
        public VentaModel()
        {
        }

        public int IdVenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime fechadeventa { get; set; }
    }
}
