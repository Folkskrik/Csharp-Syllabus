using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Radio : ISound
    {
        private string sound;

        public Radio(string sound)
        {
            this.sound = sound;
        }

        public void PlaySound()
        {
            Console.WriteLine(sound);
        }
    }
}
