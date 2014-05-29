using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class CustomerTrans : Repository<CustomerTrans>
    {
        public int customerid;
        public double amount;
        public DateTime transdate;
        public string description;

        public CustomerTrans()
        {

        }

        public CustomerTrans(DataRow dr)
        {
            customerid = Convert.ToInt32(dr["customerid"]);
            amount = Convert.ToDouble(dr["amount"]);
            transdate = Convert.ToDateTime(dr["transdate"]);
            description = dr["description"].ToString();
        }


        public void Save(CustomerTrans entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerTrans entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(CustomerTrans entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerTrans entiy)
        {
            throw new NotImplementedException();
        }

        public CustomerTrans GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CustomerTrans> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
