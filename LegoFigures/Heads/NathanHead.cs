﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Heads
{
    class NathanHead : HeadBase
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt n Peppa"; } }
        public string Texture { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I never get to eat");
        }
    }
}
