using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEduardo
{
    class MainEduardo
    {

        static List<Figure> personas = new List<Figure>();
        public MainEduardo(float _base, float _altitude)
        {
        }

        public void showMenu()
        {
            // insert menu
            // while -> mientras no coloques la opcion de salida no sales del programa
            int option = 5;
            do {
                Console.WriteLine("<1>Register a figure");
                Console.WriteLine("<1>Register a figure");
                Console.WriteLine("<5>Salir");
                option = Int32.Parse(Console.ReadLine());
                executeOption(option);
            } while (option != 5);
        }

        private void executeOption(int option) {
            //if 1
            registerFigure();
            // if 2

        }

        private void registerFigure()
        {
           // crear otro menu para que elija el tipo de figura
        }

        private void executeOptionKindFigure()
        {
            //if 1
            registerTriangle();
            // if 2
        }

        private void registerTriangle() { 
            // base
            // guardas la base en un variable
            // solicitas la altura
            //guardas la altura
            // creas el triangulo con la base y la altura capturada
            // agregas a la lista de figuras
        }
    }
}
