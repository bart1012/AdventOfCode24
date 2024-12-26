namespace ConsoleApp1
{
    internal class Day1
    {
        //public static (List<int>, List<int>) ConvertToList(string path)
        //{
        //    List<int> leftList = new();
        //    List<int> rightList = new();
        //    bool leftListSwitch = true;
        //    string input = File.ReadAllText(path);
        //    int digits = CountDigits(input);

        //    var modifiedInput = new string(input.Replace("\r\n", "").Replace(" ", "").Replace("\n", ""));

        //    StringBuilder stringBuilder = new();

        //    int intParse;

        //    for (int i = 1; i <= digits * 2 * 49; i++)
        //    {

        //        stringBuilder.Append(modifiedInput[i - 1]);

        //        if (i % digits == 0)
        //        {
        //            string completedstr = stringBuilder.ToString();
        //            intParse = int.Parse(completedstr);
        //            if (leftListSwitch) { leftList.Add(intParse); leftListSwitch = false; }
        //            else { rightList.Add(intParse); leftListSwitch = true; }
        //            stringBuilder.Clear();
        //        }

        //    }
        //    return (leftList, rightList);
        //}

        public static void Solution_Day1_Part1(string path)
        {
            int result = 0;
            List<int> leftList = new();
            List<int> rightList = new();


            foreach (var line in File.ReadLines(path))
            {
                string modifiedLine = line.Replace("/r", "").Replace("/n", "");
                var splitString = modifiedLine.Split("   ");
                int left = int.Parse(splitString[0]);
                int right = int.Parse(splitString[1]);
                leftList.Add(left);
                rightList.Add(right);
            }

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < leftList.Count; i++)
            {
                result += (Math.Max(leftList[i], rightList[i]) - Math.Min(leftList[i], rightList[i]));
            }
        }

        public static void Solution_Day1_Part2(string path)
        {
            int result = 0;
            List<int> leftList = new();
            List<int> rightList = new();


            foreach (var line in File.ReadLines(path))
            {
                string modifiedLine = line.Replace("/r", "").Replace("/n", "");
                var splitString = modifiedLine.Split("   ");
                int left = int.Parse(splitString[0]);
                int right = int.Parse(splitString[1]);
                leftList.Add(left);
                rightList.Add(right);
            }

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < leftList.Count; i++)
            {
                result += result += leftList[i] * (rightList.Where(x => x == leftList[i]).Count());

            }
        }



    }
}

