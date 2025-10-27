namespace Sistema_de_Prestamos_de_Libros.Models
{
    public class Libros
    {
        public int Libro_Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int Autor_Id { get; set; }
        public int Año_Publicacion { get; set; }
        public string Genero { get; set; } = string.Empty;

        // Relación: un libro puede tener muchos prestamos
        public ICollection<Prestamo> Prestamo { get; set; } = new List<Prestamo>();
    }
}
