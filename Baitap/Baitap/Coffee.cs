using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap
{
    class Coffee
    {
      public  Dictionary<int, Table> Tables = new Dictionary<int, Table>(0);

        public void NewOrder(Table newder)
        {
            Tables.Add(newder.TableId, newder);
        }
        public void UpdateOrder(OrderDetail newor,int id)
        {
            Tables[id].OrderDetails.Add(newor);
        }
        public void Search(int id)
        {
            Tables[id].ShowInfo();
        }
        public void Remove(int id)
        {
            Tables.Remove(id);
        }
        public void Pay(int id)
        {
            Tables[id].StarTime = DateTime.Now.ToString();
            Tables[id].ShowInfo();
        }
        public bool Check(int id)
        {
            foreach(int item in Tables.Keys)
            {
                if (item.Equals(id))
                {
                    Tables.ContainsKey(id);
                    return true;
                }
            }
            return false;
        }

    }
}
