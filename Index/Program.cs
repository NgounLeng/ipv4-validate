using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(IsValidIPv4(input));
        }

        static bool IsValidIPv4(string input)
        {
            string[] parts = input.Split('.');
            if (parts.Length != 4) return false;
            foreach (string part in parts)
            {
                if (part.Length == 0 || part.Length > 3) return false;
                if (part[0] == '0' && part.Length > 1) return false;
                int num;
                if (!int.TryParse(part, out num)) return false;
                if (num < 0 || num > 255) return false;
            }
            return true;
        }
    }
}
