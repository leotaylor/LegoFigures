using System;
using System.Collections.Generic;
using System.Text;

namespace LegoFigures.Torso
{
    class ReptilianTorso : TorsoBase
    {
        public string ScaleShape { get; set; }

        public void Dance()
        {
            Console.WriteLine($"*Breakdances vigorously in {Color}*");
        }

        public void Twist()
        {
            Console.WriteLine("*A little bit louder now.*");
        }
    }
}
