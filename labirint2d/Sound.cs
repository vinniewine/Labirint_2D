﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace labirint2d
{
    public static class Sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.sound_key);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.sound_start);
        static SoundPlayer sound_win = new SoundPlayer(Properties.Resources.sound_win);
        static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }
        public static void sound_off()
        {
            sound_enabled = false;
        }

        public static void play_fail()
        {
            if(sound_enabled)
            sound_fail.Play();
        }
        public static void play_key()
        {
            if (sound_enabled)
                sound_key.Play();
        }
        public static void play_start()
        {
            if (sound_enabled)
                sound_start.Play();
        }
        public static void play_win()
        {
            if (sound_enabled)
                sound_win.Play();
        }
    }
}
