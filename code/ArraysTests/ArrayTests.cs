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
}

[TestClass]
public class ArrayPrinterTests
{
    [TestMethod]
    public void StartHere()
    {
        throw new NotImplementedException();
    }
}