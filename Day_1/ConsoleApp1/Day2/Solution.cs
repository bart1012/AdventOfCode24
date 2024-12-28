namespace Day2
{
    internal class Solution
    {
        public static void FindSafeReports()
        {
            int safeReports = 0;
            bool differenceWithinRange = true;

            foreach (var line in File.ReadLines("./input.txt"))
            {
                differenceWithinRange = true;
                Console.WriteLine();
                List<int> lineNumbers = line.Replace("/n", "").Split(" ").Select(x => int.Parse(x)).ToList();
                //lineNumbers.ForEach(x => Console.Write(x + " "));
                List<int> lineNumAscending = lineNumbers.OrderBy(n => n).Distinct().ToList();
                List<int> lineNumDescending = lineNumbers.OrderByDescending(n => n).Distinct().ToList();

                if (lineNumbers.SequenceEqual(lineNumAscending) || lineNumbers.SequenceEqual(lineNumDescending))
                {
                    for (global::System.Int32 i = 0; i < lineNumbers.Count - 1; i++)
                    {
                        int difference = Math.Max(lineNumbers[i], lineNumbers[i + 1]) - Math.Min(lineNumbers[i], lineNumbers[i + 1]);
                        if (difference < 1 || difference > 3)
                        {
                            differenceWithinRange = false;
                            break;
                        }
                    }

                    if (differenceWithinRange) { safeReports++; }

                }
                else
                {
                    continue;
                }


            }

            Console.WriteLine(safeReports + "!");
        }

        public static void FindSafeReports_part2()
        {
            int safeReports = 0;
            int faults = 0;
            int difference = 0;

            foreach (var line in File.ReadLines("./input.txt"))
            {
                faults = 0;
                List<int> lineNumbers = line.Replace("/n", "").Split(" ").Select(x => int.Parse(x)).ToList();
                faults += lineNumbers.Count() - lineNumbers.Distinct().Count();
                List<int> noDuplicateNums = lineNumbers.Distinct().ToList();
                bool isAscending = noDuplicateNums[0] < noDuplicateNums[noDuplicateNums.Count - 1];
                for (global::System.Int32 i = 0; i < noDuplicateNums.Count - 1; i++)
                {
                    difference = isAscending ? noDuplicateNums[i + 1] - noDuplicateNums[i] : noDuplicateNums[i] - noDuplicateNums[i + 1];
                    if (difference < 1 || difference > 3)
                    {
                        faults++;
                    }
                }

                if (faults <= 1) safeReports++;

            }

            Console.WriteLine(safeReports + "!");
        }


    }
}
