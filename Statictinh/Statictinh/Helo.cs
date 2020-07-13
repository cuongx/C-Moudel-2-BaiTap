using System;
using System.Collections.Generic;
using System.Text;

namespace Statictinh
{
    class Helo
    {
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public static int Count = 0;

        public Helo()
        {
            height = 100;
            weight = 200;
            Count++;
        }
        public static double LuyThua(int CoSo, int SoMu)
        {
            long KetQua = 1;
            for (int i = 0; i < SoMu; i++)
            {
                KetQua *= CoSo;
            }

            return KetQua;
        }
    }  
    }

