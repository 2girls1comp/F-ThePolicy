using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using GTA.Native;
using GTA;
using GTA.Math;
using System.Media;

namespace F___ThePolicy
{
    public class F___ThePolicy : Script
    {
        SoundPlayer soundPlayer = new SoundPlayer("./scripts/fthepolicy/thepolicy.wav"); //audio player
        int prevWantedLevel = 0;

        public F___ThePolicy()
        {
            Tick += onTick;
        }

        private void onTick(object sender, EventArgs e)
        {
            // when the wanted level switch from 0 to 1 stars
            if (prevWantedLevel == 0 && Game.Player.WantedLevel > 0)
            {
                Wait(4000);
                soundPlayer.Play(); //start playback of the .wav file
            }
            // when the wanted level goes back to zero
            else if (Game.Player.WantedLevel == 0)
            {
                soundPlayer.Stop(); //stop playback 
            }
            prevWantedLevel = Game.Player.WantedLevel;
        }
    }
}
