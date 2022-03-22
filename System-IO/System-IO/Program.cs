using System;
using System.IO;
using System.Linq;

namespace System_IO
{
    public class Program
    {
        public static int productOfThree(string input)
        {
            string[] data = input.Split(' ');
            if (data.Length < 3) return 0;
            int prodact = 1;
            for (int i = 0; i < 3; i++)
            {
                int num = 0;
                try
                {
                    num = Convert.ToInt32(data[i]);
                }
                catch (FormatException)
                {
                    num = 1;
                }
                prodact *= num;

            }
            return prodact;
        }
        public static void getProduct()
        {
            Console.WriteLine("Enter 3 number separated by space: ");
            string input = Console.ReadLine();
            Console.WriteLine("The product is: "+ productOfThree(input));
        }
        public static decimal Avg(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            try
            {
                return decimal.Divide(sum, arr.Length);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static void getAvg()
        {
            try
            {

                Console.WriteLine("Please enter a number between 2-10: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) throw new Exception("You enterd a negative number: ");
                if (num < 2 && num > 10) throw new IndexOutOfRangeException("You Entered a number out of range: ");
                int[] arr = new int[num];
                for(int i = 0; i < arr.Length; i++)
                {
                Console.WriteLine(i + 1 + " of " + num + " Enter a number: ");
                arr[i]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("The average is: " + Avg(arr)) ;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void starsRender(int n)
        {
            int k = 0;
            for (int i = 0; i < n; i++)
            {

                if (i <= n / 2) k = i;
                else k--;
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n / 2 - k; j++) Console.Write(" ");
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n / 2 - k; j++) Console.Write(" ");
                    for (int j = 1; j <= k * 2 + 1; j++) Console.Write("*");
                    Console.WriteLine();
                }
            }

            
        }
        public static int mostFrequentElement(int[] arr)
        {
            int maxCount = 0;
            int maxNum = 0;
            int currntCount = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) currntCount++;
                }
                if (currntCount > maxCount)
                {
                    maxCount = currntCount;
                    maxNum = arr[i];
                }
                currntCount = 0;
            }
            return maxNum;

        }
        public static int maxNumber(int[] arr)
        {
            int max = arr[0];
            for( int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max) max = arr[i];
            }
            return max;
        }
        public static void writeToFile(String word)
        {
            String filePath = "textFile.txt";
            File.AppendAllText(filePath, " "+word);
        }
        public static void readFromFile() 
        {
            try
            {
                String filePath = "textFile.txt";
                StreamReader streamReader = File.OpenText(filePath);
                String s = streamReader.ReadToEnd();
                Console.WriteLine(s);
                streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine (e.Message);
            }
            
        }
        public static void removeWord(string word)
        {
            try
            {
                String filePath = "textFile.txt";
                String fileContent = File.ReadAllText(filePath);
                string[] contant = fileContent.Split(' ');
                int index = Array.IndexOf(contant, word);
                for (int i = index; i < contant.Length - 1; i++)
                {
                    contant[i] = contant[i + 1];
                }
                File.WriteAllText(filePath, String.Join(" ", contant.SkipLast(1)));

                writeToFile(word);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static string[] characterCounter(string input)
        {
            string[] contant = input.Split(' ');
            string[] output = new string[contant.Length];

            for(int i = 0; i < contant.Length; i++)
            {
                output[i] = contant[i]+ ": " +contant[i].Length;
            }
            return output;
        }
        public static string[] getcharacterCount()
        {
            Console.WriteLine("Please Enter a statement to count each character in each word: ");
            string input = Console.ReadLine();
            return characterCounter(input);
        }

        static void Main(string[] args)
        {
            getProduct();
            getAvg();
            starsRender(9);
            int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            Console.WriteLine("The most frequent element is: " + mostFrequentElement(arr));
            int[]  arr2 = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            Console.WriteLine("The max number is: "+maxNumber(arr2));
            readFromFile();
            writeToFile("samer");
            readFromFile();
            removeWord("ashraf");
            readFromFile();
            string[] output = characterCounter("This is a sentance about important things");
            Console.WriteLine("The count of the characters is: ");
            foreach (string i in output) Console.WriteLine(i);
        }
    }
}
