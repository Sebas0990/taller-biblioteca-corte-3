using biblioteca_SR.Datos.modelo;
using Microsoft.EntityFrameworkCore;
namespace biblioteca_SR.Datos.Servicio
{
    public class RepositorioBibliotreca : DbContext
    {
        public RepositorioBibliotreca(DbContextOptions<RepositorioBibliotreca> options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; } 
    }
}
