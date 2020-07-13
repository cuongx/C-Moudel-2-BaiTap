using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaitapArrayListDemo
{
    class Custom : IComparer

    {
        public int Compare(object x, object y)
        {
          return string.Compare(((User)x).Name, ((User)y).Name);
        }
    }
}
