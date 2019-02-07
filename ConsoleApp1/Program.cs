using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Program : Abs
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Enter the number");
            //var number = Console.ReadLine();
            //int x=SumOfDigits(Convert.ToInt32(number));
            //Console.WriteLine(x);
            //var y = iSArmStrong(Convert.ToInt32(number), x);
            //Console.WriteLine(y);
            //FindPalindrome("nun");
            //
            //StringReverse("i am a boy");
            //justlikethat(0);
            //GetCountOFCahrs("Avinava");
            //GetCountOFStrings("A quick fox jumped over a quick cat");
            //Add();
            //******************Cool code****************

            //Access obj = new Access();
            //obj.cal(2, 3);
            //Console.WriteLine(obj.x);
            //obj.print();

            //******************Cool code****************

            //usingParams(1,2,3,4,"l");
            //using multiline params
            //var multiplineText = "I \nam \ngoing to be \nvery successful";
            //usingParams(multiplineText);

            //*********bubble Sort*********
            //BubbleSort( new[] { 2, 1, 8, 3, 9 });

            //List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var res=findNumber(arr, 5);

            //var odd = oddNumbers(3, 9);

            //int sockMerchantResult = sockMerchant(7, new[] {10,20,10,20,40,20,20 });


            //int result = jumpingOnClouds(new[] { 0,0,0,1,0,0});

            //long result = repeatedString("abcac", 10);

            //MultiplesOF3and5();
            //EvenFibonacci();
            //DifferenceOfSums();


            //Singleton singleton = new Singleton();
            //Singleton singleton = Singleton.GetInstance;
            //singleton.PrintDetails("This is 1st mesg");
            //singleton.PrintDetails("This is second msg");


            ////invoking another instance to see that 2 objects of the class is created

            ////Singleton singletonNew = new Singleton();
            //Singleton singletonNew = Singleton.GetInstance;
            //singletonNew.PrintDetails("This is 1st mesg");
            //singletonNew.PrintDetails("This is second msg");

           NoLetetrsRepeated(new string[] { "I LOVE YOU", "I LOVE MUSTARD" });

            Console.ReadKey();
        }

        public override void absMethod()
        {
            throw new NotImplementedException();
        }

        public static int SumOfDigits(int num)
        {
            if (num > 0)
            {
                int sum = 1;
                while (num / 10 != 0)
                {
                    sum++;
                    num = num / 10;
                }
                return sum;
                var list = new List<int>();
                list.Add(2);
                string goodboy = "i am a good boy";
                goodboy.Reverse();

            }
            else
                return 0;
        }

        public static bool iSArmStrong(int num, int sumOfDigs)
        {
            //double sum = Math.Pow(num%10,sumOfDigs);
            double sum = 0;
            for (int i = 0; i < sumOfDigs; i++)
            {
                num = num / 10;
                var mod = num % 10;
                sum = sum + Math.Pow(mod, sumOfDigs);
            }

            if (sum == num)
            {
                return true;
            }
            return false;
        }

        public static void FindPalindrome(string word)
        {
            var charArray = word.ToCharArray();
            var cloneArray = charArray.Clone();
            Array.Reverse(charArray);
            //bool isEqual = Enumerable.SequenceEqual(cloneArray, charArray);
            //if (charArray.Equals(cloneArray))
            //{
            //    Console.WriteLine("Same");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            for (int i = charArray.Length; i < 0; i--)
            {
                char[] newCharArr = new char[100];
                var c = charArray[i];


            }
        }

        public static string StringReverse(string word)
        {
            var list = new List<char>();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                var c = word[i];
                list.Add(c);
            }
            var stringOCncat = string.Concat(list);
            return stringOCncat;
        }

        public static void justlikethat(int a)
        {
            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (a == 5)
                    {
                        break;
                    }
                    Console.WriteLine(i + j);
                }
            }
        }

        public static void GetCountOFCahrs(string word)
        {
            var letters = word.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in letters)
            {
                dict.TryAdd(item, 0);
                dict[item]++;
            }
        }

        public static void GetCountOFStrings(string sentence)
        {
            var letters = sentence.ToLower().Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in letters)
            {
                dict.TryAdd(item, 0);
                dict[item]++;
            }
        }

        public static void Add()
        {
            string a = "hello";
            string b = null;
            string c = a + b;
            Console.WriteLine(c);
        }


        public static void usingParams(params object[] paramsters)
        {
            var list = new List<T>();


            var toBeSplit = "a am good at studies";
            var store = toBeSplit.Split(" ");
            list.Add(new T { Id = 1, Name = paramsters.ToString() });
            foreach (var item in list)
            {

                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);

            }
        }


        public static void BubbleSort(int[] a) //( new[] { 2, 1, 8, 3, 9 });
        {
            var temp = 0;
            bool flag = true;
            for (int i = 0; i < a.Length - 1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        flag = true;
                    }
                }
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }

        public static string findNumber(List<int> arr, int k)
        {
            if (arr.Contains(k))
                return "YES";
            else
                return "NO";
            //foreach (var item in arr)
            //{

            //}
        }


        public static List<int> oddNumbers(int l, int r)
        {
            var list = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private static int sockMerchant(int n, int[] ar)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in ar)
            {
                dict.TryAdd(item, 0);
                dict[item]++;
            }

            var count = 0;
            foreach (var item in dict)
            {
                var value = item.Value;
                if (value % 2 == 0)
                {
                    count = count + (value / 2);
                }
            }
            return count;
        }

        public static int jumpingOnClouds(int[] c)
        {
            int path = 0;
            bool isValid = true;
            for (int i = 0; i < c.Length - 1 && isValid;)
            {
                try
                {
                    isValid = true;
                    if (c[i + 2] != 1)
                    {
                        i = i + 2;
                        path++;
                    }
                    else
                    {
                        i = i + 1;
                        path++;
                    }
                }
                catch (Exception)
                {
                    path++;
                    isValid = false;
                }

            }
            return path;
        }

        static long repeatedString(string s, long n)
        {
            StringBuilder finalString = new StringBuilder();
            var c = s.ToCharArray();
            for (int i = 0; i <= n && finalString.Length <= n - 1;)
            {
                if (i < c.Length)
                {
                    finalString.Append(c[i]).ToString();
                    i++;
                }
                else
                {
                    i = 0;
                    finalString.Append(c[i]).ToString();
                    i++;
                }
            }
            var getString = finalString.ToString();
            var count = getString.Count(x => x == 'a');

            return count;
        }

        static void MultiplesOF3and5()
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    count = count + i;
                }
            }
        }

        static void EvenFibonacci()
        {
            int oldnum = 0;
            int newNum = 1;
            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                temp = newNum + oldnum;//temp=1 // temp= 1
                Console.WriteLine(temp);
                Console.WriteLine("Sum is {0}", temp + oldnum);
                newNum = oldnum; //newNum= 1//
                oldnum = temp; // temp=0 // oldNum= 2
            }

        }

        static void DifferenceOfSums()
        {
            double sumOfsquares = 0;
            double squaredSums = 0; double diff = 0;
            sumOfsquares = (100 * (100 + 1) * (2 * 100 + 1)) / 6; //n*(n+1)*(2n+1)/6
            squaredSums = Math.Pow(100 * (100 + 1) / 2, 2); //n(n+1)/2
            diff = squaredSums - sumOfsquares;
            Console.WriteLine("Diff is {0}", +diff);
        }

        static void quadraticEquation()
        {
            double a = 1, b = 1, p = 1, q = 1, sum = 0;
            sum = Math.Pow(a, p) + Math.Pow(b, q);
        }

        static void NoLetetrsRepeated(params string[] s)
        {
            //var list = new List<char>();
            //var finalList = new List<string>();
            //foreach (var item in s)
            //{
            //    string table = "";
            //    string result = "";
            //    foreach (char value in item)
            //    {
            //        result+=item.SkipWhile(
            //            x => x.ToString().Contains(value));
            //        //if (table.IndexOf(value) == -1)
            //        //{
            //        //    table += value;
            //        //    result += value;
            //        //}
            //    }
            //}

            var finalList = new List<string>();
            foreach (var item in s)
            {
                var chArr = new List<char>();
                var arr = item.Where(x => x != ' ').ToList();
                var unique = new HashSet<char>(item.Where(x=>x!=' '));
                foreach (var char1 in unique)
                {
                    chArr.Add(char1);
                }
                if (chArr.SequenceEqual(arr))
                {
                    Console.WriteLine(item);
                }
            }

        }

    }

    class Access
    {
        public int x;
        private int y;
        public void cal(int a, int b)
        {
            x = a + 1;
            b = y;
        }
        public void print()
        {
            Console.WriteLine("", +y);
        }
    }

    public abstract class Abs{

        public int MyId { get; set; }

        public abstract void absMethod();
    }

    public sealed class Singleton
    {
        private static int counter = 0;

        public static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Singleton();
                }
                return instance; 
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value is "+counter);
        }
        public void PrintDetails(string msg)
        {   
            Console.WriteLine(msg);
        }


    }
}
