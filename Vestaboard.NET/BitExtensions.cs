using System;
using System.Linq;

namespace VestaboardPackage;

public static class BitExtensions
{
    public static int GetColorID(string colorName)
    {
        return (int)Enum.GetValues(typeof(Color))
            .Cast<Color>()
            .FirstOrDefault(c => string.Equals(c.ToString(), colorName, StringComparison.OrdinalIgnoreCase));
    }
    
    public static int GetLetterID(string letterName)
    {
        return (int)Enum.GetValues(typeof(Letter))
            .Cast<Color>()
            .FirstOrDefault(c => string.Equals(c.ToString(), letterName, StringComparison.OrdinalIgnoreCase));
    }
}