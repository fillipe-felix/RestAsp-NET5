using System.Collections.Generic;
using RestAspNET5.Model;

namespace RestAspNET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}