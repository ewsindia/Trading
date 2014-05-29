using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SmartTrading.Models;
using SmartTrading.Helper;
namespace SmartTrading.Models
{
    class VendorMaster :Repository<VendorMaster>

    {

        public VendorMaster()
        {
        }

        public VendorMaster(DataRow dr)
        {
        }
        public void Save(VendorMaster entity)

        {
            
        }

        public void Update(VendorMaster entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(VendorMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(VendorMaster entiy)
        {
            throw new NotImplementedException();
        }

        public VendorMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<VendorMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
