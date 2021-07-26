using System.Collections.Generic;
using RestAspNET5.Model.Base;

namespace RestAspNET5.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(long id, T item);
        void Delete(long id);
        bool Exists(long id);
    }
}