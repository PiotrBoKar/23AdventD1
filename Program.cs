using System.Text;



namespace _23AdventD1
{
    public class dayOne23
    {
        public static void Main()
        {
            List<String[]> input = ReadFile.getList("23D1");
            List<int> index = new List<int>();
            int addNums = 0;
            string convert;
            string makeNum;
            char[] numChar;
            string[] dictionary = new string[] {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] translator = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            for (int i = 0; i < input.Count; i++)
            {
                convert = String.Join("", input[i]);
                numChar = convert.ToCharArray();
                for (int j = 0; j < numChar.Length; j++)
                {
                    for (int d = 0; d < dictionary.Length; d++)
                    {
                        if (convert.Contains(dictionary[d], StringComparison.OrdinalIgnoreCase))
                        {
                            convert = convert.Insert(convert.IndexOf(dictionary[d]) + 1, translator[d]);
                        }
                    }
                }
                numChar = convert.ToCharArray();
                for (int j = 0; j < numChar.Length; j++)
                {
                    if (char.IsNumber(numChar[j]))
                    {   
                        index.Add(j);
                    }
                }
                makeNum = numChar[index.Min()].ToString() + numChar[index.Max()].ToString();
                addNums = addNums + Int32.Parse(makeNum);
                index.Clear();
            }
            Console.WriteLine(addNums.ToString());

        }


    }
}
