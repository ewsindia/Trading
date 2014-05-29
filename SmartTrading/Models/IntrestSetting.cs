using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class IntrestSetting : Repository<IntrestSetting>
    {
        public int id;
        public double rate;
        public int duration;

        public IntrestSetting()
        {

        }

        public IntrestSetting(DataRow dr)
        {
            id = Convert.ToInt32(dr["id"]);
            rate = Convert.ToDouble(dr["rate"]);
            duration = Convert.ToInt32(dr["duration"]);
        }

        public void Save(IntrestSetting entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IntrestSetting entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(IntrestSetting entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IntrestSetting entiy)
        {
            throw new NotImplementedException();
        }

        public IntrestSetting GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IntrestSetting> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
