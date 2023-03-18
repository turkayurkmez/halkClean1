// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Rectangle rectangle = new Rectangle
//{
//    Width = 10,
//    Height = 5
//};

//Console.WriteLine(rectangle.GetArea());

//Square square = new Square
//{
//    Width = 10
//};
//Console.WriteLine(square.GetArea());

var rectangle = RectangleFactory.CreateRectangle(5, 10);


Console.WriteLine(rectangle.GetArea());


public static class RectangleFactory
{
    public static IArea CreateRectangle(int unit1, int unit2 = 1)
    {
        //bir şekilde....
        if (unit2 != 1)
        {
            return new Rectangle() { Width = unit1, Height = unit2 };
        }
        else
        {
            return new Square() { UnitLength = unit1 };
        }
    }
}

public interface IArea
{
    double GetArea();
}
public class Rectangle : IArea
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public double GetArea() => Width * Height;
}

public class Square : IArea //: Rectangle
{
    //public override int Height { get => base.Height; set { base.Height = value; base.Width = value; } }
    //public override int Width { get => base.Width; set { base.Height = value; base.Width = value; } }

    public int UnitLength { get; set; }

    public double GetArea()
    {
        return Math.Pow(UnitLength, 2);
    }
}