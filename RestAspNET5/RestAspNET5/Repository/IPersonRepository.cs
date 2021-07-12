using System.Collections.Generic;
using RestAspNET5.Model;

namespace RestAspNET5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(long id, Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}