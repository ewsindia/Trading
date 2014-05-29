using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SmartTrading.Models;
namespace SmartTrading.Models
{
    public class SaleMaster :Repository<SaleMaster>
    {
        int billid;
        int itemid;
        double salerate;
        double purchesrate;
        int qty;
        double vat;
        double lbt;
        int billtype;
        public SaleMaster()
        {

        }
        public SaleMaster(DataRow dr)
        {
        }
        public void Save(SaleMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SaleMaster entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(SaleMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SaleMaster entiy)
        {
            throw new NotImplementedException();
        }

        public SaleMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SaleMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
