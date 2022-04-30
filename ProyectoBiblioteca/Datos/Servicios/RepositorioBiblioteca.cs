using Microsoft.EntityFrameworkCore;
using ProyectoBiblioteca.Datos.Modelo;

namespace ProyectoBiblioteca.Datos.Servicios
{
    public class RepositorioBiblioteca: DbContext
    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {
            
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        //Crear otras 3 propiedades restantes (Autor, Estudiante, Prestamo)
    }
}
