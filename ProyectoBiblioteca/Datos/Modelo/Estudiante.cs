namespace ProyectoBiblioteca.Datos.Modelo
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int NumeroPrestamos { get; set; }
        public string Carrera { get; set; }
        public int Incumplimientos { get; set; }
    }
}
