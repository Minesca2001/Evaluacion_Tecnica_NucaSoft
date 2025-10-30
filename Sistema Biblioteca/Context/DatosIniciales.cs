using Sistema_Biblioteca.Data;
using Sistema_Biblioteca.Models;

namespace Sistema_Biblioteca.Context
{
    public static class DatosIniciales
    {
        public static void CargarDatos(BibliotecaContext context)
        {
            // Evita insertar datos duplicados
            if (!context.Autores.Any())
            {
                var autores = new List<Autor>
                {
                    new Autor { Nombre = "Gabriel García Márquez", Nacionalidad = "Colombiana" },
                    new Autor { Nombre = "Miguel de Cervantes", Nacionalidad = "Española" },
                    new Autor { Nombre = "Jane Austen", Nacionalidad = "Británica" },
                    new Autor { Nombre = "Juan Bosch", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Pedro Mir", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Julia de Burgos", Nacionalidad = "Dominicana" },
                    new Autor { Nombre = "Aida Cartagena Portalatín", Nacionalidad = "Dominicana" },
                    new Autor { Nombre = "Manuel del Cabral", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Marcio Veloz Maggiolo", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Hilma Contreras", Nacionalidad = "Dominicana" },
                    new Autor { Nombre = "René del Risco Bermúdez", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Tulio Manuel Cestero", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Franklin Mieses Burgos", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Rafael Damirón", Nacionalidad = "Dominicano" },
                    new Autor { Nombre = "Soledad Álvarez", Nacionalidad = "Dominicana" }
                };

                context.Autores.AddRange(autores);
                context.SaveChanges();
            }

            if (!context.Libros.Any())
            {
                var libros = new List<Libro>
                {
                    new Libro { Titulo = "Cien años de soledad", AutorId = 1, AñoPublicacion = 1967, Genero = "Realismo mágico" },
                    new Libro { Titulo = "Don Quijote de la Mancha", AutorId = 2, AñoPublicacion = 1605, Genero = "Novela" },
                    new Libro { Titulo = "Orgullo y prejuicio", AutorId = 3, AñoPublicacion = 1813, Genero = "Romántico" },
                    new Libro { Titulo = "Cuentos escritos en el exilio", AutorId = 4, AñoPublicacion = 1962, Genero = "Cuento" },
                    new Libro { Titulo = "Hay un país en el mundo", AutorId = 5, AñoPublicacion = 1949, Genero = "Poesía" },
                    new Libro { Titulo = "Poema en veinte surcos", AutorId = 6, AñoPublicacion = 1938, Genero = "Poesía" },
                    new Libro { Titulo = "Yania Tierra", AutorId = 7, AñoPublicacion = 1981, Genero = "Poesía" },
                    new Libro { Titulo = "Compadre Mon", AutorId = 8, AñoPublicacion = 1943, Genero = "Narrativa social" },
                    new Libro { Titulo = "El hombre del acordeón", AutorId = 9, AñoPublicacion = 2003, Genero = "Novela histórica" },
                    new Libro { Titulo = "Entre dos silencios", AutorId = 10, AñoPublicacion = 1981, Genero = "Narrativa" },
                    new Libro { Titulo = "El cumpleaños de Porfirio Chávez", AutorId = 11, AñoPublicacion = 1969, Genero = "Cuento" },
                    new Libro { Titulo = "Ciudad romántica", AutorId = 12, AñoPublicacion = 1911, Genero = "Novela" },
                    new Libro { Titulo = "Antología poética", AutorId = 13, AñoPublicacion = 1967, Genero = "Poesía" },
                    new Libro { Titulo = "Cuentos y canciones infantiles", AutorId = 14, AñoPublicacion = 1950, Genero = "Literatura infantil" },
                    new Libro { Titulo = "Vuelo posible", AutorId = 15, AñoPublicacion = 1994, Genero = "Poesía" }
            }
            ;

                context.Libros.AddRange(libros);
                context.SaveChanges();
            }

            if (!context.Prestamos.Any())
            {
                var prestamos = new List<Prestamo>
                {
                    new Prestamo { LibroId = 1, FechaPrestamo = DateOnly.FromDateTime(DateTime.Now), FechaDevolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(7)) },
                    new Prestamo { LibroId = 2, FechaPrestamo = DateOnly.FromDateTime(DateTime.Now), FechaDevolucion = DateOnly.FromDateTime(DateTime.Now.AddDays(10)) }
                };

                context.Prestamos.AddRange(prestamos);
                context.SaveChanges();
            }
        }
    }
}