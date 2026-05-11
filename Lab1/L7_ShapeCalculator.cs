/*
3. A shape calculator system can be built using an interface IShape with a method GetArea(). 
Classes like Circle and Rectangle implement this interface and calculate area using their respective formulas. 
In the main method, objects are created using the interface reference and the area is displayed. 
This shows how interfaces enforce a common structure while allowing different implementations.
*/

using System;

namespace Lab1
{
    public interface IShape
    {
        double GetArea();
        string GetShapeName();
    }

    class L7_Circle : IShape
    {
        private double _radius;
        public L7_Circle(double radius) => _radius = radius;

        public double GetArea() => Math.PI * _radius * _radius;
        public string GetShapeName() => "Circle";
    }

    class L7_Rectangle : IShape
    {
        private double _width;
        private double _height;
        public L7_Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea() => _width * _height;
        public string GetShapeName() => "Rectangle";
    }
}
