using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEduardo
{
    class Triangle : Figure
    {
        private float _base;

        private float _altitude;

        private static int _dimension = 2;

        public Triangle(float _base, float _altitude) : base(_dimension)
        {
            this._base = _base;
            this._altitude = _altitude;
        }

        public void show()
        {
            Console.WriteLine("Base: " + this._base + " " + "Altitute: " + this._altitude);
        }

        public void showArea() 
        {
            Console.WriteLine("Area: ", this.calculateArea());
        }

        private float calculateArea()
        {
            return this._base * this._altitude / 2;
        }
    }
}
