using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SmartTrading.Helper;

namespace SmartTrading.Models
{
    public class ItemMaster
    {
        public int id;
        public string name;
        public int type1;
        public int type2;
        public double height;
        public double width;
        public double weight;
        public int unit;
        public int currentqty;
        public int minqty;
        public int maxqty;
        public int saleqty;
        public double purchesrate;
        public double salerate;
        public double vat;
        public string otherspacification1;
        public string otherspacification2;
        public string description;
        public int saletype { get; set; }

        public ItemMaster()
        {

        }

        public ItemMaster(DataRow dr)
        {
            fillObj(dr);

        }
        private void  fillObj(DataRow dr)
        {
            id = Convert.ToInt32(dr["id"]);
            if (!Convert.IsDBNull(dr["name"]))
                name = dr["name"].ToString();
            if (!Convert.IsDBNull(dr["type1"]))
                type1 = Convert.ToInt32(dr["type1"]);
            if (!Convert.IsDBNull(dr["type2"]))
                type2 = Convert.ToInt32(dr["type2"]);
            if (!Convert.IsDBNull(dr["height"]))
                height = Convert.ToDouble(dr["height"]);
            if (!Convert.IsDBNull(dr["width"]))
                width = Convert.ToDouble(dr["width"]);
            if (!Convert.IsDBNull(dr["weight"]))
                weight = Convert.ToDouble(dr["weight"]);
            if (!Convert.IsDBNull(dr["unit"]))
                unit = Convert.ToInt32(dr["unit"]);
            currentqty = Convert.ToInt32(dr["currentqty"]);
            minqty = Convert.ToInt32(dr["minqty"]);
            maxqty = Convert.ToInt32(dr["maxqty"]);
            saleqty = Convert.ToInt32(dr["saleqty"]);
            if (!Convert.IsDBNull(dr["purchesrate"]))
                purchesrate = Convert.ToInt32(dr["purchesrate"]);
            if (!Convert.IsDBNull(dr["salerate"]))
                salerate = Convert.ToInt32(dr["salerate"]);
            vat = Convert.ToInt32(dr["vat"]);
            if (!Convert.IsDBNull(dr["otherspacification1"]))
                otherspacification1 = dr["otherspacification1"].ToString();
            if (!Convert.IsDBNull(dr["otherspacification2"]))
                otherspacification2 = dr["otherspacification2"].ToString();
            description = dr["description"].ToString();
            saletype =Convert.ToInt16(  dr["saletype"]);
        }
        public void Save()
        {
            string strtype1="null",strtype2="null",strunit="null",strheight="null",strweight="null",strwidth="null";
            if (type1 != 0)
                strtype1 = type1.ToString();
            if (type2 != 0)
                strtype2 = type2.ToString();
            if (unit != 0)
                strtype1 = unit.ToString();
            if (height != 0)
                strheight = height.ToString();
            if (width != 0)
                strwidth = width.ToString();
            if (weight != 0)
                strweight = weight.ToString();
            string query = String.Format("insert into item_master (name,type1,type2,height,width,weight,unit,currentqty,minqty,maxqty,saleqty,purchesrate,salerate,vat,otherspacification1,otherspacification2,description,saletype) values ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},'{14}','{15}','{16}',{17})", name, strtype1, strtype2, strheight, strwidth, strweight, strunit, currentqty, minqty, maxqty, saleqty, purchesrate, salerate, vat, otherspacification1, otherspacification2, description, saletype);
            MySqlGeneralFunction.ExecuteNonQuery(query);
        }

        public void Update()
        {
            string query = String.Format("update item_master set name='{0}',type1={1},type2={2},height={3},weight={4},width={5},unit={6},currentqty='{7}',minqty='{8}',maxqty='{9}',saleqty='{10}',purchesrate='{11}',salerate='{12',vat='{13}',otherspacification1='{14}',otherspacification2='{15}',description='{16}',saletype={17} where id={18}", name, type1, type2, height, width, weight, unit, currentqty, minqty, maxqty, saleqty, purchesrate, salerate, vat, otherspacification1, otherspacification2, description, saletype, id);
            fillObj(MySqlGeneralFunction.ExecuteDataRow(query));
        }

        public void SaveOrUpdate(ItemMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ItemMaster entiy)
        {
            throw new NotImplementedException();
        }

        public ItemMaster GetById(long id)
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
        

        

        public IList<ItemMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
