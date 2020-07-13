using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Demo
{
    class Table : ITable
    {
        public int Tableid;
        public string Startime;
        public string Endtime;
        public long Sumtotal => Pay();

      public List<OrrderDetail> OrrderDetails = new List<OrrderDetail>(0);
       public string ShowInfo()
        {
            return $"{"\t"} {"\t"} Tableid {Tableid} Startime {Startime } EndTime {Endtime} {"\n"}  {Ordertail()} Sumtotal {Sumtotal}";
        }
        public long Pay()
        {
            long sum = 0;
            foreach(OrrderDetail pb in OrrderDetails)
            {
                sum += pb.Total;
            }
            return sum;
        }
        public string Ordertail()
        {
            string show = "";
            foreach(OrrderDetail pb in OrrderDetails)
            {
                show += pb.Show()+"\n";
            }
            return show;
        }
    }
}
