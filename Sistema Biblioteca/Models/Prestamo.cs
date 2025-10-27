namespace Sistema_Biblioteca.Models
{
    public class Prestamo
    {
        public int prestamo_id { get; set; }
        public int libro_id { get; set; }
        public DateOnly fecha_prestamo { get; set; }
        public DateOnly fecha_devolucion { get; set; }
    }
}
