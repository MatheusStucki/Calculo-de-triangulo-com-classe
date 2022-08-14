using System;
namespace Criação_de_classes_com_3_atributos {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
          
        }
    }
}
