//Реализуйте операторы неявного приведения из long,int,byt в Bits.
namespace Home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long a = 20;
            var bits = (Bits)a;
            Console.WriteLine(bits.Value);

            int b = 50;
            var bits1 = (Bits)b;
            Console.WriteLine(bits1.Value2);

            byte d = 70;
            var bits2 = (Bits)d;
            Console.WriteLine(bits2.Value3);

        }
    }

}

