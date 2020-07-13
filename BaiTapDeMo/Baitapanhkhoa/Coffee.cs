using System;
using System.Collections.Generic;
using System.Text;

namespace Baitapanhkhoa
{
    class Coffee
    {
      public  Dictionary<int, Table> Tables = new Dictionary<int, Table>(0);


      public void NewwOrder(Table id)
        {
            Tables.Add(id.Tableid, id);
        }
        public void UpdateOrder(int id,OrderDetail ed)
        {
            Tables[id].OrderDetails.Add(ed);
        }
        public void CancelOrder(int id)
        {
            Tables.Remove(id);
        }
        public void Search(int id)
        {
            foreach(Table pb in Tables.Values)
            {
                if (pb.Tableid.Equals(id))
                {
                    Console.WriteLine(pb.ShowInfo(););
                }
                else
                {
                    Console.WriteLine("Invalid table");
                }
            }
            
        }
        public void Pay(int id)
        {
            Tables[id].EndTime = DateTime.Now.ToString();
            Console.WriteLine(Tables[id].ShowInfo(););
        }
        public bool Check(int id)
        {
            foreach(int pb in Tables.Keys)
            {
                if (pb.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
