﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    class BaldHead : HeadBase
    {
        private readonly string _name; 
        public override bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }

        public BaldHead(string name)
        {
            _name = name; 
        }

        public override void Talk()
        {
            Console.WriteLine($"Hi, I'm {_name}");
            base.Talk();
        }

        public override void Eat()
        {
            Console.WriteLine("*Eats a Burrito*");
        }
    }
}
