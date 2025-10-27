namespace Sistema_de_Prestamos_de_Libros.Models
{
    public class Prestamo
    {
        public int Prestamo_Id { get; set; }
        public int Libro_Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }
    }
}
