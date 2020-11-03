using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            long Ganzzahl64Bit; // -9 Trillionen bis +9 Trillionen
            ulong Ganzzahl64Bit; // 0 bis +18 Trillionen

            int Ganzzahl32Bit; // -2,14 Milliarden bis + 2,14 Milliarden
            uint Ganzzahl32BitPositiv; // 0 bis +4,29 Milliarden

            short Ganzzahl16Bit; // -32 tausend bis +32 tausend
            ushort Ganzzahl16Bit; // 0 bis 65 tausend

            sbyte Ganzzahl8Bit; // -128 bis +127
            byte GanzzahlPositiv; // 0 bis 255

            /////////////////////////////////////////////////////////////

            float Gleitkommazahl32Bit; // ca 6 Stellen genau
            double Gleitkommazahl64Bit; // ca 15 Stellen genau
            decimal Gleitkommazahl128Bit; // ca 30 Stellen genau

            ////////////////////////////////////////////////////////////

            bool JaOderNein; // exakt zwei Werte. true (1) false (0)

            ////////////////////////////////////////////////////////////

            byte AktiveOptionen = (byte)(MyEnum.A | MyEnum.D);




            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        } // ende Main
        
        enum MyEnum
        {
            A = 1,
            B = A*2,
            C = B*2,
            D = C*2
        }
    }
}
