using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Demo
{
    public static class NullCoalescingAssignmentDemo
    {
        public static void Demo()
        {
            var example = new ListDemo();
            // throws compile time error
            //example.LuckyNumbers.Add(15);

            //if (example.LuckyNumbers == null) {
            //    example.LuckyNumbers = new List<int>();
            //}

            example.LuckyNumbers ??= new List<int>();

            example.LuckyNumbers.Add(15);
                        
            foreach (var item in example.LuckyNumbers)
            {
                Console.WriteLine($"Lucky number is {item}");
            }

        }
    }

    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }
        //public ListDemo()
        //{
        //    LuckyNumbers = new List<int> { 9};
        //}
    }
}
