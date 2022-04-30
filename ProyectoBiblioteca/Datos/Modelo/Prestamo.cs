namespace ProyectoBiblioteca.Datos.Modelo
{
    public class Prestamo
    {
        public int ID { get; set; }
        public string Prestamista { get; set; }
        public string FechaInicial { get; set; }
        public string FechaFinal { get; set; }
        public string Sancion { get; set; }
    }
}
