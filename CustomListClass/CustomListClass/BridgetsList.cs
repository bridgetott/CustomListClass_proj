﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomList
{
    public class BridgetsList<T>
    {
        //member variable

        private int count;
        private int capacity;

        private T[] _items;

        public int Count 
        {
            get
            {
                return count;
            }
        }

        ////constructor
        public BridgetsList()
        {

            count = 0;
            capacity = 4;
            _items = new T[capacity];

        }

        //member methods
        public void Add(T item)
        {
            // put the index in the items
        }
    }
}
