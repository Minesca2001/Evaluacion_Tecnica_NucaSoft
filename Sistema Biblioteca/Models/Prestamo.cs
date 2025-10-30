namespace Sistema_Biblioteca.Models
{
    // Clase que representa el préstamo de un libro dentro de la biblioteca
    public class Prestamo
    {
        // Identificador único del préstamo (clave primaria)
        public int PrestamoId { get; set; }

        // Clave foránea que vincula el préstamo con un libro específico
        public int LibroId { get; set; }

        // Fecha en la que se realiza el préstamo
        public DateOnly FechaPrestamo { get; set; }

        // Fecha en la que el libro debe ser devuelto
        public DateOnly FechaDevolucion { get; set; }

        // Propiedad que permite acceder a los datos del libro
        public Libro? Libro { get; set; }
    }
}
