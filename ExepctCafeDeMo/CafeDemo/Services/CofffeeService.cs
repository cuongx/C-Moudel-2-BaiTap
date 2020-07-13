using CafeDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CafeDemo.Services
{
    class CofffeeService
    {
        public Data data;
        private string path;
        private string databasename;
        private string fullpath => @$"{path}\{databasename}";
       public CofffeeService(string _path,string _databasename)
        {
            data = new Data()
            {
                Tables = new List<Table>()
            };
            path = _path;
            databasename = _databasename;
            ReadWriteService<Data>.ReadData(fullpath);
        }
        public bool NewOrder(Table table)
        {
            try
            {
                data.Tables.Add(table);
                ReadWriteService<Data>.WriteData(fullpath,data);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public void UpdeteOrder(string id,List<OrderDetails> orderDetails,string Name)
        {
            var index = Check(id);
            if (index != null)
            {
                foreach (var table in orderDetails)
                {


                    foreach (var iteam in orderDetails)
                    {
                        if (iteam.name.Equals(table.name))
                        {

                        }
                    }               
            }
        }

        public Table Check(string id)
        {
            foreach(var iteam in data.Tables)
            {
                if(iteam.tableid.Equals(id)&& !iteam.ispaid)
                {
                    return iteam;
                }
            }
            return null;
        }
        
        
    }
}
