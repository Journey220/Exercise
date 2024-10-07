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
            //Question_3();
            //Question_4();
            //Question_5();
            //Question_6();
            //Question_7();
            //Question_8();
            //Question_9();
            //Question_10();
            //Question_11();
            //Question_12();
            //Question_13(); 
            Question_14();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void Question_1()
        {
            Console.WriteLine("Please Enter 2 numbers this program will sort the greatest value to least value ");
            double[] usr_numbers = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToDouble(Console.ReadLine());
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
                Console.Write($"Please enter number {i + 1} : ");
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
            /*
             * 1234% 1000  => 253 mode[0] = > input - mod = 4000 /1000 =4
                253 % 100 =>53mod[1]  (mod[0] -mod[1]) /100
                53%10 => 3mod[2]
             */
            int user_input;
            int[] mod = new int[4];
            int[] digit = new int[4];
            int sum = 0;
            Console.WriteLine("This program will display sum of your input 4 digits number");
            Console.Write("Enter 4 digit number : ");
            user_input = Convert.ToInt32(Console.ReadLine());
            mod[0] = user_input % 1000;
            digit[0] = (user_input - mod[0]) / 1000;
            mod[1] = mod[0] % 100;
            digit[1] = (mod[0] - mod[1]) / 100;
            mod[2] = mod[0] % 10;
            digit[2] = (mod[1] - mod[2]) / 10;
            digit[3] = mod[2];
            sum = digit.Sum();
            Console.WriteLine($"Your number is {user_input}  and sum of digits is {sum}");
        }// done

        static void Question_5()
        {
            Console.WriteLine("?? Even or Odd ??");
            Console.Write("Please enter number : ");
            int usr_input = 0;
            usr_input = Convert.ToInt32(Console.ReadLine());
            if (usr_input % 2 == 0) { Console.WriteLine($"You enter even number"); }
            else { Console.WriteLine($"You enter odd number"); }
        } //done

        static void Question_6()
        {
            char[] word;
            string usr_word;
            Console.WriteLine("Where is 'a' in your word ");
            Console.Write("Please enter world : ");
            usr_word = Console.ReadLine();
            word = usr_word.ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a') { Console.WriteLine($"'a' in position {i + 1}"); break; }
            }
        } //done

        static void Question_7()
        {
            string usr_input;
            char[] usr_chars;
            Console.WriteLine("Invert lower <> upper");
            Console.WriteLine("Please enter your world : ");
            usr_input = Console.ReadLine();
            usr_chars = usr_input.ToArray();
            for (int i = 0; i < usr_input.Length; i++)
            {
                if (char.IsLower(usr_chars[i])) { usr_chars[i] = char.ToUpper(usr_chars[i]); }
                else if (char.IsUpper(usr_chars[i])) { usr_chars[i] = char.ToLower(usr_chars[i]); }
                else { continue; }
            }
            usr_input = new string(usr_chars);
            Console.WriteLine(usr_input);


        } //done

        static void Question_8()
        {
            string usr_input;
            char[] usr_chars;
            int count = 1;
            Console.WriteLine("How many word ??");
            Console.Write("Enter your word : ");
            usr_input = Console.ReadLine();
            usr_chars = usr_input.ToArray();
            for (int i = 0; i < usr_input.Length; i++)
            {
                if (usr_chars[i] == ' ') { count++; }
            }
            Console.WriteLine($"You have {count} words");
        } //done

        static void Question_9()
        {
            string usr_input;
            int[] user_number = new int[4];
            int count = 0;
            Console.WriteLine("Enter 4 number between 0 to 100 this program will display leasted number and your numbers");
            do
            {
                Console.Write($"Enter number {count + 1} : ");
                usr_input = Console.ReadLine();
                if (Convert.ToInt32(usr_input) < 0 || Convert.ToInt32(usr_input) > 100) { Console.WriteLine("Invalid number !!"); continue; }
                else { user_number[count] = Convert.ToInt32(usr_input); count++; }
            }
            while (count != 4);
            Array.Sort(user_number);
            Console.WriteLine($"Leasted number is :{user_number[0]}");
            Console.WriteLine($"Your numbers is {user_number[0]},{user_number[1]},{user_number[2]},{user_number[3]}");

        } //done

        static void Question_10()
        {
            string usr_input;
            int[] usr_number = new int[4];
            int count = 0;
            Console.WriteLine("!!!4 even numbers!!!");
            Console.WriteLine("Please enter 4 even number program will sort and display greater number");
            do
            {
                Console.Write($"Please enter number {count + 1} : ");
                usr_input = Console.ReadLine();
                if (Convert.ToInt32(usr_input) % 2 != 0) { Console.WriteLine("Invalid number ,Please try again !! "); continue; }
                else { usr_number[count] = Convert.ToInt32(usr_input); count++; }
            } while (count != 4);
            Array.Sort(usr_number);
            Console.WriteLine($"Greated number is {usr_number[0]}");
            Console.WriteLine($"Your numbers is {usr_number[0]},{usr_number[1]},{usr_number[2]},{usr_number[3]}");
        } //done

        static void Question_11()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a second least number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your second least number is : {usr_numbers[1]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();
        } //done

        static void Question_12()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a third least number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your third least number is : {usr_numbers[2]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();

        }

        static void Question_13()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a forth least number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your forth least number is : {usr_numbers[3]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();

        }

        static void Question_14()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a second great number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your second great number is : {usr_numbers[8]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();
        }

        static void Question_15()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a third great number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your third great number is : {usr_numbers[7]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();
        }

        static void Question_16()
        {
            int[] usr_numbers = new int[10];
            Console.WriteLine("This program will display a fourth  great number that you enter ");
            Console.WriteLine("Please enter decimal number ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Please enter number {i + 1} : ");
                usr_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(usr_numbers);
            Console.WriteLine($"Your fourth  great number is : {usr_numbers[6]}");
            Console.Write("Your numbers is : ");
            for (int i = 0; i < 10; i++)
            {
                if (i != 9) { Console.Write($"{usr_numbers[i]} , "); }
                else { Console.Write($"{usr_numbers[i]}"); }
            }
            Console.WriteLine();
        }

        static void Question_17()
        {
            int[,] matrix_a, matrix_b = new int[5, 5];
            int[,] iniatiallizad_matrix_a ={
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 11,12,13,14,15},
                { 16,17,18,19,20},
                { 21,22,23,24,25}
            };
            int[,] iniatiallizad_matrix_b ={
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 11,12,13,14,15},
                { 16,17,18,19,20},
                { 21,22,23,24,25}
            };



            ///Hello world

        }
    }
}
