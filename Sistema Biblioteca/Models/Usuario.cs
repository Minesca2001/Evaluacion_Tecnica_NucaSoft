namespace Sistema_Biblioteca.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty; // almacenar hash en prod
        public string Role { get; set; } = "usuario"; // "admin" or "usuario"
    }
}
