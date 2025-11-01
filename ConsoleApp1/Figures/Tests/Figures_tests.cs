using NUnit.Framework;

public class Tests
{
    private readonly IShape sphere = new Sphere(5);
    private readonly IShape cube = new Cube(3);
    private readonly IShape cylinder = new Cylinder(2, 5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(54).Within(0.001));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(27).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(87.9646).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(62.8318).Within(0.001));
    }

    [Test]
    public void TestSphereWithNegativeRadiusThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Sphere(-5));
    }

    [Test]
    public void TestCubeWithZeroSideThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Cube(0));
    }

    [Test]
    public void TestCylinderWithNegativeHeightThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Cylinder(2, -5));
    }

}