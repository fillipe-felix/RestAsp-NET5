using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNET5.Model;
using RestAspNET5.Model.Context;
using RestAspNET5.Repository;

namespace RestAspNET5.Services.Implemetations
{
    public class PersonServiceImplementation : IPersonService
    {
        private readonly IPersonRepository _repository;

        public PersonServiceImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            
            return _repository.Create(person);
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        public Person Update(long id, Person person)
        {
            return _repository.Update(id, person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}