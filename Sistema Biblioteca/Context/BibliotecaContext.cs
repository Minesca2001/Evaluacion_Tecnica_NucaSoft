using Microsoft.EntityFrameworkCore;
using Sistema_Biblioteca.Models;

namespace Sistema_Biblioteca.Context
{
    // Clase que permite acceder y administrar los datos de autores, libros y préstamos, en el contexto de base de datos para Entity Framework
    public class BibliotecaContext : DbContext
    {
        // Constructor que recibe las opciones de configuración del contexto
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { }

        // Representa la tabla de autores en la base de datos
        public DbSet<Autor> Autores { get; set; }

        // Representa la tabla de libros en la base de datos
        public DbSet<Libro> Libros { get; set; }

        // Representa la tabla de préstamos en la base de datos
        public DbSet<Prestamo> Prestamos { get; set; }
        // Representa la tabla de préstamos en la base de datos
        public DbSet<Usuario> Usuarios { get; set; }

        // Propiedad que configura las relaciones entre las entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relaciones de uno a muchos, donde un autor puede tener muchos libros
            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autor)
                .WithMany()
                .HasForeignKey(l => l.AutorId);

            // Relaciones de uno a muchos, donde un libro puede tener muchos préstamos
            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Libro)
                .WithMany()
                .HasForeignKey(p => p.LibroId);
        }
    }
}