using System.Collections.Generic;
using RestAspNET5.Model;

namespace RestAspNET5.Services
{
    public interface IBooksService
    {
        Books Create(Books person);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(long id, Books books);
        void Delete(long id);
    }
}