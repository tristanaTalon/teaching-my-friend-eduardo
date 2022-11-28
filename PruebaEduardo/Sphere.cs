using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEduardo
{
    class Sphere
    {
        private float _radius;

        private static int _dimension = 3;

        public Sphere(float _radius)
        {
            this._radius = _radius;
        }

        public void showArea() 
        {
            Console.WriteLine("Area: ", this.calculateArea());
        }

        private float calculateArea()
        {
            return (float)(4 *System.Math.PI*this._radius *2);
        }

        public float showVolume()
        {
            //return (float)(4 / 3 * System.Math.PI * this._radius * this._radius * this._radius);
            return (float)(4 / 3 * Math.PI * Math.PI * Math.Pow(this._radius,3));
        }
    }
}
