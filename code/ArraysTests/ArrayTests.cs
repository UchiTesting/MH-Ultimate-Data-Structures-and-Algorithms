using Arrays;
using Array = Arrays.Array;

namespace ArraysTests;

[TestClass]
public class ArrayTests
{
    [TestMethod]
    public void ArrayShouldNotThrowAnException()
    {
        // Arrange.
        // Should rather go in Setup
        Array arrayUnderTest = new Array();
        
        // Act
        // Already falls in the else block because Array of 0 mean no slot available
        arrayUnderTest.Insert(0);
        
        // Assert
        
        // Just a way to emulate an Assert.Pass() cause it does not exists anymore
        // Same for methods to check a code does not throw an exception.
        Assert.IsTrue(true);
    }
    
    [TestMethod]
    public void ArrayOf3ShouldNotThrowAnException()
    {
        // Arrange.
        // Should rather go in Setup
        Array arrayUnderTest = new Array(3);
        
        // Act
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(0);
        
        // Assert
        
        // Just a way to emulate an Assert.Pass() cause it does not exists anymore
        // Same for methods to check a code does not throw an exception.
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void RemovingFromArrayShouldNotThrowAnException()
    {
        // Arrange
        Array arrayUnderTest = new Array();
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(1);
        arrayUnderTest.Insert(2);
        arrayUnderTest.Insert(3);
        arrayUnderTest.Insert(4);
        arrayUnderTest.Insert(5);
        arrayUnderTest.Insert(6);
        arrayUnderTest.Insert(7);
        
        // Act
        arrayUnderTest.RemoveAt(2);
        arrayUnderTest.RemoveAt(4);
        arrayUnderTest.RemoveAt(6);
        
        //Assert
        int expectedSize = 5;
        Assert.AreEqual(expectedSize, arrayUnderTest.Size);
    }

    [TestMethod]
    public void IndexOfShouldReturnGoodIndexes()
    {
        // Arrange
        
        Array arrayUnderTest = new Array();
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(1);
        arrayUnderTest.Insert(2);
        arrayUnderTest.Insert(3);
        arrayUnderTest.Insert(4);
        arrayUnderTest.Insert(5);
        arrayUnderTest.Insert(6);
        arrayUnderTest.Insert(7);
        
        // Act
        
        var result0 = arrayUnderTest.IndexOf(0);
        var result1 = arrayUnderTest.IndexOf(1);
        var result2 = arrayUnderTest.IndexOf(2);
        var result3 = arrayUnderTest.IndexOf(3);
        var result4 = arrayUnderTest.IndexOf(4);
        var result5 = arrayUnderTest.IndexOf(5);
        var result6 = arrayUnderTest.IndexOf(6);
        var result7 = arrayUnderTest.IndexOf(7);
        
        // Assert
        
        Assert.AreEqual(0, result0);
        Assert.AreEqual(1, result1);
        Assert.AreEqual(2, result2);
        Assert.AreEqual(3, result3);
        Assert.AreEqual(4, result4);
        Assert.AreEqual(5, result5);
        Assert.AreEqual(6, result6);
        Assert.AreEqual(7, result7);
    }

    [TestMethod]
    public void ToStringShouldReturnCommaSeparatedValues()
    {
        // Arrange
        Array arrayUnderTest = new Array();
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(1);
        arrayUnderTest.Insert(2);
        arrayUnderTest.Insert(3);
        arrayUnderTest.Insert(4);
        arrayUnderTest.Insert(5);
        arrayUnderTest.Insert(6);
        arrayUnderTest.Insert(7);
        
        // Act
        string result = arrayUnderTest.ToString();
        
        // Assert
        string expectedResult = "0, 1, 2, 3, 4, 5, 6, 7";
        Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void ToStringShouldReturnStringEmpty()
    {
        // Arrange
        Array arrayUnderTest = new Array();
        
        // Act
        string result = arrayUnderTest.ToString();
        
        // Assert
        string expectedResult = string.Empty;
        Assert.AreEqual(expectedResult, result);
    }
}