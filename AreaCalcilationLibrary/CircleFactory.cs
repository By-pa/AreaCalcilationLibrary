namespace AreaCalculationLibrary;

public class CircleFactory : IShapeFactory
{
	public IShape CreateShape(params int[] shape)
	{
		if (shape.Length > 1)
		{
			throw new Exception("Нужно одно число");
		}
		
		return new Circle(shape[0]);
	}
}
