using System.Xml.Serialization;
class Circle : Shape{
    private double _radius = 4;

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}