using System.Data.SqlTypes;
using System.Reflection.PortableExecutable;
using System.Text;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[]args )
    {
        var filePath = args[0];
        string file = "";
        if(File.Exists(filePath))
        {
            file = File.ReadAllText(filePath);
            Dictionary<char, int> countCharacterOccurencesInFile = createCharacterCountDictionary(file);
            
            string allCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in allCharacters)
            {
                Console.WriteLine("Character: " + c + " Count: " + countCharacterOccurencesInFile[c]);
            }
        }
        else
        {
            throw new FileNotFoundException("File not found.");
        }
    }

    public static char[] fileToCharArray(string filePath)
    {
        string file = File.ReadAllText(filePath);
        return file.ToCharArray();
    }

    public static int countCharacter(string file, char toFind)
    {
        int count = 0;
        foreach(char c in file)
        {
            if (c == toFind)
            {
                count++;
            }
        }
        return count;
    }
    // This ony accounts for letters, not other characters, needs all characters to be able to compress and decompress
    public static Dictionary<char, int> createCharacterCountDictionary(string file)
    {
        string allCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Dictionary<char, int> countedCharacters = new Dictionary<char, int>();
        foreach (char c in allCharacters)
        {
            int count = countCharacter(file, c);
            countedCharacters.Add(c, count);
        }
        return countedCharacters;
    } 

   
}