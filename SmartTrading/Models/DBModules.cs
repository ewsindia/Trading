using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SmartTrading.Models
{
    public class ItemMasters
    {
        public int id;
        public string name;
        public int type1;
        public int type2;
        public double width;
        public double height;
        public double weight;       
        public int unit;
        public int currentqty;
        public int saleqty;
        public int minqty;
        public int maxqty;
        public int purchesrate;
        public int salerate;
        public string otherspacification1;
        public string otherspacification2;
        public string description;
        public double vat;       
        


        public ItemMasters()
        {
        }

        public ItemMasters(int _id, string _name, int _type1, int _type2, double _width, double _height, double _weight, int _unit, int _currentqty, int _saleqty, int _minqty, int _maxqty, int _purchesrate, int _salerate, string _otherspacification1, string _otherspacification2, string _description, double _vat)
        {
            id=_id;
            name=_name;
            type1=_type1;
            type2=_type2;
            width = _width;
            height = _height;
            weight=_weight;           
            unit = _unit;
            currentqty = _currentqty;
            saleqty = _saleqty;
            minqty=_minqty;
            maxqty=_maxqty;            
            purchesrate=_purchesrate;
            salerate=_salerate;
            otherspacification1 = _otherspacification1;
            otherspacification2 = _otherspacification2;
            description = _description;
            vat=_vat;            
            
       }

        public ItemMasters(DataRow dr)
        {
            id = Convert.ToInt16( dr["id"].ToString());
            name= dr["name"].ToString();
            type1=Convert.ToInt16( dr["type1"].ToString());
            type2=Convert.ToInt16( dr["type2"].ToString());
            width = Convert.ToDouble(dr["width"].ToString());
            height = Convert.ToDouble(dr["height"].ToString());
            weight=Convert.ToDouble(dr["weight"].ToString());           
            unit = Convert.ToInt16(dr["unit"].ToString());
            currentqty = Convert.ToInt16(dr["currentqty"].ToString());
            saleqty = Convert.ToInt16(dr["saleqty"].ToString());
            minqty=Convert.ToInt16( dr["minqty"].ToString());
            maxqty = Convert.ToInt16(dr["maxqty"].ToString());           
            purchesrate = Convert.ToInt16(dr["purchaesate"].ToString());
            salerate = Convert.ToInt16(dr["salerate"].ToString());
            otherspacification1 = dr["otherdescription1"].ToString();
            otherspacification2 = dr["otherdescription2"].ToString();
            description = dr["description"].ToString();
            vat = Convert.ToDouble(dr["vat"].ToString());           
            
        }       
}

   


}