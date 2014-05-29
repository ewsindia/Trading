using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SmartTrading.Helper;

namespace SmartTrading.Models
{
    public class SingleFieldMaster 
    {
        public long id;
        public string name;
        public string type;
        public string description;
        public SingleFieldMaster()
        {
        }
        public SingleFieldMaster(DataRow dr)

        {
            fillObj(dr);
        }

        private void fillObj(DataRow dr){
            id=Convert.ToInt64( dr["id"]);
            name = dr["name"].ToString();
            type = dr["type"].ToString();
            if (!Convert.IsDBNull(dr["description"]))
                description = dr["description"].ToString();
        }
        public void Save()
        {
            string query = String.Format("insert into singlefieldmaster (name,type,description) values({0},'{1}','{2}')", name, type, description);
            MySqlGeneralFunction.ExecuteNonQuery(query);

        }

        public void Update()
        {
            string query = String.Format("update singlefieldmaster set name='{1}', type='{2}', description='{3}' from singlefieldmaster where id={0};select * from signlefieldmaster where id={0}", id, name, type, description);
            //MySqlGeneralFunction.ExecuteNonQuery(query);

            DataRow dr = MySqlGeneralFunction.ExecuteDataRow(query);
            fillObj(dr);
        }

        public void SaveOrUpdate(SingleFieldMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SingleFieldMaster entiy)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            string query = String.Format("select * from singlefieldmaster where id={0}", id);
            //MySqlGeneralFunction.ExecuteNonQuery(query);

            DataRow dr = MySqlGeneralFunction.ExecuteDataRow(query);
            fillObj(dr);
        }

        public IList<SingleFieldMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
