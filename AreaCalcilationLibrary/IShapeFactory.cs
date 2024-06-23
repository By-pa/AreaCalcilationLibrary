namespace AreaCalculationLibrary;

public interface IShapeFactory
{
	public IShape CreateShape(params int[] shape);
}
