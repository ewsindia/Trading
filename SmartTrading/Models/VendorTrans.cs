using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    class VendorTrans :Repository<VendorTrans>
    {
        int vendorid;
        double amount;
        DateTime transdate;
        string description;
        public VendorTrans()
        {
        }
        public VendorTrans(DataRow dr)
        {

        }


        public void Save(VendorTrans entity)
        {
            throw new NotImplementedException();
        }

        public void Update(VendorTrans entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(VendorTrans entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(VendorTrans entiy)
        {
            throw new NotImplementedException();
        }

        public VendorTrans GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<VendorTrans> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
