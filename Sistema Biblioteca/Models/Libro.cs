namespace Sistema_Biblioteca.Models
{
    // Clase que representa un libro dentro del sistema de biblioteca
    public class Libro
    {
        // Identificador único del libro (clave primaria)
        public int LibroId { get; set; }

        // Título o nombre del libro
        public string Titulo { get; set; } = string.Empty;

        // Clave foránea que relaciona el libro con un autor
        public int AutorId { get; set; }

        // Año en que fue publicado el libro
        public int AñoPublicacion { get; set; }

        // Género literario del libro
        public string Genero { get; set; } = string.Empty;

        // Propiedad que permite acceder directamente al autor
        public Autor? Autor { get; set; }
    }
}