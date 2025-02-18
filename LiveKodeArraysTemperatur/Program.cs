using System.Diagnostics.CodeAnalysis;

namespace LiveKodeArraysTemperatur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dayTemperatur = new int [8] { 7, 4, 5, 5, 5, 4, 4, 4};

            int dayTemperaturTotal = 0;
            //IM A NEW COMMENT
            double maxTemperatur = dayTemperatur[0];

            double minTemperatur = dayTemperatur[0];

            for (int i = 0; i < dayTemperatur.Length; i++)
            {
                dayTemperaturTotal += dayTemperatur[i];

                if (dayTemperatur[i] > maxTemperatur) //checker hele tiden om daytemp er højere end maxtemp hvis den er så ændre vi maxtemp til den nye værdi
                {
                    maxTemperatur = dayTemperatur[i];
                }
                if (dayTemperatur[i] < minTemperatur) //checker hele tiden om daytemp er højere end maxtemp hvis den er så ændre vi maxtemp til den nye værdi
                {
                    minTemperatur = dayTemperatur[i];
                }
            }
            Console.WriteLine("Gennemsnits temperaturen er " + dayTemperaturTotal / dayTemperatur.Length);
            Console.WriteLine("mindste temperaturen er " + minTemperatur + " og maks temperaturen er " + maxTemperatur);
        }
    }
}
