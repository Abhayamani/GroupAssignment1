// ProductTests.cs
using NUnit.Framework;

[TestFixture]
public class ProductTests
{
    // Tests for ProductID
    [Test]
    public void ProductID_WhenSetWithinRange_ShouldBeSetCorrectly()
    {
        // Arrange
        int productId = 500;

        // Act
        var product = new Product(productId, "Test Product", 100, 50);

        // Assert
        Assert.That(product.ProductID, Is.EqualTo(productId));
    }

    [Test]
    public void ProductID_WhenSetAtMinimumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        int productId = 1;

        // Act
        var product = new Product(productId, "Test Product", 100, 50);

        // Assert
        Assert.That(product.ProductID, Is.EqualTo(productId));
    }

    [Test]
    public void ProductID_WhenSetAtMaximumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        int productId = 1000;

        // Act
        var product = new Product(productId, "Test Product", 100, 50);

        // Assert
        Assert.That(product.ProductID, Is.EqualTo(productId));
    }

    // Tests for ProductName
    [Test]
    public void ProductName_WhenSet_ShouldBeSetCorrectly()
    {
        // Arrange
        string productName = "Test Product";

        // Act
        var product = new Product(500, productName, 100, 50);

        // Assert
        Assert.That(product.ProductName, Is.EqualTo(productName));
    }

    // Tests for Price
    [Test]
    public void Price_WhenSetWithinRange_ShouldBeSetCorrectly()
    {
        // Arrange
        decimal price = 100m;

        // Act
        var product = new Product(500, "Test Product", price, 50);

        // Assert
        Assert.That(product.Price, Is.EqualTo(price));
    }

    [Test]
    public void Price_WhenSetAtMinimumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        decimal price = 1m;

        // Act
        var product = new Product(500, "Test Product", price, 50);

        // Assert
        Assert.That(product.Price, Is.EqualTo(price));
    }

    [Test]
    public void Price_WhenSetAtMaximumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        decimal price = 5000m;

        // Act
        var product = new Product(500, "Test Product", price, 50);

        // Assert
        Assert.That(product.Price, Is.EqualTo(price));
    }

    // Tests for Stock
    [Test]
    public void Stock_WhenSetWithinRange_ShouldBeSetCorrectly()
    {
        // Arrange
        int stock = 50;

        // Act
        var product = new Product(500, "Test Product", 100, stock);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(stock));
    }

    [Test]
    public void Stock_WhenSetAtMinimumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        int stock = 1;

        // Act
        var product = new Product(500, "Test Product", 100, stock);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(stock));
    }

    [Test]
    public void Stock_WhenSetAtMaximumBoundary_ShouldBeSetCorrectly()
    {
        // Arrange
        int stock = 1000;

        // Act
        var product = new Product(500, "Test Product", 100, stock);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(stock));
    }

    // Tests for IncreaseStock method
    [Test]
    public void IncreaseStock_WhenCalled_ShouldIncreaseStock()
    {
        // Arrange
        int initialStock = 50;
        int increaseAmount = 10;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.IncreaseStock(increaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock + increaseAmount));
    }

    [Test]
    public void IncreaseStock_WhenCalledWithZero_ShouldNotChangeStock()
    {
        // Arrange
        int initialStock = 50;
        int increaseAmount = 0;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.IncreaseStock(increaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock));
    }

    [Test]
    public void IncreaseStock_WhenCalledWithNegative_ShouldDecreaseStock()
    {
        // Arrange
        int initialStock = 50;
        int increaseAmount = -10;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.IncreaseStock(increaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock + increaseAmount));
    }

    // Tests for DecreaseStock method
    [Test]
    public void DecreaseStock_WhenCalled_ShouldDecreaseStock()
    {
        // Arrange
        int initialStock = 50;
        int decreaseAmount = 10;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.DecreaseStock(decreaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock - decreaseAmount));
    }

    [Test]
    public void DecreaseStock_WhenCalledWithZero_ShouldNotChangeStock()
    {
        // Arrange
        int initialStock = 50;
        int decreaseAmount = 0;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.DecreaseStock(decreaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock));
    }

    [Test]
    public void DecreaseStock_WhenCalledWithNegative_ShouldIncreaseStock()
    {
        // Arrange
        int initialStock = 50;
        int decreaseAmount = -10;
        var product = new Product(500, "Test Product", 100, initialStock);

        // Act
        product.DecreaseStock(decreaseAmount);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(initialStock - decreaseAmount));
    }
}
