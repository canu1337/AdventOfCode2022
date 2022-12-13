namespace AdventOfCode;

internal static class Day11
{
    private static readonly string input = "Monkey 0:\r\n  Starting items: 79, 98\r\n  Operation: new = old * 19\r\n  Test: divisible by 23\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3\r\n\r\nMonkey 1:\r\n  Starting items: 54, 65, 75, 74\r\n  Operation: new = old + 6\r\n  Test: divisible by 19\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 79, 60, 97\r\n  Operation: new = old * old\r\n  Test: divisible by 13\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 3\r\n\r\nMonkey 3:\r\n  Starting items: 74\r\n  Operation: new = old + 3\r\n  Test: divisible by 17\r\n    If true: throw to monkey 0\r\n    If false: throw to monkey 1";
    //private static readonly string input = "Monkey 0:\r\n  Starting items: 83, 97, 95, 67\r\n  Operation: new = old * 19\r\n  Test: divisible by 17\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 7\r\n\r\nMonkey 1:\r\n  Starting items: 71, 70, 79, 88, 56, 70\r\n  Operation: new = old + 2\r\n  Test: divisible by 19\r\n    If true: throw to monkey 7\r\n    If false: throw to monkey 0\r\n\r\nMonkey 2:\r\n  Starting items: 98, 51, 51, 63, 80, 85, 84, 95\r\n  Operation: new = old + 7\r\n  Test: divisible by 7\r\n    If true: throw to monkey 4\r\n    If false: throw to monkey 3\r\n\r\nMonkey 3:\r\n  Starting items: 77, 90, 82, 80, 79\r\n  Operation: new = old + 1\r\n  Test: divisible by 11\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 4\r\n\r\nMonkey 4:\r\n  Starting items: 68\r\n  Operation: new = old * 5\r\n  Test: divisible by 13\r\n    If true: throw to monkey 6\r\n    If false: throw to monkey 5\r\n\r\nMonkey 5:\r\n  Starting items: 60, 94\r\n  Operation: new = old + 5\r\n  Test: divisible by 3\r\n    If true: throw to monkey 1\r\n    If false: throw to monkey 0\r\n\r\nMonkey 6:\r\n  Starting items: 81, 51, 85\r\n  Operation: new = old * old\r\n  Test: divisible by 5\r\n    If true: throw to monkey 5\r\n    If false: throw to monkey 1\r\n\r\nMonkey 7:\r\n  Starting items: 98, 81, 63, 65, 84, 71, 84\r\n  Operation: new = old + 3\r\n  Test: divisible by 2\r\n    If true: throw to monkey 2\r\n    If false: throw to monkey 3";

    // gonna need more than a long here :/
    public static void DoThing(bool part2 = false)
    {
        var numberOfRounds = !part2 ? 20 : 10_000;
        var monkeysString = input.Split("\r\n\r\n");
        var monkeys = new List<Monkey>();
        foreach (var st in monkeysString)
        {
            var lines = st.Split("\r\n");
            var monkey = new Monkey
            {
                Items = lines[1].Split(":")[1].Split(",").Select(x => int.Parse(x.Trim())).ToList(),
                DivideByTest = int.Parse(lines[3].Split(" ")[5]),
                ThrowToIfTrue = int.Parse(lines[4].Split(" ")[9]),
                ThrowToIfFalse = int.Parse(lines[5].Split(" ")[9])
            };
            var operationString = lines[2].Split(" ");
            if (operationString[7] == "old")
            {
                switch (operationString[6])
                {
                    case "+":
                        monkey.Operation = (number) => number + number;
                        break;

                    case "-":
                        monkey.Operation = (number) => number - number;
                        break;

                    case "*":
                        monkey.Operation = (number) => number * number;
                        break;

                    case "/":
                        monkey.Operation = (number) => number / number;
                        break;
                }
            }
            else
            {
                var operationNumber = int.Parse(operationString[7]);
                switch (operationString[6])
                {
                    case "+":
                        monkey.Operation = (number) => number + operationNumber;
                        break;

                    case "-":
                        monkey.Operation = (number) => number - operationNumber;
                        break;

                    case "*":
                        monkey.Operation = (number) => number * operationNumber;
                        break;

                    case "/":
                        monkey.Operation = (number) => number / operationNumber;
                        break;
                }
            }
            monkeys.Add(monkey);
        }

        for (var i = 0; i < numberOfRounds; i++)
        {
            foreach (var monkey in monkeys)
            {
                foreach (var item in monkey.Items)
                {
                    var newItem = item;
                    monkey.ItemsExamined++;
                    // examination by monkey
                    newItem = monkey.Operation(item);
                    // relief because it's not broken
                    if (!part2)
                    {
                        newItem /= 3;
                    }
                    // test to which monkey to throw
                    var monkeyToThrowTo = newItem % monkey.DivideByTest == 0 ? monkey.ThrowToIfTrue : monkey.ThrowToIfFalse;
                    monkeys[monkeyToThrowTo].Items.Add(newItem);
                }
                monkey.Items.Clear();
            }
        }

        var res = monkeys.OrderByDescending(x => x.ItemsExamined).Take(2).Select(x => x.ItemsExamined).ToList();
        var a = res[0] * res[1];

        Console.WriteLine(a);
    }

    private class Monkey
    {
        public List<int> Items { get; set; }
        public Func<int, int> Operation { get; set; }
        public int DivideByTest { get; set; }
        public int ThrowToIfTrue { get; set; }
        public int ThrowToIfFalse { get; set; }
        public double ItemsExamined { get; set; }
    }
}