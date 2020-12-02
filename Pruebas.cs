//Una clase que se encargue de realizar pruebas sobre la primer clase, y que valide que los cálculos se realicen correctamente

using System;
using NUnit.Framework;

namespace Areas
{
    // Agregar atributo para indicar que es una clase con pruebas
    [TestFixture]
    class Pruebas
    {

        [Test]
        [TestCase(TestName = "Cálculo de área de cuadrado")]

        public void AreaCuadradoTest() 
        {
            //CalculosAreas calculo = new CalculosAreas();
            int lado1Cuadrado = 5;

            string result = CalculosAreas.CuadradoArea(lado1Cuadrado); 
            Assert.That(result, Is.EqualTo("25"));

        }


        [Test]
        [TestCase(TestName = "Cálculo de área de rectángulo")]

        public void AreaRectanguloTest() 
        {
            //CalculosAreas calculo = new CalculosAreas();

            int lado1Rectangulo = 5;
            int lado2Rectangulo = 10;

            string result = CalculosAreas.RectanguloArea(lado1Rectangulo, lado2Rectangulo);
            Assert.That(result, Is.EqualTo("50"));
        }


        [Test]
        [TestCase(TestName = "Cálculo de área de triángulo")]

        public void AreaTrianguloTest() 
        {
            int baseTriangulo = 2;
            int alturaTriangulo = 5;

            string result = CalculosAreas.TrianguloArea(baseTriangulo, alturaTriangulo);
            
            Assert.That(result, Is.EqualTo("5"));
        } 

        [Test]
        [TestCase(TestName = "Cálculo de área de círculo")]
        public void AreaCirculoTest() 
        {
            double piConstante = 3.1416;
            double radioCirculo = 6;

            string result = CalculosAreas.CirculoArea(piConstante, radioCirculo);
            Assert.That(result, Is.EqualTo("113.0976"));
        }

        [Test]
        [TestCase(TestName = "Cálculo de área de pentágono")]
        public void AreaPentagonoTest() 
        {
            double apotema = 5;
            double perimetro = 20;

            string result = CalculosAreas.PentagonoArea(apotema, perimetro);
            Assert.That(result, Is.EqualTo("50"));
        }

    }
}
