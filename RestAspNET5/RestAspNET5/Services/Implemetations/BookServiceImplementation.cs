using System.Collections.Generic;
using RestAspNET5.Model;
using RestAspNET5.Repository.Generic;

namespace RestAspNET5.Services.Implemetations
{
    public class BookServiceImplementation : IBooksService
    {

        private readonly IRepository<Books> _bookRepository;

        public BookServiceImplementation(IRepository<Books> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Books Create(Books books)
        {
            
            return _bookRepository.Create(books);
        }

        public Books FindById(long id)
        {
            return _bookRepository.FindById(id);
        }

        public List<Books> FindAll()
        {
            return _bookRepository.FindAll();
        }

        public Books Update(long id, Books books)
        {
            return _bookRepository.Update(id, books);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }
    }
}