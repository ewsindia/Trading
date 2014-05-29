using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class BillMaster : Repository<BillMaster>
    {
        public int id;
        public DateTime billdate;
        public int customerid;
        public double amount;
        public double discount;
        public int paytype;
        public double discountamount;

        public BillMaster()
        {

        }

        public BillMaster(DataRow dr)
        {
            id = Convert.ToInt16(dr["id"]);
            billdate = Convert.ToDateTime(dr["billdate"]);
            customerid = Convert.ToInt16(dr["customerid"]);
            amount = Convert.ToDouble(dr["amount"]);
            discount = Convert.ToDouble(dr["discount"]);
            discountamount = Convert.ToDouble(dr["discountamount"]);

        }

        public void Save(BillMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Update(BillMaster entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(BillMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BillMaster entiy)
        {
            throw new NotImplementedException();
        }

        public BillMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BillMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
