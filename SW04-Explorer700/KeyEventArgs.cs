namespace SW04_Explorer700
{
    public class KeyEventArgs
    {
        public KeyEventArgs(Keys key)
        {
            Keys = key;
        }

        public Keys Keys { get; }
    }
}