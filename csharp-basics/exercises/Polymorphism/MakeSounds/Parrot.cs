using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Parrot : ISound
    {
        private string sound;

        public Parrot(string sound)
        {
            this.sound = sound;
        }
        
        public void PlaySound()
        {
            Console.WriteLine(sound);
        }
    }
}
