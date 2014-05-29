using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class PurchesBill : Repository<PurchesBill>
    {
        int id;
        int vendorid;
        string billno;
        double billamount;

        DateTime billingdate;

        public PurchesBill()
        {
        }
        public PurchesBill(DataRow dr)
        {
        }
        public void Save(PurchesBill entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PurchesBill entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(PurchesBill entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PurchesBill entiy)
        {
            throw new NotImplementedException();
        }

        public PurchesBill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PurchesBill> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
