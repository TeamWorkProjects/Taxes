using System;
using System.Collections.Generic;
using System.Text;

namespace taxes.services.Repository
{
    public interface IRepository <T> where T: class
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(object id);
        T GetById(object id);
    }
}
