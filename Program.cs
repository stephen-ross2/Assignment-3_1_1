using System.Text;

namespace Assignment_3_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            namespace Assignment_3_1
    {
        internal class Program
        {
            static void Main(string[] args)

            //Assignment 3.1
            //Write a method that returns a string of even numbers greater than 0 and less than 100. (Use StringBuilder class)


            {
                StringBuilder evenNumbers = new StringBuilder();

                for (int i = 0; i <= 100; i++)

                {
                    if (i % 2 == 0)

                        evenNumbers.Append(i);
                    evenNumbers.Append("-");
                }

                Console.WriteLine(evenNumbers.ToString());
            }
        }
    }
}
    

