using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class WarehouseTransfer : Repository<WarehouseTransfer>
    {
        int itemid;
        int qty;
        int fromwarehouseid;
        int towarehouseid;
        DateTime transferdate;
        public WarehouseTransfer()
        {
        }
        public WarehouseTransfer(DataRow dr)
        {
        }



        public void Save(WarehouseTransfer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(WarehouseTransfer entity)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(WarehouseTransfer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WarehouseTransfer entiy)
        {
            throw new NotImplementedException();
        }

        public WarehouseTransfer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WarehouseTransfer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
