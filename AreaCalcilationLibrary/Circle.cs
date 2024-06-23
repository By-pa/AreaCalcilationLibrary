namespace AreaCalculationLibrary;

public class Circle(int _radius) : Shape
{
	public override double GetArea()
	{
		return Math.PI * Math.Pow(_radius, 2);
	}
}

