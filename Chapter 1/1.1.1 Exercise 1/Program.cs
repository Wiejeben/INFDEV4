﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._1_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberVisitor visitor = new NumberVisitor();
            INumber myInt = new MyInt();

            myInt.Visit(visitor);

            Console.ReadKey();
        }
    }

    interface INumber
    {
        void Visit(INumberVisitor visitor);
    }

    interface INumberVisitor
    {
        void OnMyInt(MyInt input);
        void OnMyFloat(MyFloat input);
    }

    class NumberVisitor : INumberVisitor
    {
        public void OnMyFloat(MyFloat input)
        {
            Console.WriteLine("Found float");
        }

        public void OnMyInt(MyInt input)
        {
            Console.WriteLine("Found int");
        }
    }

    class MyInt : INumber
    {
        public void Visit(INumberVisitor visitor)
        {
            visitor.OnMyInt(this);
        }
    }

    class MyFloat : INumber
    {
        public void Visit(INumberVisitor visitor)
        {
            visitor.OnMyFloat(this);
        }
    }
}
