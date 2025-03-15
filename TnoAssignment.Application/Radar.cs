namespace TnoAssignment.Application;

public abstract class Radar
{
    public static List<string[]> LoadRadarData(string filePath)
    {
        var radarData = new List<string[]>();
        try
        {
            radarData.AddRange(File.ReadLines(filePath).Select(line => line.Split(';')));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading radar data! Check your csv file directory. exception: {ex.Message}");
            Environment.Exit(1);
        }
        return radarData;
    }
}