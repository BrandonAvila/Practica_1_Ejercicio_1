using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("Todos")]
        public IActionResult Todos ()
        {
            var repository = new PersonRepository();
            var persons = repository.TodosLosDatos();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("Campos")]
        public IActionResult Campos ()
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerCampos();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("Generos")]
        public IActionResult BuscarGenero (char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerGenero(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("RangoEdad")]
        public IActionResult RangoDeEdad (int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerRangoDeEdad(minAge, maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerTrabajos")]
        public IActionResult Trabajos ()
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerTrabajos();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerContenido")]
        public IActionResult BuscarContenido (string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerContenido(partName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerEdades")]
        public IActionResult BuscarPorEdades (int age1, int age2, int age3)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerPorEdades(age1, age2, age3);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerPersonasOrdenadas")]
        public IActionResult BuscarPersonasOrdenadas (int age)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerPersonasOrdenadas(age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerRangoPorEdadYGenero")]
        public IActionResult BuscarRangoPorEdadYGenero (int minAge, int maxAge, char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerRangoPorEdadYGenero(minAge, maxAge, gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ContarGenero")]
        public IActionResult ContarGeneros (char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ContarGenero(gender);
            return Ok(persons);
        }

                [HttpGet]
        [Route("PersonaExistenteApellido")]
        public IActionResult PersonaExistenteConApellido (string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.PersonaExistenteApellido(lastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerTrabajoDeUnaPersonaYSuEdad")]
        public IActionResult BuscarTrabajoDeUnaPersonaYSuEdad (string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerTrabajoDeUnaPersonaYSuEdad(job, age);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("TomarPersonas")]
        public IActionResult TakePersonas (string job, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.TomarPersonas(job, take);
            return Ok(persons);
        }

        [HttpGet]
        [Route("TomarLasUltimasPersonas")]
        public IActionResult TakeLasUltimasPersonas (string job, int takeLast)
        {
            var repository = new PersonRepository();
            var persons = repository.TomarLasUltimasPersonas(job, takeLast);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("SaltarYTomarUnasPersona")]
        public IActionResult SkipAndTakeUnasPersona (string job, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SaltarYTomarUnasPersona(job, skip, take);
            return Ok(persons);
        }

    }

}
