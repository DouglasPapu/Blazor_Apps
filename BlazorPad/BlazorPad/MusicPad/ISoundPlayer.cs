using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPad.MusicPad
{
    interface ISoundPlayer
    {
        Task Play(string sound, string pressedPadId);
    }
}
