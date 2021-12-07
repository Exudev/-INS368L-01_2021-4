using System;

namespace KataVectorsandAngles
{
   public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class Vector
        {
           private int _posx;
           private int _posy; 
          public Vector(int posx, int posy)
            {
                this._posx = posx;
                this._posy = posy;

            }
            public double Magnitude()
            {
                double result = Math.Sqrt(Math.Pow(this._posx, 2) + Math.Pow(this._posy,2));
                return result;
            }
            public double DotProduct(Vector vector)
            {
                double result = (this._posx * vector._posx) + (this._posy * vector._posy);

                return result;
            
            }
            public double AngleBetween(Vector vector)
            {
                double result = Math.Acos((DotProduct(vector)) / ((this.Magnitude()) * (vector.Magnitude())));
                return result;
            }



        }
       
    }
}
