﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinKList
{
    class node
    {
        public int info;
        public node next;
        public node(int i,node n)
        {
            info = i;
            next = n;
        }
    }
    class stack
    {
        node top;
        public stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
