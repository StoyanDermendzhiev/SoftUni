using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal defualtPrice = 3.5M;
        private const double defualtMilliliters = 50;

        public Coffee(string name, double caffeine) 
            : base(name, defualtPrice, defualtMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
