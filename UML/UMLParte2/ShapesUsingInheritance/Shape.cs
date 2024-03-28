namespace ShapeUsingInheritance;

using System;

public abstract class Shape
{
    public abstract double GetArea();
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

