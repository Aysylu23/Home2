using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    internal class Bits
    {
        public Bits(long a)
        {
            this.Value = a;
        }
        public Bits(int b)
        {
            this.Value2 = b;
        }

        public Bits(byte c)
        {
            this.Value3 = c;
        }
        public long Value { get; private set; } = 0;
        public int Value2 { get; private set; } = 0;
        public byte Value3 { get; private set; } = 0;


        public static explicit operator long(Bits a) => (long)a.Value;
        public static implicit operator Bits(long a) => new (a);

        public static explicit operator int(Bits b) => (int)b.Value2;
        public static implicit operator Bits(int b) => new (b);

        public static explicit operator byte(Bits c) => (byte)c.Value3;
        public static implicit operator Bits(byte c) => new (c);

    }
}
