namespace Sistema_Biblioteca.Models
{
    // Clase que representa un autor dentro de un sistema de biblioteca
    public class Autor
    {
        // Identificador único del autor (clave primaria)
        public int AutorId { get; set; }

        // Nombre completo del autor
        public string Nombre { get; set; } = string.Empty;

        // Nacionalidad del autor
        public string Nacionalidad { get; set; } = string.Empty;
    }
}
