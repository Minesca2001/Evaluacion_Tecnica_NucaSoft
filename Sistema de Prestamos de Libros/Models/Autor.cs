namespace Sistema_de_Prestamos_de_Libros.Models
{
    public class Autor
    {
        public int Autor_Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;

        // Relación: un autor puede tener muchos libros
        public ICollection<Libros> Libros { get; set; } = new List<Libros>();
    }
}
