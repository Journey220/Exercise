using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_001
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            //Question_1();
            //Question_2();
            Question_3();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); 
        }
        static void Question_1()
        {
            Console.WriteLine("Please Enter 2 numbers this program will sort the greatest value to least value ");
            double[] usr_numbers= new double[2] ;
            for (int i = 0; i < 2; i++) 
            {
                Console.Write($"Please enter number {i+1} : ");
                usr_numbers[i]=Convert.ToDouble(Console.ReadLine());
             }
            Array.Sort(usr_numbers);
            Array.Reverse(usr_numbers);
            Console.WriteLine($"Sorted number greatest to least is {usr_numbers[0]} , {usr_numbers[1]}");
        } //done
        static void Question_2()
        {
            double[] usr_numbers = new double[3];
            Console.WriteLine("Please enter 3 numbers this program will return the least number");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Please enter number {i+1} : ");
                usr_numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Leasted number is : {usr_numbers[0]}");
        } //done

        static void Question_3()
        {
            /*
            Rate of income          tax
            0-22,000                   15% of income
            22,000-53,000           3,315.00 + 28% from excess income 22,000
            53,000-115,000         12,107.00 + 31% from excess income 53,000
            115,000-250,000       31,172.00 + 36% from excess income 115,000
            250,000+                 79,772.00 + 39.6% from excess income 250,000
             */
            Console.WriteLine("Tax calculation program");
            Console.Write("Please enter income : ");
            double income = 0;
            double tax = 0;
            income = Convert.ToDouble(Console.ReadLine());
            if (income >= 0 && income <= 22000)
            {
                tax = income * 0.15;
                Console.WriteLine($"Income : {income}\nTax : {tax}");
            }
            else if (income > 22000 && income <= 53000)
            {
                tax = 3315 + (income - 22000) * 0.28;
                Console.WriteLine($"Income : {income}\nTax : {tax}");
            }
            else if (income > 53000 && income <= 115000)
            {
                tax = 12107 + (income - 53000) * 0.31;
                Console.WriteLine($"Income : {income}\nTax : {tax}");
            }
            else if (income > 115000 && income <= 250000)
            {
                tax = 31172 + (income - 115000) * 0.36;
                Console.WriteLine($"Income : {income}\nTax : {tax}");
            }
            else 
            {
                tax = 79772 + (income - 250000) * 0.396;
                Console.WriteLine($"Income : {income}\nTax : {tax}");
            }
            Console.WriteLine("End of program :)");
        } //done

        static void Question_4()
        {
            int user_input;
            Console.WriteLine("This program will display sum of your input 4 digits number");
            Console.Write("Enter 4 digit number : ");
            user_input = Convert.ToInt32(Console.ReadLine());
        }
    }
}
