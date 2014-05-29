using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class Purches : Repository<Purches>
    {
        int  purchesinvoiceid;
        int itemid;
        int qty;
        double purchesrate;
        public Purches()
        {
        }
        public Purches(DataRow dr)
        {
        }
        public void Save(Purches entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Purches entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(Purches entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Purches entiy)
        {
            throw new NotImplementedException();
        }

        public Purches GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Purches> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
