using System;
using System.Collections.Generic;

namespace Kontrollstrukturen
{

    class Program
    {

        static void Main(string[] args)
        {
            #region Bedingungen


            if (1 > 2) // testet einen ausdruck ob er TRUE oder FALSE ist
            {
                // wenn 1 grösser ist als 2
            }

            if (1 < 2)
            {
                // wenn 1 kleiner als 2
            }
            else
            {
                // in jedem anderen fall
            }

            if (1 < 2 && 3 > 2) // und verknüpfung
            {
                // wenn beide bedingungen erfüllt sind
            }

            if (1 < 2 || 3 > 2) // oder verknüpfung
            {

            }

            if (1 < 2)
            {
                if (3 > 2)
                {
                    // wenn beide bedingungen erfüllt sind
                }
                else
                {
                    // erste erfüllt, zweite aber nicht
                }
            }
            else
            {
                // erste bereits gescheitert
            }

            if (3 > 2 ||
                (1 < 3 && 2 == 2))
            {

            }

            int VariableA;

            //          ( bedingung     ? true : false)
            VariableA = (3 < 2 || 5 > 3 ? 5 : 3);
            #endregion

            #region Schleifen

            int Anfang = 0;

            while (Anfang < 10)
            {
                Anfang++;
            }

            do
            {
                Anfang--;
            } while (Anfang > 0); //wanna see me do it again?

            for (int counter = 0; counter < 10; counter++)
            {
            }


            for (; ; Anfang++)// die bereiche des for sind alle optional for(;;) ist gültig
            {
                if (Anfang > 20)
                {
                    break;
                }
            }

            List<int> ListOfNumbers = new List<int>();

            foreach (int item in ListOfNumbers)
            {

            }

            #endregion
        }

    }
}
