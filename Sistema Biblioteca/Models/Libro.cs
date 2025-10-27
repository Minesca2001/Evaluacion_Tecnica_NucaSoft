namespace Sistema_Biblioteca.Models
{
    public class Libro
    {
        public int libro_id { get; set; }
        public string titulo { get; set; } = string.Empty;
        public int autor_id { get; set; }
        public int año_publicacion { get; set; }
        public string genero { get; set; } = string.Empty;
    }
}
