using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Radio : ISound
    {
        private string _sound;

        public Radio(string sound)
        {
            _sound = sound;
        }

        public void PlaySound()
        {
            Console.WriteLine(_sound);
        }
    }
}
