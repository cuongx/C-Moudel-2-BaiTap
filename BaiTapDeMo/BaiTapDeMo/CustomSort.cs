using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BaiTapDeMo
{
    class CustomSort : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((Product)x).Names, ((Product)y).Names);
        }
    }
}
