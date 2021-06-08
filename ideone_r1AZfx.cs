using System;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] data = 
            {
                28,03,00,233,00,00,00,114,
                00,00,12,160,25,66,230,04,
                225,72,40,195,105,242,38,249,
                00,00,00,00,00,00,00,00,
                225,72,40,208,41,242,12,33,
                225,72,40,208,41,242,52,101
            };
            DateTime T1 = Convert(data, 16);
            DateTime T2 = Convert(data, 32);
            DateTime T3 = Convert(data, 40);
            DateTime T4 = new DateTime(2019, 10, 9, 16, 37, 29,229);
            long Theta = (long)Math.Round(((T2.Ticks - T1.Ticks) + (T3.Ticks - T4.Ticks)) / 2.0);
            T4 = T4.AddTicks(Theta);
            Console.WriteLine(Theta);
            Console.WriteLine(T1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine(T2.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine(T3.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine(T4.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        static DateTime Convert(byte[] data, int index)
        {
            ulong nguyen = 0, le = 0;
            for(int i = 0; i < 4; i++)
            {
                nguyen += (ulong)data[index + i] << (8 * (3 - i));
            }
            index += 4;
            for (int i = 0; i < 4; i++)
            {
                le += (ulong)data[index + i] << (8 * (3 - i));
            }
            DateTime dt = new DateTime(1900, 1, 1, 7, 0, 0, 0);
            dt = dt.AddMilliseconds(nguyen * 1000 + le * 1000 / UInt32.MaxValue);
            return dt;
        }

        
    }
}
