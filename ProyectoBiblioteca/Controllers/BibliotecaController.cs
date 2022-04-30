using Microsoft.AspNetCore.Mvc;

namespace ProyectoBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaController:ControllerBase
    {
        //Propiedad Publica
        public string PropiedadesBiblioteca { get; set; }
        public BibliotecaController()
        {
            //Constructor

        }
        [HttpGet]
        public string ObtenerLibro()
        {
            //Funcion
            return "Pendejo ya tienes el libro";

        }

        public string ObtenerPrestamo()
        {
            return "Ya devolvite el libro";
        }

        public string BuscarEstudiante()
        {
            return "Estudiante obtenido de la base de datos";
        }
        [HttpGet]
        public string Get_Loan()
        {
            return "The loan has been found";
        }
        [HttpGet]
        public string BuscarAutor()
        {
            return "Se encontro el autor";
        }
        [HttpPost]
        public string ActualizarLibro()
        {
            return "Actualizado";
        }
        [HttpPost]
        public string ActualizarEstudiante()
        {
            return "Actualizado";
        }
        [HttpPost]
        public string Update_Loan()
        {
            return "Monetary data updated";
        }
        [HttpPost]
        public string ActualizarAutor()
        {
            return "Actualizado";
        }
        [HttpPut]
        public string UActualizarLibro()
        {
            return "Actualizado";
        }
        [HttpPut]
        public string NuevoEstudiante()
        {
            return "Añadido";
        }
        [HttpPut]
        public string Include_Loan()
        {
            return "New loan created";
        }
        [HttpPut]
        public string CrearAutor()
        {
            return "Creado";
        }
        [HttpDelete]
        public string BorrarLibro()
        {
            return "Eliminado";

        }
        [HttpDelete]
        public string BorrarEstudiante()
        {
            return "Borrado";
        }
        [HttpDelete]
        public string Delete_Loan()
        {
            return "The loan has been paid/the loan has been deleted";
        }
        [HttpDelete]
        public string BorrarAutor()
        {
            return "Author data eliminated succesfully";
        }
    }



}
}