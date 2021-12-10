using System;

namespace TemperatureApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            
        }
        //Clase y constructor
        public class Temperature
        {
            private string _type;
            private double _grades;
            public Temperature(string type, double grades)
            {
                this._type = type;
                this._grades = grades;
            }
            //Conversiones desde Fah
            public static double FahToKel(Temperature temp)
            {
                double kelvin = (temp._grades-32) * 5 / 9 + 273.15;
                return kelvin;
            }
            public static double FahToCel(Temperature temp)
            {
                double cel = (temp._grades - 32) * 5 / 9;
                return cel;
            }
            //Conversiones desde Cel
            public static double CelToKel(Temperature temp)
            {
                double kelvin = temp._grades + 273.15;
                return kelvin;
            }
            public static double CelToFah(Temperature temp)
            {
                double Fah = (temp._grades * 9 / 5) + 32;
                return Fah;
            }
            //Conversiones desde Kel
            public static double KelToCel(Temperature temp)
            {
                double cel = temp._grades - 273.15;
                return cel;
            }
            public static double KelToFah(Temperature temp)
            {
                double fah = (temp._grades - 273.15) * 9 / 5 + 32;
                return fah;
            }
        }
    }
}
