using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 1
Nombre del alumno: Avila Ramayao Brandon Jefte
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/


namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("TodosLosDatos")]
        public IActionResult TodosLosDatos ()
        {
            var repository = new PersonRepository();
            var persons = repository.TodosLosDatos();
            return Ok(persons);
        } 
        [HttpGet]
        [Route("ObtenerCampos")]
        public IActionResult ObtenerCampos ()
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerCampos();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerGenero")]
        public IActionResult ObtenerGenero (char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerGenero(gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerRangoDeEdad")]
        public IActionResult ObtenerRangoDeEdad (int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerRangoDeEdad(minAge, maxAge);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerTrabajos")]
        public IActionResult ObtenerTrabajos ()
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerTrabajos();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerContenido")]
        public IActionResult ObtenerContenido (string partName)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerContenido(partName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerPorEdades")]
        public IActionResult ObtenerPorEdades (int age1, int age2, int age3)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerPorEdades(age1, age2, age3);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ObtenerPersonasOrdenadas")]
        public IActionResult ObtenerPersonasOrdenadas (int age)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerPersonasOrdenadas(age);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerRangoPorEdadYGenero")]
        public IActionResult ObtenerRangoPorEdadYGenero (int minAge, int maxAge, char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerRangoPorEdadYGenero(minAge, maxAge, gender);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("ContarGenero")]
        public IActionResult ContarGenero (char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.ContarGenero(gender);
            return Ok(persons);
        }

                [HttpGet]
        [Route("PersonaExistenteApellido")]
        public IActionResult PersonaExistenteApellido (string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.PersonaExistenteApellido(lastName);
            return Ok(persons);
        }

        [HttpGet]
        [Route("ObtenerTrabajoDeUnaPersonaYSuEdad")]
        public IActionResult ObtenerTrabajoDeUnaPersonaYSuEdad (string job, int age)
        {
            var repository = new PersonRepository();
            var persons = repository.ObtenerTrabajoDeUnaPersonaYSuEdad(job, age);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("TomarPersonas")]
        public IActionResult TomarPersonas (string job, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.TomarPersonas(job, take);
            return Ok(persons);
        }

        [HttpGet]
        [Route("TomarLasUltimasPersonas")]
        public IActionResult TomarLasUltimasPersonas (string job, int takeLast)
        {
            var repository = new PersonRepository();
            var persons = repository.TomarLasUltimasPersonas(job, takeLast);
            return Ok(persons);
        } 

        [HttpGet]
        [Route("SaltarYTomarUnasPersona")]
        public IActionResult SaltarYTomarUnasPersona (string job, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SaltarYTomarUnasPersona(job, skip, take);
            return Ok(persons);
        }

    }

}
