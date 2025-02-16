using System;
using System.Linq;

public static class BottleSong
{
    public static string Recite(int startBottles, int takeDown)
        => string.Join("\n\n", Enumerable.Range(startBottles - takeDown + 1, takeDown).Reverse().Select(Verse));
    private static string Verse(int number)
    {
        string bottles = number == 1 ? "bottle" : "bottles";
        string nextBottles = (number - 1) == 1 ? "bottle" : "bottles";
        string currCount = DecimalToOrdinal(number);
        string nextCount = DecimalToOrdinal(number - 1);

        return $"{currCount} green {bottles} hanging on the wall,\n" +
               $"{currCount} green {bottles} hanging on the wall,\n" +
               "And if one green bottle should accidentally fall,\n" +
               $"There'll be {nextCount.ToLowerInvariant()} green {nextBottles} hanging on the wall.";
    }

    private static string DecimalToOrdinal(int number)
        => number switch
        {
            0 => "No",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            10 => "Ten",
            _ => throw new NotImplementedException()
        };
}