using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class CustomerCreditIntrest :Repository<CustomerCreditIntrest>
    {
        public int customerid;
        public int billid;
        public double intrestamount;
        public DateTime addeddate;

        public CustomerCreditIntrest()
        {

        }

        public CustomerCreditIntrest(DataRow dr)
        {
            customerid = Convert.ToInt32(dr["customerid"]);
            billid = Convert.ToInt16(dr["billid"]);
            if (!Convert.IsDBNull(dr["intrestamount"]))
                intrestamount = Convert.ToDouble(dr["intrestamount"]);
            if (!Convert.IsDBNull(dr["addeddate"]))
                addeddate = Convert.ToDateTime(dr["addeddate"]);
        }

        public void Save(CustomerCreditIntrest entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerCreditIntrest entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(CustomerCreditIntrest entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerCreditIntrest entiy)
        {
            throw new NotImplementedException();
        }

        public CustomerCreditIntrest GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerCreditIntrest> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
