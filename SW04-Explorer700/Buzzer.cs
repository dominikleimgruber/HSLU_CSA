﻿// ----------------------------------------------------------------------------
// CSA - C# in Action
// (c) 2020, Christian Jost, HSLU
// ----------------------------------------------------------------------------
using System;
using System.Threading;

namespace SW04_Explorer700
{
    public class Buzzer
    {

        public Buzzer(Pcf8574 pcf8574)
        {
            Pcf8574 = pcf8574;

            AppDomain.CurrentDomain.ProcessExit += delegate (Object o, EventArgs e) { pcf8574[7] = true; };
        }


        /// <summary>
        /// Schaltet den Buzzer ein-/aus bzw. liefert den Zustand ob er eingeschaltet (=true) ist.
        /// </summary>
        public bool Enabled
        {
            get => Pcf8574[7]; 
            set => Pcf8574[7] = !value;
        }


        /// <summary>
        /// Schaltet den Piepser für eine bestimmte Zeit ein und anschliessend wieder aus (Piepston)
        /// </summary>
        /// <param name="timeMs">Spieldauer in Millisekunden</param>
        public void Beep(int timeMs)
        {
            Enabled = true;
            Thread.Sleep(timeMs);
            Enabled = false;
        }
        
        public Pcf8574 Pcf8574 { get;}
    }
}
