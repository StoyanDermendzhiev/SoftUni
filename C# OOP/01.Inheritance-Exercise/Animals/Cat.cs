﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        private const string sound = "Meow meow";

        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {
        }

        public override string Sound => sound;
    }
}
