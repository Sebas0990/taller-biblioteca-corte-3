using Microsoft.AspNetCore.Mvc;
namespace biblioteca_SR.Controllers
{
    [ApiController]
    [Route("controller")]
    public class BibliotecaController:ControllerBase
    {
        public string PropiedadesBiblioteca { get; set; }
        public BibliotecaController()
        {

        }

        [HttpGet]
        public string ObtenerLibro()
        {
            return "ya tienes el libro pendejo";
        }
    }
}
