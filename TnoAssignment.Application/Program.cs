namespace TnoAssignment.Application
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("~Starting Patriot Air Defense System Simulation~");

            var radarData = Radar.LoadRadarData("data/radar_data.csv");

            var duration = radarData.Count;

            if (duration > 20)
            {
                duration = 20;
            }

            for (var time = 0; time < duration; time++)
            {
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~[Time: {time + 1}s]~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                var units = radarData[time];

                foreach (var unit in units)
                {
                    bool isHostile = Iff.IsHostile(unit);

                    if (unit == "")
                    {
                        continue;
                    }

                    if (isHostile)
                    {
                        bool targetDestroyed = FiringUnit.FireMissile();
                        Console.WriteLine($"Radar Scan: {unit}, Hostile: {isHostile}. Missile Launched, Target Destroyed: {targetDestroyed}");
                    }
                    else
                    {
                        Console.WriteLine($"Radar Scan: {unit}, Hostile: {isHostile}. Scanned unit is a friend");
                    }
                }

                await Task.Delay(1000);
            }

            Console.WriteLine("End of Simulation");
        }
    }
}