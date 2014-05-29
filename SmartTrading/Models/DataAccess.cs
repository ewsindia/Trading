using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTrading.Helper;
using System.Data;

namespace SmartTrading.Models
{
    public class DBItemMaster
    {
        public static int insert(ItemMaster itemMaster)
        {
            string query = String.Format("insert into item_master (id,name,type1,type2,height,width,weight,unit,currentqty,minqty,maxqty,saleqty,purchesrate,salerate,vat,otherspacification1,otherspacification2,description) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", itemMaster.id, itemMaster.name, itemMaster.type1, itemMaster.type2, itemMaster.height, itemMaster.width, itemMaster.weight, itemMaster.unit, itemMaster.currentqty, itemMaster.minqty, itemMaster.maxqty, itemMaster.saleqty, itemMaster.purchesrate, itemMaster.salerate, itemMaster.vat, itemMaster.otherspacification1, itemMaster.otherspacification2,itemMaster.description);
            return MySqlGeneralFunction.ExecuteNonQuery(query);
        }

        public static int update(ItemMaster itemMaster)
        {
            string query = String.Format("update item_master set name='{0}',type1='{1}',type2='{2}',height='{3}',weight='{4}',width='{5}',unit='{6}',currentqty='{7}',minqty='{8}',maxqty='{9}',saleqty='{10}',purchesrate='{11}',salerate='{12',vat='{13}',otherspacification1='{14}',otherspacification2='{15}',description='{16}' where id={0}", itemMaster.name, itemMaster.type1, itemMaster.type2, itemMaster.height, itemMaster.width, itemMaster.weight, itemMaster.unit, itemMaster.currentqty, itemMaster.minqty, itemMaster.maxqty, itemMaster.saleqty, itemMaster.purchesrate, itemMaster.salerate, itemMaster.vat, itemMaster.otherspacification1, itemMaster.otherspacification2, itemMaster.description);
            return MySqlGeneralFunction.ExecuteNonQuery(query);
        }

        public static ItemMaster getById(int id)
        {
            string query = String.Format("select * from item_master where id={0}", id);
            DataSet ds = MySqlGeneralFunction.ExecuteDataset(query);
            ItemMaster msgItemMaster = null;
            if (ds.Tables[0].Rows.Count == 0)
            return msgItemMaster;
            DataRow dr = ds.Tables[0].Rows[0];
            msgItemMaster = new ItemMaster(dr);
            return msgItemMaster;
        }
    }
}
