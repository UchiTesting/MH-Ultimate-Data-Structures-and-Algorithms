using System.Text;
using Arrays;
using Array = Arrays.Array;

namespace ArraysTests;

[TestClass]
public class ArrayPrinterTests
{
    [TestMethod]
    public void StartHere()
    {
        // Arrange
        Array arrayUnderTest = new Array(3);
        
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(0);
        arrayUnderTest.Insert(0);
        
        StringBuilder consoleOutput = new StringBuilder().Clear();
        Console.SetOut(new StringWriter(consoleOutput));
        
        ArrayPrinter arrayPrinter = new ArrayPrinter();

        // Act
        arrayPrinter.Print(ref arrayUnderTest);
        
        //
        string expectedOutput = "[0, 0, 0]";
        
        Assert.AreEqual(expectedOutput, consoleOutput.ToString());
        
    }
}