using System;
using System.Text;

namespace TaskTarget
{
    internal class Program
    {
        static int FirstFunction(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static Dictionary<string, long> SecondFunction(float fnum)
        {
            Dictionary<string, long> dict = new Dictionary<string, long>(){
                { "Pennies", 0 },
                { "Nickels", 0 },
                { "Dimes", 0 },
                { "Quarters", 0 }
            };
            if(fnum <= 0 ) return dict;
            long num = Convert.ToInt64(Math.Floor(fnum));
            dict["Quarters"] = num / 25; num %= 25;
            dict["Dimes"] = num / 10; num %= 10;
            dict["Nickels"] = num / 5; num %= 5;
            dict["Pennies"] = num / 1;

            return dict;
        }
        static long ThirdFunction(UInt64 num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var numchars = num.ToString().ToCharArray().OrderByDescending(x => x);
            foreach(var numchar in numchars)
            {
                stringBuilder.Append(numchar);
            }
            return Convert.ToInt64(stringBuilder.ToString());
        }
        static long FourthFunction(int index)
        {
            return Convert.ToInt64(Math.Pow(index, 3));
        }
        static int FithFunction1()
        {
            //return new List<char> { 'a', 'b', 'c', 'd', 'e' }.Count;
            //return (int)Nums.Five;
            //return new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }.IndexOf('f');
            return 'f' - 'a';
           
        }
        enum Nums
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five
        }
        static void Main(string[] args)
        {
            //FirstFunction(11);
            //var f = 4324324234.935f;
            //Console.WriteLine(f);
            //var d = SecondFunction(f);
            //foreach(var i in d)
            //{
            //    Console.WriteLine($"{i.Key} {i.Value}");
            //}
            //Console.WriteLine(ThirdFunction(23));
            //Console.WriteLine(FourthFunction(99));

            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + "  " + (char)i);
            }
            Console.WriteLine(FithFunction1());
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}