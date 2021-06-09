using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPad.MusicPad
{
    public class SoundPlayer : ISoundPlayer
    {

        private readonly IJSRuntime _jSRuntime;
        private const string JSFUNCTION = "playaudio";

        public SoundPlayer(IJSRuntime _jSRuntime)
        {
            this._jSRuntime = _jSRuntime;
        }

        public async Task Play(string sound, string pressedPadId)
        {
            if (string.IsNullOrEmpty(sound))
                return;

            await _jSRuntime.InvokeVoidAsync(JSFUNCTION, sound, pressedPadId);
        }
    }
}
