namespace TnoAssignment.Application;

public abstract class Iff
{
    public static bool IsHostile(string unit)
    {
        if (unit == "")
        {
            throw new Exception("Empty unit value detected");
        }
        var oneCount = unit.Count(c => c == '1');
        var zeroCount = unit.Count(c => c == '0');
        return oneCount > zeroCount;
    }
}