using System;
using System.Collections.Generic;
using System.Linq;
using RestAspNET5.Model;
using RestAspNET5.Model.Context;

namespace RestAspNET5.Repository.Implemetations
{
    public class BookRepositoryImplementation : IBookRepository
    {

        private readonly MySqlContext _context;

        public BookRepositoryImplementation(MySqlContext context)
        {
            _context = context;
        }

        public Books Create(Books books)
        {
            try
            {
                _context.Add(books);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return books;
        }

        public Books FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        public List<Books> FindAll()
        {
            return _context.Books.ToList();
        }

        public Books Update(long id, Books books)
        {
            if (!Exists(id))
            {
                return new Books();
            }
            
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            books.Id = id;

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(books);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return books;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}