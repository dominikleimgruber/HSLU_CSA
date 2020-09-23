using System;
namespace SW02
{
    public class StringList
    {
        private string[] data;
        
        public StringList()
        {
            data = new string[0];
        }
        public StringList(int size)
        {
            this.data = new string[size];
        }

        public int Size
        {
            get { return data.Length; }
            set
            {
                data = new string[value];
                for (int i = 0; i < Data.Length; i++)
                {
                    Data[i] = "<empty>";
                }
            }
        }

        public string[] Data{ get;}

        public string this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }

    }
}
