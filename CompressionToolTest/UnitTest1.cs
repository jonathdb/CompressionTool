namespace CompressionToolTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Test_File_to_Chararray()
    {
        // arrange
        int expectedCharacters = 3324215;
        string filePath = @"C:\Users\jonat\Documents\Github\CompressionTool\LesMiserables.txt";

        // act
        char[] actualCharacters = Program.fileToCharArray(filePath);

        // assert
        Assert.AreEqual(expectedCharacters, actualCharacters.Length, 0.1, "Wrong count");
    }

    [TestMethod]
    public void Test_count_character()
    {
        // arrange
        int expectedT = 223000;
        int expectedX = 333;
        string filePath = @"C:\Users\jonat\Documents\Github\CompressionTool\LesMiserables.txt";

        // act
        int actualT = Program.countCharacter(filePath, 't');
        int actualX = Program.countCharacter(filePath, 'X');

        // assert
        Assert.AreEqual(expectedT, actualT, 0.1, "Wrong nuber of Ts");
        Assert.AreEqual(expectedX, actualX, 0.1, "Wrong nuber of Xs");

    }
}