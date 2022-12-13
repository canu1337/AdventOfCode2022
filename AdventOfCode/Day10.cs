namespace AdventOfCode;

internal static class Day10
{
    //private static readonly string input = "addx 15\r\naddx -11\r\naddx 6\r\naddx -3\r\naddx 5\r\naddx -1\r\naddx -8\r\naddx 13\r\naddx 4\r\nnoop\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx -1\r\naddx -35\r\naddx 1\r\naddx 24\r\naddx -19\r\naddx 1\r\naddx 16\r\naddx -11\r\nnoop\r\nnoop\r\naddx 21\r\naddx -15\r\nnoop\r\nnoop\r\naddx -3\r\naddx 9\r\naddx 1\r\naddx -3\r\naddx 8\r\naddx 1\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx -36\r\nnoop\r\naddx 1\r\naddx 7\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\naddx 6\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx 7\r\naddx 1\r\nnoop\r\naddx -13\r\naddx 13\r\naddx 7\r\nnoop\r\naddx 1\r\naddx -33\r\nnoop\r\nnoop\r\nnoop\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\naddx 8\r\nnoop\r\naddx -1\r\naddx 2\r\naddx 1\r\nnoop\r\naddx 17\r\naddx -9\r\naddx 1\r\naddx 1\r\naddx -3\r\naddx 11\r\nnoop\r\nnoop\r\naddx 1\r\nnoop\r\naddx 1\r\nnoop\r\nnoop\r\naddx -13\r\naddx -19\r\naddx 1\r\naddx 3\r\naddx 26\r\naddx -30\r\naddx 12\r\naddx -1\r\naddx 3\r\naddx 1\r\nnoop\r\nnoop\r\nnoop\r\naddx -9\r\naddx 18\r\naddx 1\r\naddx 2\r\nnoop\r\nnoop\r\naddx 9\r\nnoop\r\nnoop\r\nnoop\r\naddx -1\r\naddx 2\r\naddx -37\r\naddx 1\r\naddx 3\r\nnoop\r\naddx 15\r\naddx -21\r\naddx 22\r\naddx -6\r\naddx 1\r\nnoop\r\naddx 2\r\naddx 1\r\nnoop\r\naddx -10\r\nnoop\r\nnoop\r\naddx 20\r\naddx 1\r\naddx 2\r\naddx 2\r\naddx -6\r\naddx -11\r\nnoop\r\nnoop\r\nnoop";
    private static readonly string input = "addx 2\r\naddx 3\r\naddx 1\r\nnoop\r\naddx 4\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\naddx 1\r\naddx 4\r\naddx -2\r\naddx 3\r\naddx 5\r\naddx -1\r\naddx 5\r\naddx 3\r\naddx -2\r\naddx 4\r\nnoop\r\nnoop\r\nnoop\r\naddx -27\r\naddx -5\r\naddx 2\r\naddx -7\r\naddx 3\r\naddx 7\r\naddx 5\r\naddx 2\r\naddx 5\r\nnoop\r\nnoop\r\naddx -2\r\nnoop\r\naddx 3\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx 3\r\nnoop\r\naddx 2\r\naddx -29\r\naddx 30\r\naddx -26\r\naddx -10\r\nnoop\r\naddx 5\r\nnoop\r\naddx 18\r\naddx -13\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 1\r\naddx 2\r\naddx 7\r\nnoop\r\nnoop\r\naddx 3\r\nnoop\r\naddx 2\r\naddx 3\r\nnoop\r\naddx -37\r\nnoop\r\naddx 16\r\naddx -12\r\naddx 29\r\naddx -16\r\naddx -10\r\naddx 5\r\naddx 2\r\naddx -11\r\naddx 11\r\naddx 3\r\naddx 5\r\naddx 2\r\naddx 2\r\naddx -1\r\naddx 2\r\naddx 5\r\naddx 2\r\nnoop\r\nnoop\r\nnoop\r\naddx -37\r\nnoop\r\naddx 17\r\naddx -10\r\naddx -2\r\nnoop\r\naddx 7\r\naddx 3\r\nnoop\r\naddx 2\r\naddx -10\r\naddx 22\r\naddx -9\r\naddx 5\r\naddx 2\r\naddx -5\r\naddx 6\r\naddx 2\r\naddx 5\r\naddx 2\r\naddx -28\r\naddx -7\r\nnoop\r\nnoop\r\naddx 1\r\naddx 4\r\naddx 17\r\naddx -12\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\naddx 6\r\nnoop\r\naddx -1\r\naddx -17\r\naddx 18\r\nnoop\r\naddx 5\r\nnoop\r\nnoop\r\nnoop\r\naddx 5\r\naddx 4\r\naddx -2\r\nnoop\r\nnoop\r\nnoop\r\nnoop\r\nnoop";

    public static void Part1()
    {
        var instructions = input.Split("\r\n");
        var register = 1;
        var cycleNumber = 1;
        var pixelCoord = 0;
        var dict = new Dictionary<int, int>();
        var index = 0;
        foreach (var instruction in instructions)
        {
            index++;
            var sleepTimer = 0;

            if (instruction == "noop")
                sleepTimer = 1;
            else if (instruction.StartsWith("addx"))
            {
                sleepTimer = 2;
            }

            for (var i = 0; i < sleepTimer; i++)
            {
                if (cycleNumber == 20 || (cycleNumber - 20) % 40 == 0)
                {
                    dict.Add(cycleNumber, register);
                }

                if (pixelCoord == register || pixelCoord == register + 1 || pixelCoord == register - 1)
                    Console.Write("#");
                else
                    Console.Write(".");
                if (pixelCoord == 39)
                {
                    Console.Write(Environment.NewLine);
                    pixelCoord = 0;
                }
                else
                {
                    pixelCoord++;
                }
                cycleNumber++;
            }
            if (instruction.StartsWith("addx"))
            {
                var val = int.Parse(instruction.Split(' ')[1]);
                register += val;
            }
        }

        var res = dict.Select(x => x.Key * x.Value).Sum();
        Console.WriteLine(res);
    }
}