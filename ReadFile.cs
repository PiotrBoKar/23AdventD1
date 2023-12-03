using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23AdventD1
{
    internal class ReadFile
    {
        public static List<string[]> getList(string dName)
        {
            string path = @"c:\AdventOfCode\" + dName + ".txt";
            string[] text = File.ReadAllLines(path);
            List<string[]> strLines = new List<string[]>();
            for (int i = 0; i < text.Length; i++)
            {

                strLines.Add(text[i].Split(' '));

            }
            return strLines;
        }
    }
}
