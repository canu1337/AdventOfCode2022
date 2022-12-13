namespace AdventOfCode;

internal static class Day9
{
    public static void Part1(int ropeLength = 2)
    {
        // somehow using a class on a HashSet even with overriding Equals and GetHashcode using Disctint is not working
        // so fuck it, I'll store position as strings
        var visitedPositions2 = new List<Position>();
        var visitedPositions = new HashSet<string>();
        var headPosition = new Position();
        var rope = new List<Position>(ropeLength - 1)
        {
            headPosition
        };
        for (var i = 0; i < ropeLength - 1; i++)
        {
            rope.Add(new Position());
        }

        //var input = "R 4\r\nU 4\r\nL 3\r\nD 1\r\nR 4\r\nD 1\r\nL 5\r\nR 2";
        var input = "L 2\r\nU 1\r\nL 2\r\nR 1\r\nL 1\r\nR 2\r\nU 1\r\nR 1\r\nU 1\r\nD 1\r\nL 2\r\nU 1\r\nL 1\r\nR 1\r\nL 1\r\nU 1\r\nL 1\r\nU 2\r\nD 1\r\nU 2\r\nL 1\r\nU 2\r\nR 1\r\nD 1\r\nU 2\r\nL 1\r\nU 2\r\nD 2\r\nR 1\r\nD 1\r\nL 2\r\nR 2\r\nL 1\r\nD 2\r\nR 2\r\nU 1\r\nD 2\r\nU 1\r\nR 2\r\nD 2\r\nL 2\r\nR 1\r\nD 1\r\nU 2\r\nD 1\r\nL 1\r\nR 2\r\nU 1\r\nD 1\r\nL 1\r\nU 2\r\nR 1\r\nL 2\r\nR 1\r\nU 2\r\nD 2\r\nL 2\r\nD 1\r\nU 2\r\nL 2\r\nR 2\r\nL 2\r\nD 2\r\nL 2\r\nU 1\r\nR 1\r\nL 2\r\nR 1\r\nU 2\r\nL 1\r\nD 2\r\nL 1\r\nR 2\r\nD 1\r\nR 1\r\nL 1\r\nR 2\r\nU 2\r\nL 1\r\nU 2\r\nD 1\r\nL 1\r\nU 1\r\nD 2\r\nU 1\r\nD 1\r\nR 2\r\nU 2\r\nR 1\r\nL 1\r\nR 2\r\nL 2\r\nR 1\r\nL 2\r\nD 2\r\nR 2\r\nL 1\r\nU 2\r\nL 1\r\nR 2\r\nL 1\r\nU 2\r\nD 2\r\nL 2\r\nD 2\r\nR 1\r\nU 2\r\nL 2\r\nD 2\r\nU 1\r\nD 2\r\nR 1\r\nD 1\r\nR 2\r\nL 2\r\nR 1\r\nL 3\r\nR 1\r\nD 2\r\nL 1\r\nD 2\r\nL 2\r\nU 1\r\nD 1\r\nR 2\r\nL 2\r\nR 1\r\nD 1\r\nU 1\r\nR 1\r\nD 1\r\nL 2\r\nR 1\r\nU 2\r\nR 2\r\nD 2\r\nR 2\r\nD 3\r\nU 1\r\nL 3\r\nR 2\r\nL 2\r\nR 3\r\nU 2\r\nD 2\r\nU 2\r\nL 2\r\nU 3\r\nD 1\r\nL 1\r\nD 2\r\nU 3\r\nL 3\r\nD 2\r\nR 1\r\nU 1\r\nL 2\r\nD 2\r\nR 2\r\nU 3\r\nL 2\r\nU 2\r\nD 2\r\nR 2\r\nL 1\r\nD 1\r\nL 2\r\nD 1\r\nL 3\r\nU 2\r\nL 1\r\nU 2\r\nR 3\r\nD 2\r\nU 2\r\nR 3\r\nU 2\r\nL 3\r\nD 1\r\nU 1\r\nD 1\r\nU 2\r\nD 1\r\nL 3\r\nU 2\r\nD 1\r\nR 2\r\nU 2\r\nD 1\r\nR 1\r\nU 3\r\nL 2\r\nD 2\r\nL 3\r\nD 3\r\nL 2\r\nD 2\r\nL 2\r\nD 3\r\nR 3\r\nU 2\r\nL 3\r\nR 3\r\nL 2\r\nR 1\r\nL 2\r\nU 3\r\nR 1\r\nL 3\r\nD 3\r\nR 1\r\nL 1\r\nD 1\r\nR 2\r\nU 3\r\nL 3\r\nD 2\r\nR 3\r\nD 3\r\nL 3\r\nU 3\r\nR 2\r\nL 1\r\nR 1\r\nU 2\r\nL 1\r\nU 2\r\nD 2\r\nL 4\r\nU 1\r\nL 1\r\nR 3\r\nD 1\r\nU 3\r\nD 4\r\nU 3\r\nL 4\r\nD 2\r\nR 1\r\nD 1\r\nL 3\r\nU 3\r\nL 1\r\nR 4\r\nU 4\r\nR 4\r\nU 3\r\nL 4\r\nU 3\r\nL 2\r\nR 2\r\nD 2\r\nU 4\r\nL 2\r\nR 3\r\nL 1\r\nR 4\r\nU 3\r\nD 1\r\nL 4\r\nU 1\r\nL 1\r\nU 4\r\nR 3\r\nU 1\r\nD 4\r\nU 1\r\nD 2\r\nL 1\r\nU 2\r\nR 4\r\nL 3\r\nR 2\r\nD 2\r\nU 3\r\nD 2\r\nU 1\r\nD 3\r\nU 1\r\nR 3\r\nL 3\r\nU 2\r\nD 4\r\nU 1\r\nL 2\r\nR 1\r\nL 4\r\nR 2\r\nD 3\r\nL 1\r\nD 1\r\nU 2\r\nL 4\r\nU 4\r\nL 3\r\nR 2\r\nL 2\r\nD 1\r\nU 4\r\nL 1\r\nR 1\r\nU 3\r\nL 3\r\nD 4\r\nR 2\r\nL 1\r\nR 4\r\nD 1\r\nL 2\r\nD 1\r\nU 2\r\nL 3\r\nU 4\r\nL 1\r\nR 3\r\nL 2\r\nU 1\r\nL 3\r\nU 2\r\nD 3\r\nL 4\r\nD 3\r\nL 1\r\nR 4\r\nD 1\r\nL 4\r\nR 4\r\nU 1\r\nR 2\r\nL 3\r\nD 1\r\nR 4\r\nU 1\r\nL 1\r\nD 3\r\nL 3\r\nU 2\r\nL 1\r\nU 4\r\nD 4\r\nU 2\r\nD 3\r\nR 2\r\nL 2\r\nD 1\r\nR 2\r\nL 1\r\nD 2\r\nU 2\r\nD 4\r\nU 3\r\nR 2\r\nL 4\r\nR 3\r\nD 1\r\nU 5\r\nL 5\r\nR 2\r\nD 3\r\nL 5\r\nD 5\r\nU 2\r\nR 3\r\nL 2\r\nR 4\r\nL 1\r\nU 4\r\nR 5\r\nD 5\r\nU 4\r\nD 2\r\nL 4\r\nR 5\r\nD 4\r\nL 5\r\nU 2\r\nL 1\r\nD 2\r\nR 2\r\nD 1\r\nR 3\r\nU 3\r\nR 1\r\nL 1\r\nR 5\r\nL 2\r\nR 1\r\nL 2\r\nU 5\r\nR 5\r\nD 4\r\nL 2\r\nD 4\r\nR 4\r\nU 4\r\nD 3\r\nU 3\r\nD 1\r\nR 4\r\nD 1\r\nU 3\r\nL 2\r\nU 2\r\nR 1\r\nD 1\r\nR 4\r\nU 1\r\nR 5\r\nL 3\r\nD 4\r\nL 2\r\nD 4\r\nL 2\r\nD 4\r\nU 3\r\nD 4\r\nR 3\r\nU 1\r\nL 3\r\nU 3\r\nR 5\r\nL 1\r\nU 4\r\nR 2\r\nL 5\r\nU 3\r\nD 3\r\nU 3\r\nD 2\r\nR 5\r\nU 5\r\nR 2\r\nU 5\r\nL 5\r\nD 4\r\nU 2\r\nL 2\r\nU 3\r\nD 2\r\nL 3\r\nD 2\r\nU 5\r\nL 3\r\nR 3\r\nU 3\r\nD 5\r\nR 3\r\nU 6\r\nD 4\r\nL 2\r\nD 4\r\nL 4\r\nU 6\r\nR 4\r\nD 4\r\nU 5\r\nD 6\r\nU 4\r\nD 5\r\nR 6\r\nD 2\r\nR 5\r\nD 5\r\nL 2\r\nR 5\r\nU 1\r\nL 6\r\nD 4\r\nL 6\r\nU 3\r\nD 6\r\nR 6\r\nL 3\r\nU 5\r\nL 3\r\nU 6\r\nD 1\r\nR 4\r\nL 1\r\nD 2\r\nR 2\r\nU 4\r\nR 4\r\nD 5\r\nL 5\r\nD 6\r\nR 5\r\nD 1\r\nL 3\r\nU 6\r\nD 3\r\nR 6\r\nD 1\r\nL 6\r\nU 1\r\nR 3\r\nU 1\r\nR 4\r\nU 5\r\nL 1\r\nR 1\r\nU 3\r\nL 6\r\nD 1\r\nL 3\r\nR 2\r\nD 5\r\nU 2\r\nL 6\r\nU 6\r\nL 1\r\nU 6\r\nL 3\r\nU 1\r\nD 2\r\nL 6\r\nR 6\r\nD 4\r\nR 3\r\nU 3\r\nR 4\r\nU 5\r\nL 3\r\nD 5\r\nR 3\r\nL 5\r\nU 1\r\nR 4\r\nL 1\r\nD 4\r\nU 6\r\nL 4\r\nD 6\r\nU 4\r\nL 6\r\nU 3\r\nR 6\r\nL 2\r\nU 5\r\nL 3\r\nD 1\r\nU 2\r\nD 4\r\nU 2\r\nL 2\r\nU 1\r\nL 1\r\nU 5\r\nR 1\r\nU 3\r\nR 5\r\nL 1\r\nR 3\r\nL 2\r\nD 1\r\nR 2\r\nD 3\r\nU 4\r\nD 3\r\nU 4\r\nD 2\r\nR 5\r\nU 1\r\nR 2\r\nD 3\r\nR 2\r\nU 4\r\nD 4\r\nR 4\r\nU 5\r\nD 5\r\nU 1\r\nD 2\r\nL 2\r\nR 6\r\nU 5\r\nD 1\r\nR 2\r\nL 1\r\nU 4\r\nD 7\r\nU 4\r\nR 3\r\nU 7\r\nL 2\r\nR 3\r\nL 4\r\nD 4\r\nU 5\r\nR 2\r\nL 5\r\nR 3\r\nU 7\r\nL 2\r\nD 5\r\nU 2\r\nD 4\r\nL 7\r\nR 7\r\nU 1\r\nD 6\r\nU 4\r\nL 6\r\nR 4\r\nD 4\r\nU 1\r\nD 2\r\nR 1\r\nL 2\r\nU 4\r\nR 4\r\nU 3\r\nD 2\r\nU 5\r\nR 4\r\nU 5\r\nD 7\r\nR 4\r\nU 3\r\nL 3\r\nD 4\r\nL 1\r\nR 5\r\nL 5\r\nR 5\r\nU 1\r\nR 6\r\nD 4\r\nU 6\r\nR 5\r\nD 5\r\nL 4\r\nR 3\r\nU 3\r\nL 5\r\nR 1\r\nL 1\r\nD 6\r\nL 3\r\nD 1\r\nU 3\r\nD 7\r\nL 1\r\nR 5\r\nD 4\r\nL 7\r\nR 3\r\nD 7\r\nL 5\r\nD 2\r\nR 2\r\nU 4\r\nD 3\r\nU 4\r\nD 6\r\nR 2\r\nL 2\r\nD 6\r\nU 7\r\nD 6\r\nU 3\r\nD 3\r\nR 3\r\nL 7\r\nR 7\r\nU 3\r\nR 8\r\nU 6\r\nR 5\r\nD 2\r\nL 4\r\nU 3\r\nL 4\r\nD 4\r\nR 4\r\nU 8\r\nD 4\r\nR 3\r\nD 5\r\nL 4\r\nD 2\r\nU 3\r\nD 4\r\nR 1\r\nU 3\r\nR 5\r\nD 4\r\nR 7\r\nD 5\r\nL 4\r\nU 2\r\nR 5\r\nD 4\r\nU 8\r\nD 4\r\nL 8\r\nU 6\r\nL 3\r\nR 3\r\nD 8\r\nL 2\r\nD 6\r\nR 3\r\nU 8\r\nD 8\r\nU 5\r\nD 1\r\nL 1\r\nU 7\r\nD 5\r\nU 7\r\nR 5\r\nU 2\r\nL 1\r\nD 7\r\nL 3\r\nD 6\r\nL 2\r\nR 6\r\nL 1\r\nR 8\r\nL 2\r\nU 6\r\nL 2\r\nD 7\r\nL 5\r\nU 8\r\nD 1\r\nU 4\r\nD 8\r\nU 5\r\nL 8\r\nR 4\r\nD 6\r\nU 7\r\nL 6\r\nU 1\r\nR 2\r\nD 3\r\nR 5\r\nD 7\r\nL 5\r\nR 1\r\nL 5\r\nD 4\r\nR 3\r\nD 7\r\nR 2\r\nD 7\r\nU 8\r\nR 7\r\nL 7\r\nD 2\r\nR 7\r\nU 6\r\nR 1\r\nU 1\r\nR 8\r\nL 2\r\nD 8\r\nL 7\r\nD 3\r\nL 1\r\nR 1\r\nD 7\r\nR 2\r\nL 3\r\nD 8\r\nL 2\r\nU 5\r\nD 5\r\nR 1\r\nD 4\r\nU 2\r\nD 5\r\nL 1\r\nD 1\r\nR 5\r\nD 8\r\nU 2\r\nD 7\r\nU 3\r\nL 9\r\nD 1\r\nU 2\r\nR 8\r\nU 5\r\nD 3\r\nU 8\r\nR 6\r\nL 5\r\nU 3\r\nL 9\r\nD 1\r\nR 7\r\nU 1\r\nD 4\r\nR 6\r\nD 7\r\nL 8\r\nR 5\r\nU 4\r\nL 5\r\nD 2\r\nR 4\r\nL 9\r\nD 1\r\nU 5\r\nR 1\r\nD 4\r\nR 7\r\nU 8\r\nR 3\r\nU 4\r\nL 9\r\nD 9\r\nR 6\r\nL 2\r\nD 7\r\nU 3\r\nL 6\r\nR 5\r\nU 1\r\nR 1\r\nD 6\r\nL 9\r\nU 2\r\nD 4\r\nL 3\r\nD 7\r\nL 5\r\nR 7\r\nL 4\r\nR 7\r\nL 9\r\nU 8\r\nR 6\r\nL 1\r\nU 7\r\nD 6\r\nR 2\r\nL 7\r\nD 7\r\nR 4\r\nU 5\r\nR 1\r\nL 9\r\nR 2\r\nD 2\r\nU 3\r\nR 8\r\nU 6\r\nL 8\r\nD 3\r\nL 7\r\nR 9\r\nL 5\r\nU 4\r\nR 9\r\nU 3\r\nL 8\r\nR 9\r\nD 3\r\nL 2\r\nR 3\r\nD 8\r\nR 6\r\nD 7\r\nR 6\r\nU 8\r\nL 4\r\nU 7\r\nR 1\r\nL 3\r\nD 8\r\nU 1\r\nL 9\r\nD 5\r\nL 5\r\nU 8\r\nR 9\r\nL 2\r\nU 5\r\nD 2\r\nU 3\r\nL 8\r\nR 9\r\nL 7\r\nR 4\r\nL 7\r\nR 10\r\nU 9\r\nD 8\r\nU 8\r\nR 1\r\nU 2\r\nD 6\r\nU 9\r\nL 4\r\nD 5\r\nU 9\r\nD 8\r\nR 5\r\nU 5\r\nD 3\r\nU 5\r\nR 2\r\nD 1\r\nU 4\r\nL 7\r\nR 6\r\nD 9\r\nL 9\r\nD 4\r\nL 4\r\nD 2\r\nL 3\r\nR 8\r\nL 1\r\nD 8\r\nR 2\r\nU 2\r\nD 3\r\nR 9\r\nL 5\r\nU 3\r\nL 10\r\nU 2\r\nD 7\r\nR 9\r\nL 7\r\nD 4\r\nL 10\r\nR 7\r\nL 4\r\nD 3\r\nR 8\r\nD 1\r\nR 6\r\nL 1\r\nU 1\r\nR 6\r\nU 8\r\nL 5\r\nR 7\r\nD 9\r\nL 1\r\nD 9\r\nR 4\r\nD 5\r\nR 7\r\nD 4\r\nU 10\r\nR 2\r\nL 1\r\nU 9\r\nD 1\r\nU 7\r\nR 10\r\nU 9\r\nR 5\r\nL 3\r\nU 5\r\nR 4\r\nD 6\r\nR 5\r\nL 4\r\nU 2\r\nL 1\r\nD 5\r\nU 7\r\nD 6\r\nR 8\r\nU 8\r\nD 8\r\nR 9\r\nD 7\r\nR 2\r\nU 10\r\nR 6\r\nL 10\r\nR 10\r\nU 8\r\nD 9\r\nR 9\r\nD 4\r\nR 1\r\nL 5\r\nU 2\r\nD 4\r\nR 4\r\nD 2\r\nL 9\r\nU 10\r\nD 3\r\nR 10\r\nL 8\r\nU 8\r\nR 2\r\nL 11\r\nU 6\r\nL 11\r\nU 7\r\nL 8\r\nD 8\r\nL 2\r\nR 7\r\nL 10\r\nR 10\r\nD 5\r\nL 7\r\nD 9\r\nL 7\r\nR 3\r\nU 11\r\nL 1\r\nU 11\r\nR 5\r\nD 2\r\nL 1\r\nD 1\r\nL 9\r\nR 6\r\nU 6\r\nL 8\r\nR 2\r\nD 7\r\nU 3\r\nL 7\r\nD 7\r\nL 1\r\nU 2\r\nL 4\r\nD 9\r\nR 6\r\nD 4\r\nR 2\r\nL 10\r\nR 8\r\nL 10\r\nU 2\r\nR 11\r\nL 11\r\nR 4\r\nU 3\r\nD 11\r\nR 10\r\nD 11\r\nL 1\r\nU 10\r\nR 10\r\nU 1\r\nL 3\r\nU 8\r\nD 6\r\nL 9\r\nR 7\r\nU 1\r\nR 5\r\nL 4\r\nD 5\r\nL 11\r\nD 3\r\nL 7\r\nD 3\r\nU 4\r\nD 6\r\nR 8\r\nU 2\r\nL 4\r\nR 8\r\nL 9\r\nR 10\r\nU 5\r\nL 6\r\nU 8\r\nR 5\r\nU 11\r\nR 5\r\nD 9\r\nR 6\r\nU 4\r\nL 2\r\nR 7\r\nL 5\r\nR 5\r\nU 4\r\nL 3\r\nR 2\r\nL 6\r\nD 7\r\nU 6\r\nD 8\r\nU 11\r\nD 2\r\nU 4\r\nR 4\r\nD 11\r\nL 6\r\nR 6\r\nD 5\r\nU 9\r\nD 1\r\nU 8\r\nD 9\r\nR 8\r\nD 11\r\nU 11\r\nR 2\r\nU 3\r\nR 11\r\nL 6\r\nU 3\r\nR 5\r\nL 12\r\nR 5\r\nL 4\r\nD 11\r\nU 10\r\nR 11\r\nU 8\r\nL 7\r\nR 10\r\nL 11\r\nR 2\r\nL 5\r\nR 12\r\nL 6\r\nR 7\r\nL 12\r\nD 5\r\nL 6\r\nU 9\r\nR 12\r\nU 12\r\nR 7\r\nD 5\r\nR 2\r\nD 7\r\nU 9\r\nR 11\r\nU 3\r\nL 8\r\nU 10\r\nL 4\r\nR 4\r\nD 3\r\nU 2\r\nR 10\r\nU 7\r\nD 7\r\nR 6\r\nU 11\r\nD 2\r\nL 7\r\nR 9\r\nD 12\r\nL 5\r\nU 2\r\nR 3\r\nU 3\r\nR 1\r\nL 7\r\nR 8\r\nD 12\r\nR 6\r\nU 12\r\nR 11\r\nD 12\r\nR 4\r\nD 8\r\nU 6\r\nD 1\r\nR 6\r\nU 2\r\nD 5\r\nU 7\r\nL 6\r\nD 5\r\nR 5\r\nL 6\r\nU 4\r\nD 12\r\nR 11\r\nL 3\r\nR 7\r\nL 5\r\nR 7\r\nU 9\r\nR 7\r\nD 1\r\nR 12\r\nL 5\r\nU 1\r\nR 12\r\nL 6\r\nD 1\r\nR 9\r\nL 5\r\nR 7\r\nD 11\r\nL 9\r\nR 6\r\nU 2\r\nR 6\r\nU 1\r\nR 10\r\nL 11\r\nU 10\r\nR 11\r\nU 6\r\nL 1\r\nD 10\r\nU 9\r\nL 3\r\nU 12\r\nR 4\r\nU 1\r\nD 4\r\nR 3\r\nU 4\r\nD 3\r\nU 13\r\nD 12\r\nU 11\r\nL 8\r\nD 5\r\nR 7\r\nD 5\r\nL 11\r\nU 3\r\nR 12\r\nD 3\r\nR 1\r\nL 8\r\nD 11\r\nL 3\r\nR 12\r\nU 4\r\nR 6\r\nL 10\r\nD 5\r\nL 10\r\nD 13\r\nU 5\r\nL 3\r\nR 10\r\nL 7\r\nR 13\r\nL 10\r\nD 8\r\nL 8\r\nU 8\r\nD 9\r\nR 8\r\nD 2\r\nU 6\r\nD 3\r\nR 8\r\nD 6\r\nR 13\r\nU 10\r\nD 6\r\nL 3\r\nR 4\r\nU 11\r\nR 6\r\nD 4\r\nR 4\r\nU 1\r\nR 11\r\nD 7\r\nR 11\r\nD 3\r\nR 8\r\nL 5\r\nU 9\r\nD 9\r\nU 13\r\nL 2\r\nU 9\r\nL 7\r\nU 10\r\nR 12\r\nU 7\r\nL 6\r\nR 10\r\nL 12\r\nU 6\r\nL 4\r\nD 8\r\nR 2\r\nL 2\r\nR 7\r\nL 9\r\nR 1\r\nD 3\r\nU 7\r\nL 3\r\nR 1\r\nD 3\r\nR 5\r\nU 10\r\nD 13\r\nL 3\r\nD 8\r\nU 4\r\nR 13\r\nD 8\r\nU 3\r\nD 9\r\nL 3\r\nD 9\r\nU 6\r\nL 10\r\nR 8\r\nL 2\r\nU 4\r\nL 8\r\nD 1\r\nU 13\r\nL 5\r\nU 3\r\nD 9\r\nL 8\r\nU 10\r\nL 4\r\nR 13\r\nD 9\r\nR 6\r\nL 5\r\nU 13\r\nD 11\r\nR 3\r\nU 8\r\nD 1\r\nU 5\r\nL 1\r\nD 6\r\nR 1\r\nU 7\r\nD 5\r\nR 14\r\nU 7\r\nD 13\r\nL 9\r\nU 13\r\nL 7\r\nR 14\r\nL 2\r\nU 10\r\nR 9\r\nL 14\r\nR 8\r\nL 5\r\nU 7\r\nR 14\r\nU 8\r\nD 9\r\nR 14\r\nL 9\r\nD 7\r\nR 1\r\nD 1\r\nL 13\r\nR 13\r\nD 4\r\nR 11\r\nD 2\r\nR 3\r\nU 3\r\nR 11\r\nL 1\r\nR 8\r\nU 9\r\nL 2\r\nR 12\r\nU 3\r\nL 14\r\nD 3\r\nU 8\r\nR 13\r\nL 2\r\nR 8\r\nD 8\r\nU 14\r\nR 6\r\nU 1\r\nL 3\r\nD 9\r\nU 6\r\nR 10\r\nL 4\r\nD 8\r\nL 10\r\nU 11\r\nD 9\r\nU 13\r\nL 11\r\nR 8\r\nL 7\r\nR 7\r\nU 8\r\nD 7\r\nL 9\r\nR 11\r\nL 6\r\nR 9\r\nU 12\r\nL 9\r\nR 3\r\nU 1\r\nD 11\r\nU 1\r\nR 10\r\nD 9\r\nL 11\r\nD 4\r\nU 6\r\nL 12\r\nD 11\r\nR 2\r\nD 2\r\nL 14\r\nR 6\r\nD 5\r\nL 12\r\nR 6\r\nD 6\r\nR 13\r\nU 5\r\nD 12\r\nU 8\r\nD 11\r\nR 6\r\nL 11\r\nU 4\r\nL 11\r\nU 12\r\nL 7\r\nD 7\r\nR 2\r\nU 11\r\nL 4\r\nU 9\r\nR 6\r\nD 4\r\nU 7\r\nR 1\r\nL 13\r\nD 1\r\nU 7\r\nL 1\r\nR 5\r\nU 10\r\nL 11\r\nD 4\r\nU 15\r\nL 5\r\nD 14\r\nU 8\r\nD 13\r\nR 2\r\nU 13\r\nD 1\r\nR 3\r\nU 2\r\nL 6\r\nD 1\r\nU 9\r\nD 9\r\nU 4\r\nD 5\r\nU 8\r\nD 13\r\nL 4\r\nU 12\r\nL 9\r\nR 9\r\nL 7\r\nU 8\r\nL 7\r\nR 4\r\nL 5\r\nU 6\r\nR 8\r\nU 13\r\nD 7\r\nL 8\r\nR 5\r\nD 6\r\nU 14\r\nL 10\r\nR 14\r\nL 13\r\nU 10\r\nD 6\r\nR 2\r\nU 14\r\nL 9\r\nR 4\r\nU 14\r\nR 7\r\nD 1\r\nU 5\r\nL 5\r\nD 4\r\nL 2\r\nU 11\r\nL 5\r\nD 12\r\nL 1\r\nD 14\r\nL 10\r\nR 14\r\nD 12\r\nL 10\r\nU 2\r\nD 13\r\nL 15\r\nU 1\r\nR 15\r\nD 14\r\nR 2\r\nU 7\r\nL 5\r\nU 15\r\nL 15\r\nD 9\r\nL 1\r\nD 13\r\nU 3\r\nR 15\r\nL 6\r\nD 10\r\nL 4\r\nU 10\r\nR 14\r\nL 8\r\nU 7\r\nD 10\r\nU 1\r\nR 7\r\nL 14\r\nR 5\r\nL 9\r\nD 15\r\nL 14\r\nR 14\r\nL 7\r\nR 6\r\nL 3\r\nD 13\r\nL 5\r\nD 10\r\nR 9\r\nL 2\r\nD 16\r\nU 9\r\nL 14\r\nR 2\r\nD 2\r\nR 1\r\nL 1\r\nU 7\r\nD 12\r\nR 4\r\nU 15\r\nR 7\r\nU 14\r\nR 2\r\nD 3\r\nR 6\r\nL 9\r\nU 8\r\nR 7\r\nL 8\r\nD 6\r\nR 13\r\nD 10\r\nL 9\r\nD 1\r\nU 14\r\nL 8\r\nR 3\r\nL 14\r\nR 2\r\nD 13\r\nL 1\r\nR 15\r\nU 5\r\nD 4\r\nR 9\r\nD 9\r\nL 3\r\nD 12\r\nR 4\r\nU 8\r\nL 6\r\nD 10\r\nL 6\r\nR 12\r\nD 14\r\nU 5\r\nD 13\r\nR 13\r\nU 11\r\nD 10\r\nR 16\r\nL 3\r\nU 10\r\nD 8\r\nL 1\r\nU 8\r\nD 4\r\nL 6\r\nR 12\r\nD 7\r\nL 5\r\nU 11\r\nR 5\r\nD 7\r\nL 2\r\nU 9\r\nL 8\r\nR 14\r\nD 5\r\nR 6\r\nU 10\r\nD 16\r\nU 4\r\nR 11\r\nU 3\r\nR 4\r\nU 5\r\nL 11\r\nR 12\r\nU 9\r\nR 9\r\nD 12\r\nR 8\r\nD 9\r\nL 5\r\nD 5\r\nU 11\r\nL 16\r\nU 2\r\nL 5\r\nR 10\r\nU 13\r\nR 10\r\nL 3\r\nD 3\r\nU 2\r\nL 14\r\nD 15\r\nL 8\r\nD 1\r\nL 10\r\nR 6\r\nL 5\r\nU 6\r\nR 14\r\nU 11\r\nR 16\r\nL 1\r\nR 16\r\nL 10\r\nU 9\r\nD 2\r\nL 2\r\nU 15\r\nL 3\r\nD 11\r\nL 16\r\nU 9\r\nD 17\r\nU 4\r\nD 14\r\nU 4\r\nL 5\r\nR 14\r\nL 2\r\nU 13\r\nD 1\r\nU 6\r\nR 3\r\nU 7\r\nD 12\r\nL 11\r\nU 6\r\nL 5\r\nD 16\r\nR 11\r\nL 2\r\nR 15\r\nD 3\r\nU 11\r\nR 2\r\nD 6\r\nR 16\r\nL 9\r\nR 4\r\nL 8\r\nD 4\r\nL 3\r\nD 15\r\nU 10\r\nD 4\r\nU 8\r\nR 2\r\nU 16\r\nL 9\r\nD 5\r\nR 8\r\nD 11\r\nR 13\r\nU 11\r\nD 2\r\nR 16\r\nD 10\r\nL 11\r\nU 6\r\nL 13\r\nD 10\r\nL 10\r\nR 13\r\nU 5\r\nR 10\r\nD 2\r\nR 2\r\nD 14\r\nL 15\r\nR 15\r\nD 1\r\nL 2\r\nU 17\r\nL 12\r\nR 9\r\nD 10\r\nL 2\r\nD 12\r\nR 8\r\nU 1\r\nL 6\r\nU 14\r\nL 15\r\nU 13\r\nL 15\r\nD 3\r\nU 8\r\nR 14\r\nU 3\r\nL 12\r\nR 5\r\nL 12\r\nR 12\r\nU 6\r\nD 10\r\nU 4\r\nD 11\r\nU 1\r\nD 17\r\nU 5\r\nD 8\r\nU 9\r\nR 9\r\nL 6\r\nR 10\r\nU 1\r\nD 3\r\nR 1\r\nD 4\r\nL 16\r\nD 16\r\nU 3\r\nL 17\r\nD 8\r\nR 15\r\nD 9\r\nR 7\r\nD 8\r\nR 17\r\nL 13\r\nU 16\r\nD 2\r\nL 1\r\nR 3\r\nD 11\r\nR 15\r\nL 10\r\nR 9\r\nU 1\r\nR 11\r\nL 15\r\nU 2\r\nR 12\r\nU 18\r\nR 18\r\nD 4\r\nU 7\r\nD 13\r\nU 18\r\nD 14\r\nU 7\r\nD 2\r\nL 1\r\nR 1\r\nU 4\r\nL 13\r\nR 4\r\nU 13\r\nL 16\r\nD 12\r\nR 4\r\nU 9\r\nD 11\r\nR 4\r\nL 16\r\nD 4\r\nL 8\r\nD 3\r\nR 9\r\nU 15\r\nR 3\r\nL 9\r\nU 2\r\nR 15\r\nL 5\r\nR 3\r\nD 17\r\nU 17\r\nR 11\r\nL 13\r\nU 8\r\nD 11\r\nL 12\r\nU 1\r\nD 5\r\nU 12\r\nD 2\r\nR 13\r\nD 6\r\nR 5\r\nD 10\r\nU 15\r\nR 7\r\nL 4\r\nR 8\r\nD 10\r\nU 17\r\nL 12\r\nU 14\r\nL 9\r\nD 18\r\nR 11\r\nU 13\r\nD 9\r\nL 1\r\nD 9\r\nU 6\r\nR 15\r\nL 1\r\nU 4\r\nD 13\r\nR 18\r\nU 3\r\nL 2\r\nU 18\r\nR 17\r\nL 14\r\nU 12\r\nR 7\r\nL 11\r\nD 3\r\nU 17\r\nD 9\r\nR 13\r\nL 18\r\nD 15\r\nR 16\r\nU 16\r\nL 12\r\nD 16\r\nR 18\r\nL 13\r\nD 8\r\nU 16\r\nD 2\r\nU 17\r\nD 4\r\nL 12\r\nU 3\r\nD 2\r\nR 3\r\nL 14\r\nD 7\r\nL 6\r\nU 5\r\nL 19\r\nR 19\r\nL 7\r\nR 1\r\nD 2\r\nU 11\r\nL 7\r\nU 8\r\nL 4\r\nR 4\r\nL 12\r\nU 7\r\nR 3\r\nU 3\r\nL 2\r\nR 3\r\nD 9\r\nR 16\r\nU 4\r\nR 12\r\nL 10\r\nD 3\r\nU 17\r\nD 6\r\nU 14\r\nD 2\r\nL 19\r\nU 3\r\nR 19\r\nL 11\r\nU 13\r\nR 11\r\nD 14\r\nL 4\r\nD 11\r\nU 9\r\nL 8\r\nU 18\r\nL 17\r\nD 7\r\nU 7\r\nR 19\r\nL 8\r\nD 6\r\nR 7\r\nU 19\r\nD 7\r\nR 7\r\nL 16\r\nR 11\r\nL 2\r\nR 10\r\nU 6\r\nR 2\r\nU 8\r\nL 8\r\nD 3\r\nL 12\r\nD 16\r\nU 1\r\nD 12\r\nL 4\r\nD 16\r\nR 13\r\nL 12\r\nR 11\r\nU 8\r\nL 6\r\nD 6\r\nL 1\r\nU 5\r\nL 3\r\nR 6\r\nU 8\r\nR 5\r\nU 4\r\nD 14\r\nR 7\r\nU 2\r\nL 9\r\nU 8\r\nR 13\r\nU 1\r\nD 15\r\nR 18\r\nD 15\r\nR 14\r\nD 15\r\nR 8\r\nD 16\r\nU 6\r\nL 7\r\nD 10\r\nR 9\r\nL 12\r\nR 11\r\nL 3\r\nR 12\r\nD 8\r\nU 14\r\nL 18";
        var commands = input.Split("\r\n").Select(x => new Command(x));
        foreach (var command in commands)
        {
            for (var i = 0; i < command.Steps; i++)
            {
                foreach (var knot in rope)
                {
                    visitedPositions.Add(knot.ToString());
                    visitedPositions2.Add(knot.Clone());
                }
                //PrintGrid();

                MoveEntity(headPosition, command);
                for (var j = 1; j < rope.Count; j++)
                {
                    MoveKnot(rope[j - 1], rope[j], command);
                }
            }
        }
        Console.WriteLine(visitedPositions.Distinct().Count());

        void MoveKnot(Position hPosition, Position currentKnotPosition, Command command)
        {
            if (AreTouching(hPosition, currentKnotPosition))
            {
                return;
            }
            // same move as head
            MoveEntity(currentKnotPosition, command);
            // move tail in same column/row
            if (hPosition.X != currentKnotPosition.X && hPosition.Y != currentKnotPosition.Y)
            {
                if (command.Direction == 'U' || command.Direction == 'D')
                {
                    currentKnotPosition.X = hPosition.X;
                }
                else
                {
                    currentKnotPosition.Y = hPosition.Y;
                }
            }
        }

        void PrintGrid()
        {
            var maxX = visitedPositions2.Max(x => x.X);
            var minX = visitedPositions2.Min(x => x.X);
            var maxY = visitedPositions2.Max(x => x.Y);
            var minY = visitedPositions2.Min(x => x.Y);
            Console.WriteLine("-------------------");
            for (var i = maxY; i >= minY; i--)
            {
                var line = "";

                for (var j = minX; j <= maxX; j++)
                {
                    var c = '.';
                    if (headPosition.ToString() == j + " " + i)
                    {
                        c = 'H';
                    }
                    //else if (tailPosition.ToString() == j + " " + i)
                    //{
                    //    c = 'T';
                    //}
                    else if (visitedPositions.Contains(j + " " + i))
                    {
                        c = '#';
                    }
                    line += c;
                }
                Console.WriteLine(line);
            }
        }
    }

    private static void MoveEntity(Position entityPosition, Command command)
    {
        switch (command.Direction)
        {
            case 'U':
                entityPosition.Y++;
                break;

            case 'D':
                entityPosition.Y--;
                break;

            case 'L':
                entityPosition.X--;
                break;

            case 'R':
                entityPosition.X++;
                break;
        }
    }

    private static bool AreTouching(Position a, Position b) => Math.Abs(a.X - b.X) <= 1 && (Math.Abs(a.Y - b.Y) <= 1);

    private class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position Clone()
        {
            return new Position { X = X, Y = Y };
        }

        public override string? ToString()
        {
            return X.ToString() + " " + Y.ToString();
        }

        //public override bool Equals(object? obj)
        //{
        //    return obj is Position position &&
        //           X == position.X &&
        //           Y == position.Y;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(X, Y);
        //}
    }

    private record Command
    {
        public Command(string text)
        {
            Direction = text[0];
            Steps = int.Parse(text[2..]);
        }
        public char Direction { get; set; }
        public int Steps { get; set; }
    }
}