using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class CompanyMaster : Repository<CompanyMaster>
    {
        public int id;
        public string name;
        public string line1;
        public string line2;
        public string signature;
        public string vatnumber;
        public string registrstionnumber;
        public string adminpassword;

        public CompanyMaster()
        {

        }

        public CompanyMaster(DataRow dr)
        {
            id = Convert.ToInt32(dr["id"]);
            name = dr["name"].ToString();
            line1 = dr["line1"].ToString();
            line2 = dr["line2"].ToString();
            if (!Convert.IsDBNull(dr["signature"]))
                signature = dr["signature"].ToString();
            if (!Convert.IsDBNull(dr["vatnumber"]))
                vatnumber = dr["vatnumber"].ToString();
            if (!Convert.IsDBNull(dr["registrstionnumber"]))
                registrstionnumber = dr["registrstionnumber"].ToString();
            adminpassword = dr["adminpassword"].ToString();
        }

        public void Save(CompanyMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CompanyMaster entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(CompanyMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CompanyMaster entiy)
        {
            throw new NotImplementedException();
        }

        public CompanyMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
