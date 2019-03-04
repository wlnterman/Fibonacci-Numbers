using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double current = 0;
            var nums = new List<double> { 1, 1 };
            for(int i=2;i<20;i++)
            {
                var prev1 = nums[nums.Count - 1];
                var prev2 = nums[nums.Count - 2];
                nums.Add(current = prev1+prev2);           
            }
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
