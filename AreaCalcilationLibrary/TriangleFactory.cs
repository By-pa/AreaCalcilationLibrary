namespace AreaCalculationLibrary
{
	public class TriangleFactory : IShapeFactory
	{
		public IShape CreateShape(params int[] shape)
		{
			if (shape.Length != 3)
			{
				throw new Exception("Нужно 3 значения");
			}

			return new Triangle(shape[0], shape[1], shape[2]);
		}
	}
}
