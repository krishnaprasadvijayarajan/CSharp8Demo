using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Demo
{
    public static class IndicesAndRanges
    {
        public static void Demo()
        {
            var places = new string[] { "first", "second", "third", "fourth", "fifth" };
            Console.WriteLine($"The last item in the list is {{places[^1]}}");
            Console.WriteLine($"The second last item in the list is {{places[^2]}}");
            Console.WriteLine();
            Console.WriteLine("Places 2 and 3 - 2..4 indicates index position 2 until 4 (not including it)");
            foreach (var item in places[2..4])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Places 1 to 3 - 1..^1 indicates index position 1 until last item (not including it)");
            foreach (var item in places[1..^1])
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Places 0 to 3 - ..^1 indicates index position 0 until last item (not including it)");
            foreach (var item in places[..^1])
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Places 1 to last - 1.. indicates index position 1 until last item ");
            foreach (var item in places[1..])
            {
                Console.WriteLine(item);
            }
        }
    }
}
