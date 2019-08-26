using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QuanLySDT
{
    public abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String newphone);
        public abstract void SearchPhone(String name);
        public abstract void sort();

    }

}
