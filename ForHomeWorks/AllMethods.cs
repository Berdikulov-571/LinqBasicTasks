using System.Runtime.InteropServices;

namespace ForHomeWorks
{
    public static class AllMethods
    {
        public static void Task1(List<int> numbers)
        {
            var res = numbers.Where(x => x % 2 == 0).ToList();

            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task2(List<int> numbers)
        {
            var res = numbers.Where(x => x >= 0 && x <= 10).ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }

        }

        public static void Task3(List<int> numbers)
        {
            var res = numbers.Select(x => new Task3 { Number = x, Sqrn = x * x }).ToList();

            foreach (var i in res)
            {
                Console.WriteLine($"{i.Number} {i.Sqrn}");
            }
        }

        public static void Task4(List<int> numbers)
        {
            var res = numbers.Distinct().Select(x => new Task4
            {
                Number = x,
                Contains = numbers.Where(y => y == x).ToList().Count()
            }).ToList();

            foreach (var i in res)
            {
                Console.WriteLine($"{i.Number} {i.Contains}");
            }
        }

        public static void Task5(List<char> chars)
        {
            var res = chars.Distinct().Select(x => new Task5
            {
                Number = x,
                Contains = chars.Where(y => y == x).ToList().Count()
            }).ToList();

            foreach (var i in res)
            {
                Console.WriteLine($"{i.Number} {i.Contains}");
            }
        }

        public static void Task6(List<string> weekDays)
        {
            foreach (var i in weekDays)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task8(char startWith,char endWith)
        {
            List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var res = cities.Where(x => x.StartsWith(startWith) && x.EndsWith(endWith)).ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task9(List<int> numbers)
        {
            var res = numbers.Where(x => x >= 80).ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task10(int number)
        {
            List<int> myNumbers = new List<int> { 2,24,23,23,624,2,34,64,35,2,33,6,23,62,4,62,34,43,64,34,23,36,43,63,4,23,4,23};

            var res = myNumbers.Where(x => x > number).ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task11(int number)
        {
            List<int> myNumbers = new List<int> { 2, 24, 23, 23, 624, 2, 34, 64, 35, 2, 33, 6, 23, 62, 4, 62, 34, 43, 64, 34, 23, 36, 43, 63, 4, 23, 4, 23 };

            myNumbers.Sort();

            var res = myNumbers.Take(number);

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task12(List<string> words)
        {
            var res = words.Select(x => x.ToUpper());

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task17(List<char> chars)
        {
            var res = chars.Where(x => x.ToString().ToLower() != "o").ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task18(List<char> chars)
        {
            var res = chars.Where(x => x.ToString().ToLower() != "p").ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task19(List<char> chars)
        {
            var res = chars.Where(x => x.ToString().ToLower() != "q").ToList();

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task20(List<char> chars)
        {
            chars.RemoveAt(3);

            foreach (var i in chars)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task21(List<char> chars)
        {
            chars.RemoveAll(x => x != chars.FirstOrDefault() && x != chars.LastOrDefault());

            foreach (var i in chars)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task22(List<string> chars)
        {
            var resultString = chars.Max(x => x);

            Console.WriteLine(resultString);
        }
    }
    class Task5
    {
        public char Number { get; set; }
        public int Contains { get; set; }
    }
    class Task4
    {
        public int Number { get; set; }
        public int Contains { get; set; }
    }
    class Task3
    {
        public int Number { get; set; }
        public int Sqrn { get; set; }
    }
}
