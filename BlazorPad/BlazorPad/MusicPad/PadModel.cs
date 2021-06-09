using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPad.MusicPad
{
    public class PadModel
    {

        public PadModel(string soundName, string soundLocation, string Key)
        {
            this.soundName = soundName;
            this.soundLocation = soundLocation;
            this.Key = Key;

        }

        public string Id => $"pad-{Key}";
        public string soundName { get; set; }
        public string soundLocation { get; set; }
        public string Key { get; set; }




    }

}
