using System.Text;

internal static class Day5
{
    public static void Day5Part1(bool part2)
    {
        var stacks = new List<Stack<char>>()
    {
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>(),
        new Stack<char>()
    };
        var input1 = "                [M]     [V]     [L]\r\n[G]             [V] [C] [G]     [D]\r\n[J]             [Q] [W] [Z] [C] [J]\r\n[W]         [W] [G] [V] [D] [G] [C]\r\n[R]     [G] [N] [B] [D] [C] [M] [W]\r\n[F] [M] [H] [C] [S] [T] [N] [N] [N]\r\n[T] [W] [N] [R] [F] [R] [B] [J] [P]\r\n[Z] [G] [J] [J] [W] [S] [H] [S] [G]\r\n 1   2   3   4   5   6   7   8   9";
        var input2 = "move 1 from 5 to 2\r\nmove 7 from 7 to 1\r\nmove 1 from 1 to 7\r\nmove 1 from 4 to 1\r\nmove 7 from 9 to 1\r\nmove 1 from 3 to 7\r\nmove 4 from 5 to 4\r\nmove 6 from 4 to 9\r\nmove 2 from 7 to 6\r\nmove 6 from 8 to 2\r\nmove 2 from 4 to 5\r\nmove 2 from 3 to 7\r\nmove 11 from 1 to 4\r\nmove 6 from 6 to 1\r\nmove 3 from 5 to 3\r\nmove 5 from 9 to 8\r\nmove 1 from 2 to 3\r\nmove 2 from 7 to 9\r\nmove 7 from 1 to 2\r\nmove 1 from 5 to 3\r\nmove 1 from 5 to 3\r\nmove 5 from 8 to 5\r\nmove 3 from 5 to 4\r\nmove 1 from 1 to 7\r\nmove 1 from 3 to 8\r\nmove 2 from 6 to 3\r\nmove 3 from 3 to 4\r\nmove 1 from 6 to 2\r\nmove 5 from 4 to 2\r\nmove 2 from 5 to 3\r\nmove 2 from 7 to 1\r\nmove 1 from 8 to 1\r\nmove 7 from 1 to 7\r\nmove 4 from 4 to 2\r\nmove 7 from 4 to 1\r\nmove 10 from 1 to 5\r\nmove 10 from 5 to 2\r\nmove 11 from 2 to 3\r\nmove 1 from 1 to 6\r\nmove 1 from 4 to 7\r\nmove 4 from 7 to 1\r\nmove 6 from 2 to 5\r\nmove 2 from 1 to 3\r\nmove 1 from 9 to 5\r\nmove 2 from 9 to 6\r\nmove 1 from 6 to 1\r\nmove 3 from 5 to 4\r\nmove 20 from 3 to 9\r\nmove 3 from 7 to 1\r\nmove 3 from 5 to 2\r\nmove 3 from 4 to 8\r\nmove 3 from 1 to 3\r\nmove 3 from 1 to 2\r\nmove 2 from 6 to 1\r\nmove 10 from 9 to 6\r\nmove 6 from 6 to 7\r\nmove 4 from 6 to 3\r\nmove 11 from 2 to 6\r\nmove 1 from 8 to 9\r\nmove 13 from 2 to 3\r\nmove 1 from 1 to 9\r\nmove 1 from 9 to 4\r\nmove 1 from 8 to 2\r\nmove 1 from 8 to 2\r\nmove 4 from 7 to 8\r\nmove 8 from 6 to 9\r\nmove 3 from 2 to 3\r\nmove 3 from 8 to 4\r\nmove 11 from 9 to 2\r\nmove 7 from 9 to 6\r\nmove 1 from 1 to 5\r\nmove 4 from 4 to 9\r\nmove 21 from 3 to 1\r\nmove 1 from 3 to 9\r\nmove 7 from 6 to 3\r\nmove 6 from 1 to 2\r\nmove 13 from 1 to 5\r\nmove 2 from 1 to 2\r\nmove 3 from 9 to 3\r\nmove 2 from 2 to 3\r\nmove 2 from 6 to 4\r\nmove 3 from 3 to 5\r\nmove 13 from 5 to 2\r\nmove 5 from 3 to 4\r\nmove 2 from 7 to 9\r\nmove 2 from 4 to 2\r\nmove 1 from 3 to 8\r\nmove 1 from 6 to 1\r\nmove 4 from 3 to 7\r\nmove 2 from 5 to 7\r\nmove 1 from 7 to 2\r\nmove 1 from 5 to 9\r\nmove 4 from 7 to 8\r\nmove 1 from 1 to 9\r\nmove 6 from 8 to 1\r\nmove 4 from 4 to 8\r\nmove 25 from 2 to 9\r\nmove 1 from 4 to 3\r\nmove 1 from 3 to 7\r\nmove 4 from 8 to 1\r\nmove 1 from 7 to 4\r\nmove 3 from 1 to 6\r\nmove 5 from 2 to 1\r\nmove 1 from 5 to 1\r\nmove 1 from 4 to 1\r\nmove 24 from 9 to 6\r\nmove 9 from 1 to 6\r\nmove 1 from 5 to 6\r\nmove 1 from 1 to 9\r\nmove 1 from 2 to 8\r\nmove 1 from 8 to 1\r\nmove 3 from 1 to 8\r\nmove 36 from 6 to 3\r\nmove 2 from 7 to 3\r\nmove 1 from 2 to 5\r\nmove 1 from 5 to 2\r\nmove 1 from 6 to 2\r\nmove 10 from 3 to 2\r\nmove 3 from 8 to 2\r\nmove 1 from 1 to 7\r\nmove 2 from 2 to 6\r\nmove 10 from 9 to 1\r\nmove 2 from 6 to 4\r\nmove 13 from 3 to 4\r\nmove 8 from 3 to 7\r\nmove 8 from 1 to 2\r\nmove 5 from 3 to 8\r\nmove 3 from 1 to 9\r\nmove 1 from 7 to 1\r\nmove 7 from 4 to 5\r\nmove 1 from 1 to 2\r\nmove 14 from 2 to 6\r\nmove 2 from 7 to 2\r\nmove 8 from 4 to 8\r\nmove 3 from 7 to 9\r\nmove 2 from 9 to 8\r\nmove 2 from 7 to 1\r\nmove 1 from 7 to 8\r\nmove 1 from 6 to 8\r\nmove 1 from 9 to 3\r\nmove 4 from 2 to 7\r\nmove 6 from 6 to 1\r\nmove 3 from 1 to 9\r\nmove 1 from 1 to 7\r\nmove 6 from 5 to 6\r\nmove 1 from 5 to 2\r\nmove 1 from 6 to 8\r\nmove 5 from 7 to 5\r\nmove 1 from 2 to 9\r\nmove 2 from 3 to 4\r\nmove 9 from 8 to 4\r\nmove 8 from 4 to 8\r\nmove 6 from 6 to 7\r\nmove 5 from 6 to 4\r\nmove 7 from 9 to 7\r\nmove 7 from 8 to 7\r\nmove 5 from 8 to 4\r\nmove 3 from 1 to 6\r\nmove 1 from 2 to 7\r\nmove 1 from 1 to 4\r\nmove 4 from 5 to 2\r\nmove 2 from 6 to 9\r\nmove 1 from 3 to 7\r\nmove 1 from 5 to 1\r\nmove 1 from 8 to 9\r\nmove 1 from 6 to 1\r\nmove 1 from 2 to 7\r\nmove 2 from 8 to 1\r\nmove 2 from 1 to 8\r\nmove 3 from 2 to 4\r\nmove 1 from 6 to 1\r\nmove 17 from 4 to 1\r\nmove 3 from 2 to 7\r\nmove 13 from 7 to 8\r\nmove 1 from 2 to 6\r\nmove 14 from 1 to 4\r\nmove 2 from 8 to 5\r\nmove 1 from 9 to 7\r\nmove 2 from 5 to 4\r\nmove 1 from 9 to 3\r\nmove 5 from 1 to 5\r\nmove 3 from 4 to 1\r\nmove 1 from 3 to 2\r\nmove 7 from 4 to 5\r\nmove 9 from 7 to 8\r\nmove 5 from 4 to 2\r\nmove 1 from 1 to 3\r\nmove 1 from 9 to 2\r\nmove 15 from 8 to 6\r\nmove 1 from 3 to 7\r\nmove 11 from 6 to 5\r\nmove 1 from 4 to 8\r\nmove 3 from 1 to 7\r\nmove 5 from 7 to 5\r\nmove 27 from 5 to 1\r\nmove 8 from 8 to 4\r\nmove 1 from 2 to 6\r\nmove 3 from 6 to 1\r\nmove 9 from 1 to 5\r\nmove 5 from 5 to 7\r\nmove 2 from 2 to 1\r\nmove 2 from 5 to 4\r\nmove 6 from 7 to 6\r\nmove 1 from 5 to 2\r\nmove 1 from 7 to 8\r\nmove 4 from 6 to 8\r\nmove 5 from 6 to 3\r\nmove 1 from 7 to 1\r\nmove 5 from 4 to 3\r\nmove 6 from 8 to 2\r\nmove 1 from 7 to 8\r\nmove 2 from 8 to 9\r\nmove 10 from 3 to 5\r\nmove 9 from 5 to 2\r\nmove 3 from 4 to 8\r\nmove 1 from 5 to 7\r\nmove 2 from 9 to 7\r\nmove 2 from 8 to 3\r\nmove 1 from 3 to 8\r\nmove 19 from 1 to 7\r\nmove 4 from 2 to 7\r\nmove 2 from 4 to 3\r\nmove 3 from 3 to 2\r\nmove 2 from 8 to 3\r\nmove 2 from 5 to 8\r\nmove 1 from 2 to 3\r\nmove 2 from 8 to 3\r\nmove 5 from 2 to 5\r\nmove 9 from 7 to 5\r\nmove 13 from 5 to 9\r\nmove 7 from 2 to 6\r\nmove 2 from 6 to 9\r\nmove 1 from 2 to 1\r\nmove 5 from 6 to 7\r\nmove 1 from 5 to 7\r\nmove 6 from 1 to 2\r\nmove 5 from 3 to 6\r\nmove 6 from 7 to 2\r\nmove 3 from 6 to 4\r\nmove 3 from 7 to 4\r\nmove 12 from 7 to 6\r\nmove 5 from 4 to 1\r\nmove 2 from 7 to 4\r\nmove 3 from 4 to 6\r\nmove 16 from 6 to 3\r\nmove 4 from 1 to 4\r\nmove 1 from 1 to 9\r\nmove 3 from 9 to 2\r\nmove 1 from 4 to 6\r\nmove 9 from 3 to 7\r\nmove 2 from 6 to 3\r\nmove 3 from 3 to 9\r\nmove 15 from 2 to 7\r\nmove 19 from 7 to 4\r\nmove 15 from 9 to 2\r\nmove 16 from 2 to 8\r\nmove 6 from 3 to 5\r\nmove 4 from 7 to 5\r\nmove 15 from 8 to 7\r\nmove 19 from 4 to 2\r\nmove 1 from 8 to 3\r\nmove 16 from 2 to 1\r\nmove 9 from 7 to 6\r\nmove 7 from 2 to 8\r\nmove 2 from 2 to 7\r\nmove 1 from 9 to 5\r\nmove 1 from 3 to 4\r\nmove 6 from 1 to 2\r\nmove 8 from 5 to 1\r\nmove 1 from 5 to 1\r\nmove 18 from 1 to 8\r\nmove 7 from 7 to 5\r\nmove 7 from 5 to 3\r\nmove 4 from 3 to 6\r\nmove 13 from 8 to 5\r\nmove 12 from 8 to 1\r\nmove 5 from 1 to 6\r\nmove 15 from 5 to 4\r\nmove 1 from 1 to 6\r\nmove 12 from 6 to 3\r\nmove 8 from 3 to 4\r\nmove 2 from 7 to 3\r\nmove 9 from 3 to 1\r\nmove 5 from 2 to 9\r\nmove 16 from 4 to 3\r\nmove 10 from 1 to 3\r\nmove 2 from 1 to 5\r\nmove 1 from 3 to 1\r\nmove 5 from 6 to 1\r\nmove 4 from 9 to 3\r\nmove 1 from 2 to 8\r\nmove 1 from 8 to 1\r\nmove 1 from 9 to 8\r\nmove 2 from 5 to 9\r\nmove 9 from 4 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 6 to 8\r\nmove 3 from 8 to 5\r\nmove 2 from 1 to 5\r\nmove 2 from 9 to 8\r\nmove 1 from 8 to 6\r\nmove 2 from 5 to 3\r\nmove 19 from 3 to 1\r\nmove 2 from 4 to 2\r\nmove 1 from 5 to 6\r\nmove 2 from 2 to 3\r\nmove 1 from 8 to 6\r\nmove 8 from 3 to 9\r\nmove 6 from 3 to 7\r\nmove 2 from 6 to 2\r\nmove 1 from 6 to 1\r\nmove 1 from 1 to 8\r\nmove 1 from 8 to 9\r\nmove 1 from 7 to 3\r\nmove 19 from 1 to 5\r\nmove 21 from 5 to 2\r\nmove 13 from 2 to 6\r\nmove 13 from 1 to 8\r\nmove 7 from 9 to 7\r\nmove 2 from 9 to 2\r\nmove 10 from 8 to 3\r\nmove 1 from 1 to 6\r\nmove 10 from 2 to 4\r\nmove 11 from 3 to 5\r\nmove 8 from 5 to 6\r\nmove 1 from 3 to 7\r\nmove 2 from 8 to 6\r\nmove 2 from 2 to 8\r\nmove 3 from 7 to 6\r\nmove 2 from 8 to 6\r\nmove 1 from 1 to 2\r\nmove 24 from 6 to 5\r\nmove 2 from 3 to 8\r\nmove 1 from 8 to 6\r\nmove 7 from 7 to 9\r\nmove 4 from 6 to 9\r\nmove 1 from 8 to 9\r\nmove 21 from 5 to 9\r\nmove 2 from 7 to 2\r\nmove 1 from 8 to 5\r\nmove 1 from 7 to 3\r\nmove 12 from 9 to 6\r\nmove 6 from 6 to 3\r\nmove 12 from 9 to 4\r\nmove 4 from 5 to 6\r\nmove 13 from 4 to 2\r\nmove 8 from 4 to 8\r\nmove 10 from 6 to 8\r\nmove 11 from 8 to 9\r\nmove 4 from 8 to 4\r\nmove 2 from 4 to 3\r\nmove 8 from 3 to 8\r\nmove 2 from 6 to 8\r\nmove 1 from 3 to 8\r\nmove 6 from 2 to 4\r\nmove 1 from 4 to 8\r\nmove 1 from 9 to 7\r\nmove 13 from 8 to 4\r\nmove 1 from 7 to 1\r\nmove 1 from 1 to 4\r\nmove 8 from 4 to 7\r\nmove 3 from 5 to 7\r\nmove 19 from 9 to 7\r\nmove 3 from 2 to 7\r\nmove 1 from 8 to 2\r\nmove 13 from 7 to 6\r\nmove 1 from 2 to 4\r\nmove 4 from 6 to 2\r\nmove 1 from 8 to 3\r\nmove 7 from 6 to 8\r\nmove 1 from 6 to 2\r\nmove 1 from 2 to 7\r\nmove 9 from 2 to 3\r\nmove 1 from 6 to 2\r\nmove 21 from 7 to 5\r\nmove 9 from 5 to 3\r\nmove 19 from 3 to 9\r\nmove 5 from 8 to 5\r\nmove 2 from 2 to 1\r\nmove 2 from 1 to 8\r\nmove 6 from 4 to 5\r\nmove 3 from 8 to 7\r\nmove 15 from 9 to 2\r\nmove 2 from 2 to 5\r\nmove 3 from 9 to 6\r\nmove 5 from 4 to 5\r\nmove 11 from 2 to 6\r\nmove 1 from 8 to 6\r\nmove 1 from 9 to 5\r\nmove 1 from 7 to 3\r\nmove 6 from 5 to 6\r\nmove 1 from 4 to 6\r\nmove 1 from 3 to 4\r\nmove 13 from 5 to 2\r\nmove 16 from 6 to 9\r\nmove 4 from 4 to 5\r\nmove 2 from 6 to 2\r\nmove 2 from 6 to 4\r\nmove 2 from 4 to 5\r\nmove 2 from 7 to 8\r\nmove 2 from 6 to 3\r\nmove 2 from 5 to 8\r\nmove 14 from 5 to 7\r\nmove 4 from 8 to 1\r\nmove 4 from 1 to 6\r\nmove 1 from 3 to 9\r\nmove 1 from 6 to 1\r\nmove 2 from 7 to 3\r\nmove 2 from 3 to 7\r\nmove 2 from 5 to 2\r\nmove 9 from 9 to 2\r\nmove 13 from 7 to 3\r\nmove 12 from 3 to 9\r\nmove 2 from 6 to 8\r\nmove 14 from 2 to 9\r\nmove 2 from 8 to 9\r\nmove 10 from 2 to 1\r\nmove 1 from 7 to 4\r\nmove 2 from 3 to 8\r\nmove 4 from 2 to 1\r\nmove 1 from 8 to 3\r\nmove 1 from 2 to 6\r\nmove 1 from 8 to 3\r\nmove 4 from 9 to 4\r\nmove 1 from 3 to 5\r\nmove 1 from 5 to 1\r\nmove 1 from 3 to 9\r\nmove 12 from 1 to 8\r\nmove 10 from 8 to 5\r\nmove 7 from 5 to 6\r\nmove 1 from 1 to 9\r\nmove 3 from 5 to 1\r\nmove 1 from 1 to 3\r\nmove 16 from 9 to 7\r\nmove 4 from 4 to 3\r\nmove 1 from 4 to 9\r\nmove 15 from 7 to 8\r\nmove 15 from 9 to 1\r\nmove 8 from 1 to 6\r\nmove 1 from 9 to 3\r\nmove 17 from 6 to 2\r\nmove 1 from 9 to 1\r\nmove 15 from 2 to 7\r\nmove 14 from 8 to 9\r\nmove 12 from 7 to 9\r\nmove 12 from 9 to 3\r\nmove 3 from 7 to 9\r\nmove 1 from 7 to 4\r\nmove 7 from 9 to 6\r\nmove 1 from 4 to 6\r\nmove 11 from 9 to 6\r\nmove 2 from 1 to 2\r\nmove 18 from 6 to 4\r\nmove 4 from 2 to 7\r\nmove 2 from 7 to 3\r\nmove 2 from 7 to 8\r\nmove 4 from 1 to 5\r\nmove 1 from 9 to 2\r\nmove 2 from 5 to 4\r\nmove 5 from 1 to 3\r\nmove 2 from 3 to 7\r\nmove 2 from 3 to 9\r\nmove 1 from 6 to 7\r\nmove 1 from 2 to 9\r\nmove 2 from 8 to 1\r\nmove 3 from 1 to 3\r\nmove 2 from 5 to 8\r\nmove 2 from 3 to 5\r\nmove 1 from 5 to 2\r\nmove 1 from 1 to 3\r\nmove 1 from 9 to 2\r\nmove 1 from 9 to 1\r\nmove 3 from 7 to 6\r\nmove 1 from 1 to 9\r\nmove 2 from 8 to 9\r\nmove 1 from 2 to 3\r\nmove 2 from 8 to 2\r\nmove 2 from 6 to 5\r\nmove 1 from 8 to 5\r\nmove 3 from 2 to 5\r\nmove 3 from 4 to 8\r\nmove 1 from 8 to 2\r\nmove 3 from 9 to 7\r\nmove 3 from 7 to 1\r\nmove 1 from 9 to 6\r\nmove 3 from 1 to 2\r\nmove 2 from 8 to 7\r\nmove 2 from 7 to 9\r\nmove 2 from 6 to 5\r\nmove 3 from 5 to 3\r\nmove 1 from 2 to 5\r\nmove 3 from 2 to 7\r\nmove 2 from 5 to 6\r\nmove 15 from 4 to 9\r\nmove 1 from 3 to 1\r\nmove 25 from 3 to 4\r\nmove 3 from 7 to 3\r\nmove 5 from 9 to 5\r\nmove 10 from 9 to 5\r\nmove 9 from 5 to 1\r\nmove 5 from 5 to 2\r\nmove 1 from 6 to 7\r\nmove 5 from 5 to 8";
        var a = input1
            .Split("\r\n")
            .Select(x =>
            {
                if (x[0] == ' ')
                    return x.Remove(0, 1);
                return x;
            })
            .Select(x => x
                .Replace(" [", string.Empty)
                .Replace("] ", string.Empty)
                .Replace("]", string.Empty)
                .Replace("[", string.Empty)
                .Replace("   ", "0")
            )
            .Reverse()
            .Skip(1)
            .ToList();

        foreach (var line in a)
        {
            var blocks = line.Replace(" ", string.Empty);
            var currentStack = 0;
            foreach (var block in blocks)
            {
                if (block != '0')
                {
                    stacks[currentStack].Push(block);
                }
                currentStack++;
            }
        }

        var b = input2
            .Split("\r\n");
        foreach (var line in b)
        {
            var words = line.Split(" ");
            var count = int.Parse(words[1]);
            var source = int.Parse(words[3]) - 1;
            var dest = int.Parse(words[5]) - 1;

            if (part2)
            {
                var blocks = new List<char>();
                for (var i = 0; i < count; i++)
                {
                    blocks.Add(stacks[source].Pop());
                }
                blocks.Reverse();
                foreach (var block in blocks)
                {
                    stacks[dest].Push(block);
                }
            }
            else
            {
                for (var i = 0; i < count; i++)
                {
                    var block = stacks[source].Pop();
                    stacks[dest].Push(block);
                }
            }
        }

        var res = new StringBuilder();
        foreach (var stack in stacks)
        {
            res.Append(stack.Peek());
        }

        Console.WriteLine(res.ToString());
    }
}