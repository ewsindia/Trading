using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SmartTrading.Helper;

namespace SmartTrading.Models
{
    public class CustomerMaster 
    {
        public int id;
        public string name;
        public string address1;
        public string address2;
        public string phone;
        public long mobile;
        public double balance;


        public CustomerMaster()
        {

        }

        public CustomerMaster(DataRow dr)
        {
            fillObj(dr);
        }
        private void fillObj(DataRow dr){
            id = Convert.ToInt32(dr["id"]);
            name = dr["name"].ToString();
            address1 = dr["address1"].ToString();
            if (!Convert.IsDBNull(dr["address2"]))
                address2 = dr["address2"].ToString();
            if (!Convert.IsDBNull(dr["phone"]))
                phone = dr["phone"].ToString();
            if (!Convert.IsDBNull(dr["mobile"]))
                mobile = Convert.ToInt64(dr["mobile"]);
            balance = Convert.ToDouble(dr["balance"]);
        }

        public void Save()
        {
            string query = String.Format("insert into customer_master (name,address1,address2,phone,mobile,balance) values('{0}','{1}','{2}','{3}',{4},{5})", name, address1, address2, phone, mobile, balance);
            MySqlGeneralFunction.ExecuteNonQuery(query);
           // query = "select * from customer_master where id=" + id;
            //DataRow dr = MySqlGeneralFunction.ExecuteDataRow(query);
           // fillObj(dr);
            
            
        }

        public void Update()
        {
            string query = String.Format("update customer_master set name='{1}', address1='{2}', address2='{3}', phone='{4}', mobile='{5}', balance='{6}' where id={0};select * from customer_master where id={0}",  id,  name,  address1,  address2,  phone,  mobile,  balance);
            //MySqlGeneralFunction.ExecuteNonQuery(query);
            
            DataRow dr = MySqlGeneralFunction.ExecuteDataRow(query);
            fillObj(dr);
        }

        public void SaveOrUpdate(CustomerMaster entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CustomerMaster entiy)
        {
            throw new NotImplementedException();
        }

        public CustomerMaster GetById(int id)
        {
            string query=String.Format("select * from customer_master where id={0}",id);
            DataRow dr = MySqlGeneralFunction.ExecuteDataRow(query);
            CustomerMaster obj = new CustomerMaster(dr);
            return  obj;

        }

        public IList<CustomerMaster> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
