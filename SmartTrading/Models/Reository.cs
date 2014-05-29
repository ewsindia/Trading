using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartTrading.Models
{
    interface Repository<T>
    {
        void Save(T entity);
        void Update(T entity);
        void SaveOrUpdate(T entity);
        void Delete(T entiy);
        T GetById(int id);
        IList<T> GetAll();
    }
}
