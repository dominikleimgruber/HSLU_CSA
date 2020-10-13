// ----------------------------------------------------------------------------
// CSA - C# in Action
// (c) 2020, Christian Jost, HSLU
// ----------------------------------------------------------------------------

using Unosquare.RaspberryIO;
using Unosquare.WiringPi;

namespace SW04_Explorer700
{
    public class Explorer700
    {
        public Explorer700()
        {
            // Wiring-Pi für den Zugriff auf die Hardware initialisieren
            Pi.Init<BootstrapWiringPi>();
            Led1 = new LedGpio();
            Pcf8574 pc = new Pcf8574(0x20);
            Led2 = new LedI2C(pc);
            Buz = new Buzzer(pc);
            Joy = new Joystick(pc);
            Dis = new Display();
        }

        public LedBase Led1 { get; }
        public LedBase Led2 { get; }
        public Display Dis { get; }
        public Joystick Joy { get; }
        public Buzzer Buz { get; }
    }
}