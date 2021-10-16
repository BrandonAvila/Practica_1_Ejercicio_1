using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 1
Nombre del alumno: Avila Ramayao Brandon Jefte
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/


namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores

        public IEnumerable<Person> TodosLosDatos ()
        {
            return _persons;
        }

        // retornar campos especificos

        public IEnumerable<Object> ObtenerCampos ()
        {
            var query = _persons.Select(person => new {

                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1).Year,
                CorreoElcetronico = person.Email 
            });
            
            return query;
        }

        // retornar elementos que sean iguales

        public IEnumerable<Person> ObtenerGenero (char gender)
        {
            var query = _persons.Where(person => person.Gender == gender);
            return query;
        }

        // retornar valores entre un rango
        
        public IEnumerable<Person> ObtenerRangoDeEdad (int minAge, int maxAge)
        {
            var query = _persons.Where(person => person.Age > minAge && person.Age < maxAge);
            return query;
        }

        /*public IEnumerable<Person> GetByMaxAge()
        {
            var age = 30;
            var query = _persons.Where(person => person.Age <= age);
            return query;
        }*/

        // Retornar elementos que sean diferentes

        /*public IEnumerable<Person> ObtenerDiferencias (string job)
        {
            var query = _persons.Where(person => person.Job != job);
            return query;
        }*/
        
        public IEnumerable<string> ObtenerTrabajos()
        {
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        } 

        // retornar valores que contengan
        
        public IEnumerable<Person> ObtenerContenido (string partName)
        {
            var query = _persons.Where(person => person.FirstName.Contains(partName));
            return query;
        }

        public IEnumerable<Person> ObtenerPorEdades (int age1, int age2, int age3)
        {
            var ages = new List<int>{age1,age2,age3};
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query;
        }

        // retornar elementos ordenados
        
        public IEnumerable<Person> ObtenerPersonasOrdenadas (int age)
        {
            var query = _persons.Where(person => person.Age > age).OrderBy(person => person.Age);
            return query;
        }

        public IEnumerable<Person> ObtenerRangoPorEdadYGenero (int minAge, int maxAge, char gender)
        {
            var query = _persons.Where(person => person.Age > minAge && person.Age < maxAge &&  person.Gender ==  gender).OrderByDescending(person =>  person.Gender);
            return query;
        }

        /*public IEnumerable<Person> GetPersonsOrderedDesc()
        {
            var job = "Paralegal";
            var query = _persons.Where(person => person.Job == job).OrderByDescending(Person => Person.Age);
            return query;
        }*/

        // retorno cantidad de elementos
        
        public int ContarGenero (char gender)
        {
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }

        // Evalua si un elemento existe

        public bool PersonaExistenteApellido (string lastName)
        {
            var query = _persons.Any(p => p.LastName == lastName);

            return query;
        }

        /*public bool AnyPerson()
        {
            var lastName = "Shemelt";
            var query = _persons.Any(p => p.LastName == lastName);

            return query;
        }*/

        // retornar solo un elemento
        
        /*public Person GetPerson()
        {
            var generador = new Random(DateTime.Now.Millisecond);
            var id = generador.Next(1000);

            var query = _persons.FirstOrDefault(person => person.Id == id);
            return query;
        }*/

        public IEnumerable<Person> ObtenerTrabajoDeUnaPersonaYSuEdad (string job, int age)
        {
            var query = _persons.Where(person => person.Job == job && person.Age == age);
            return query;
        }

        // retornar solamente unos elementos
        
        public IEnumerable<Person> TomarPersonas (string job, int take)
        {
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }

        public IEnumerable<Person> TomarLasUltimasPersonas(string job, int takeLast)
        {

            var query = _persons.Where(person => person.Job == job).TakeLast(takeLast);
            return query;
        }

        // retornar elementos saltando posición
        
        /*public IEnumerable<Person> SkipPerson()
        {
            var job = "Software Consultant";
            var skip = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }*/

        public IEnumerable<Person> SaltarYTomarUnasPersona(string job, int skip, int take)
        {
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }
    }
}