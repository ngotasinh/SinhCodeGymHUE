using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Bai3.QLPhim
{
    public class CustomList : IEnumerable
    {
        private ArrayList MovieList;

        public ArrayList MovieList1 { get => MovieList; set => MovieList = value; }
        public void Add(IMovie movie)
        {

        }
    }
}
