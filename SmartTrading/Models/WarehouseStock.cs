using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class WarehouseStock :Repository <WarehouseStock>
    {
        int  warehouseid;
        int itemid;
        int qty;
        public WarehouseStock()
        {
        }
        public WarehouseStock(DataRow dr)
        {

        }


        public void Save(WarehouseStock entity)
        {
            throw new NotImplementedException();
        }

        public void Update(WarehouseStock entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(WarehouseStock entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WarehouseStock entiy)
        {
            throw new NotImplementedException();
        }

        public WarehouseStock GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WarehouseStock> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
