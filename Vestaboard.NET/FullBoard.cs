using System;

namespace VestaboardPackage;

public class FullBoard
{
    public int[] First { get; set; } = new int[22];
    public int[] Second { get; set; } = new int[22];
    public int[] Third { get; set; } = new int[22];
    public int[] Fourth { get; set; } = new int[22];
    public int[] Fifth { get; set; } = new int[22];
    public int[] Sixth { get; set; } = new int[22];

    public int[][] AllRows
    {
        get
        {
            return new[]
            {
                First,
                Second,
                Third,
                Fourth,
                Fifth,
                Sixth
            };
        }
    }

    public int[] CreateARow(string[] row)
    {
        var rowOfInt = new int[22];
        for (var i = 0; i < rowOfInt.Length - 1; i++)
        {
            rowOfInt[i] = ConvertStringToBitID(row[i]);
        }

        return rowOfInt;
    }

    // Converting to the IDs found in the Vestaboard documentation
    // https://docs.vestaboard.com/docs/characterCodes
    private int ConvertStringToBitID(string str)
    {
        // Check if we are converting to an int
        // If so all int IDs are 26 more than their actual value
        // Except 0, which is 36
        if (int.TryParse(str, out int num))
        {
            return num == 0 ? 36 : num + 26;
        }

        var color = BitExtensions.GetColorID(str);
        
        if (color != 0)
        {
            return color;
        }

        var letter = BitExtensions.GetLetterID(str);
        
        if (letter != 0)
        {
            return letter;
        }

        return 1;
    }
}