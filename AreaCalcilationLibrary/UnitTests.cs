using Xunit;

namespace AreaCalculationLibrary;

public class UnitTests
{
	[Fact]
	public void CreateShape_CircleFactory_ReturnNewCircle()
	{
		var circlefactory = new CircleFactory();

		IShape circle = circlefactory.CreateShape(5);

		Assert.NotNull(circle);
		Assert.IsType<Circle>(circle);
		Assert.Equal(Math.PI * 25, circle.GetArea());
	}

	[Fact]
	public void CreateShape_TriangleFactory_ReturnNewTriangle()
	{
		var trianglefactory = new TriangleFactory();

		IShape triangle = trianglefactory.CreateShape(3, 4, 5);

		Assert.NotNull(triangle);
		Assert.IsType<Triangle>(triangle);
		Assert.Equal(6, triangle.GetArea());
	}

	[Fact]
	public void CalculateArea_Circle_ReturnCorrectArea()
	{
		var circle = new Circle(5);
		var shapearea = new ShapeArea();

		var result = shapearea.GetArea(circle);

		Assert.Equal(Math.PI * 25, result);
	}

	[Fact]
	public void CalculateArea_Triangle_ReturnCorrectArea()
	{
		var triangle = new Triangle(3, 4, 5);
		var shapearea = new ShapeArea();

		var result = shapearea.GetArea(triangle);

		Assert.Equal(6, result);
	}

	[Fact]
	public void IsRightTriangle_True()
	{
		var triangle = new Triangle(3, 4, 5);

		var result = triangle.IsRightTriangle();

		Assert.True(result);
	}

	[Fact]
	public void IsRightTriangle_False()
	{
		var triangle = new Triangle(5, 13, 12);

		var result = triangle.IsRightTriangle();

		Assert.False(result);
	}
}

