//Una clase o clases que te permitan calcular áreas de polígonos: triángulo, cuadrado, rectángulo, pentágono y círculo

using System;

namespace Areas
{
    class CalculosAreas
    {
         // Triangulo

        // método con 2 datos dentro () y devuelve string
       public static string TrianguloArea(int laBase, int laAltura) { 
           
           int rAreaTriangulo = (laBase * laAltura) / 2;

           return rAreaTriangulo.ToString();
       }
       

       // Cuadrado
       public static string CuadradoArea(int lado1)
       {
           int rAreaCuadrado = lado1 * lado1;
           return rAreaCuadrado.ToString();
       }

       // Rectangulo
       public static string RectanguloArea(int lado1, int lado2)
       {
           int rAreaRectangulo = lado1 * lado2;
           return rAreaRectangulo.ToString();
       }

       // Círculo
       public static string CirculoArea(double pi, double radio) 
       {
           pi = 3.1416;
           double rAreaCirculo = (radio * radio) * pi;
           return rAreaCirculo.ToString();
       }

       //Pentágono
       public static string PentagonoArea(double apotema, double perimetro) 
       {
         
           double rAreaPentagono = (apotema * perimetro) * .5;
           return rAreaPentagono.ToString();
       }
       

       


    }
}