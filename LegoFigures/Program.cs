using LegoFigures.Heads;
using LegoFigures.Torso;
using LegoFigures.Legs;
using System;

namespace LegoFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new NathanHead();
            var reptileBody = new ReptilianTorso();
            reptileBody.Color = "Brown";
            var babylegs = new BabyLegs();
            babylegs.length = 19;
            babylegs.MainColor = "purple";
            babylegs.ShoeColor = "yellow";

            var nathan = new MiniFigure("Nathan", head, reptileBody, babylegs);

            nathan.Greet();

            var head2 = new MartinHead();
            var birdbody = new BirdTorso();
            birdbody.Color = "pink";
            var manLegs = new Legs.Legs();
            manLegs.length = 10;
            manLegs.MainColor = "blue";
            manLegs.ShoeColor = "brown";

            var martin = new MiniFigure("Martin", head2, birdbody, manLegs);

            martin.Greet();

            nathan.Karate(martin);

            martin.TakeABreak();
            nathan.TakeABreak();
 

            Console.ReadLine();
        }
    }
}
