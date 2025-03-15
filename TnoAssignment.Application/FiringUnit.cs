using System;

namespace TnoAssignment.Application;

public static class FiringUnit
{
    public static bool FireMissile()
    {
        var random = new Random().Next(1, 101);
        return random <= 80;
    }
}