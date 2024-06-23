namespace AreaCalculationLibrary;

public class Triangle(int _side1, int _side2, int _side3) : Shape
{
	public override double GetArea()
	{
		var semiPerimeter = (_side1 + _side2 + _side3) / 2;

		return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
	}

	public bool IsRightTriangle()
	{
		var sides = new int[] { _side1, _side2, _side3 };
		Array.Sort(sides);

		return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
	}
}
