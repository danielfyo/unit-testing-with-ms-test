using System.Diagnostics.CodeAnalysis;

namespace Training.Infrastructure.Core;

public class FakeClass
{
    public string Name { get; set; } = default!;
    public string LastName { get; set; } = default!;

    [ExcludeFromCodeCoverage]
    public override bool Equals(object? obj)
    {
        var fakeObj = obj as FakeClass;

        if (obj == null)
            return false;

        return fakeObj.Name == Name &&
               fakeObj.LastName == LastName;
    }
    
    [ExcludeFromCodeCoverage]
    public override int GetHashCode() => Name.GetHashCode() ^ LastName.GetHashCode();
}