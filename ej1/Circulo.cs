using System;
using System.Collections;
namespace DefaultNamespace;
    public class Circulo
    {
        private double radio; //creacion atributo

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public double GetPerimeter()
        {
            double perimetro = (radio * 2) * Double.Pi; 
            return perimetro;
        }

        public double GetArea() //crear funcion
        {
            double area = (radio * radio) * Double.Pi;
            return area;
        }
    }

   
    