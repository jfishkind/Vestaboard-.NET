namespace VestaboardPackage;

public class Enumeration : IComparable
{
    public string Name { get; private set; }

    public int Id { get; private set; }
    
    public string? Symbol { get; private set; }

    protected Enumeration(int id, string name, string? symbol = null) => (Id, Name, Symbol) = (id, name, symbol);

    public override string ToString() => Name;
    
    public override bool Equals(object obj)
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = Id.Equals(otherValue.Id);

        return typeMatches && valueMatches;
    }
    
    public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
    
    public static int GetIdFromValue<T>(string value) where T : Enumeration
    {
        var allValues = GetAll<T>();
        var enumValue = allValues.FirstOrDefault(v => v.Name.Equals(value, StringComparison.OrdinalIgnoreCase));
        return enumValue?.Id ?? 0;
    }
    
    public static int GetIdFromSymbol(string symbol)
    {
        var allValues = GetAll<Symbol>();
        var enumValue = allValues.FirstOrDefault(v => v.Symbol.Equals(symbol, StringComparison.Ordinal));
        return enumValue?.Id ?? 0;
    }

    private static T[] GetAll<T>() where T : Enumeration
    {
        var fields = typeof(T).GetFields(System.Reflection.BindingFlags.Public |
                                         System.Reflection.BindingFlags.Static |
                                         System.Reflection.BindingFlags.DeclaredOnly);
        return fields.Select(f => f.GetValue(null)).Cast<T>().ToArray();
    }
}