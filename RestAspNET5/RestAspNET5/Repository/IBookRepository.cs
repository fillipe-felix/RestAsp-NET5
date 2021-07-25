using System.Collections.Generic;
using RestAspNET5.Model;

namespace RestAspNET5.Repository
{
    public interface IBookRepository
    {
        Books Create(Books books);
        Books FindById(long id);
        List<Books> FindAll();
        Books Update(long id, Books books);
        void Delete(long id);
        bool Exists(long id);
    }
}