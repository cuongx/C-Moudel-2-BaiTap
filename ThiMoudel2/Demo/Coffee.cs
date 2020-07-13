using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Coffee
    {
        public Dictionary<int, Table>Tables = new Dictionary<int, Table>(0);
       
        public Coffee()
        {
            Tables.Add(0, new Table
            {
                Tableid = 0,
                Startime = DateTime.Now.ToString(),
                Endtime = DateTime.Now.ToString()
            }) ;
          
        }
        public void NewOrder(Table id)
        {
            Tables.Add(id.Tableid,id);
        }
        public void UpdateOrder(OrrderDetail newfile,int id)
        {
            Tables[id].OrrderDetails.Add(newfile);
        }
        public void Search(int id)
        {
            Tables[id].ShowInfo();
        }
        public void CancelOrder(int id)
        {
            Tables.Remove(id);
        }
        public void Pay(int id)
        {
            Tables[id].Endtime = DateTime.Now.ToString();
            Console.WriteLine(Tables[id].ShowInfo());
        }
        public  bool Check(int id)
        {
            foreach(var pb in Tables.Keys)
            {
                if (pb.Equals(id))
                {
                    return true;
                }
              
            }
            return false;
        }
      public void Show(int id)
        {
            foreach(Table pn in Tables.Values)
            {
                pn.ShowInfo();
            }
        }
    }
}
