using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class WarehoseMaster : Repository<WarehoseMaster>
         
    {
        int id;
        string  name;
        string tal;
        string dist;
        string city;
        string address1;
        string address2;
        string phone1;
        string phone2;
        long mobile;

        public WarehoseMaster()
        {
        }
        public WarehoseMaster(DataRow dr)
        {
        }
        public void Save(WarehoseMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Update(WarehoseMaster entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(WarehoseMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WarehoseMaster entiy)
        {
            throw new NotImplementedException();
        }

        public WarehoseMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WarehoseMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
