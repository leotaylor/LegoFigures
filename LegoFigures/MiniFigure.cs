using LegoFigures.Heads;
using LegoFigures.Torso;
using LegoFigures.Legs;
using System;

namespace LegoFigures
{
    class MiniFigure
    {
        private readonly HeadBase _head;
        private readonly TorsoBase _torso;
        private readonly Legs.Legs _legs;

        public string Name { get; }
        public string Description
        {
            get
            {
                return $"{(_head.HasHair ? "Hairy" : "Bald")} {_torso.Color} {_torso.NumberOfArms} armed thing.";
            }
        }

        public MiniFigure(string name, HeadBase head, TorsoBase torso, Legs.Legs legs )
        {
            Name = name;
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Karate(MiniFigure target)
        {
            _legs.Kick(target);
        }

        public void Greet()
        {
            _head.Talk();
            _torso.Wave();
        }

        public void TakeABreak()
        {
            _head.Eat();
            //if (_torso is BirdTorso)
            //{
            //    var birdTorso = (BirdTorso)_torso;
            //    birdTorso.Fly();
            // }
            //else (_torso is ReptilianTorso) {
            //    var reptilianTorso = (ReptilianTorso)_torso;
            //    reptilianTorso.Dance();
            //}

            switch (_torso)
            {
                case BirdTorso bird:
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile:
                    reptile.Dance();
                    break;
                case TorsoBase boringTorso:
                    Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms} arms.");
                    break;
            }
        }
    }
}
