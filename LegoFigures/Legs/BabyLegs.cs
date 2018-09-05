using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Legs
{
    class BabyLegs : Legs
    {
        public BabyLegs()
        {
            length = 10;
            HasPants = false;
        }

        public override void Walk()
        {
            if (length > 18)
            {
                Console.WriteLine($"The {MainColor} baby legs wobble-strutted around the playpen in {ShoeColor} shoes.");
            }
            else
            {
                Console.WriteLine($"The {MainColor} baby legs crawled around the playpen.");
            }
        }

        public override void Kick(MiniFigure miniFigure)
        {
            Console.WriteLine($"Baby legs kicked {miniFigure.Name}, the {miniFigure.Description}.");
        }
    }

    class Legs
    {
        public int length { get; set; } = 34;
        public bool HasPants { get; set; }
        public string ShoeColor { get; set; }
        public string MainColor { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine($"The {MainColor} walked around the office.");
        }

        public virtual void Kick(MiniFigure miniFigure)
        {
            Console.WriteLine($"The legs kicked {miniFigure.Name}, the {miniFigure.Description}.");
        }
    }
}


