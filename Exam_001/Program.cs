using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            //Question_14();
            //Question_15();
            //Question_16();
            //Question_17();
            //Question_18();
            //Question_19();
            //Question_20();
            //Question_21();
            //Question_22();
            Question_23();
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
            int usr_input = 0;
            Console.WriteLine("!!!Matrix 5 x 5 multiplication!!!");
            //Console.WriteLine("Option 1 for simple or 2 for enter your own matrix");
            //Console.Write("Choose 1 or 2 : ");
            //usr_input = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] matrix_a = new int[5, 5];
            int[,] matrix_b = new int[5, 5];
            int[,] matrix_sum = new int[5, 5];
            int mode = 0;
            do
            {
                if (mode == 1) { Console.WriteLine("\nX\n"); }
                if (mode == 2) { Console.WriteLine("\nResult is :\n"); }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < 5; j++)
                    {
                        if (mode == 0)
                        {
                            matrix_a[i, j] = random.Next(0, 10);
                            matrix_b[i, j] = random.Next(0, 10);
                            matrix_sum[i, j] = matrix_a[i, j];
                            Console.Write($"{matrix_sum[i, j]} ");
                        }
                        else if (mode == 1)
                        {
                            matrix_sum[i, j] = matrix_b[i, j];
                            Console.Write($"{matrix_sum[i, j]} ");
                        }
                        else
                        {
                            matrix_sum[i, j] = 0;
                            for (int k = 0; k < 5; k++)
                            {
                                matrix_sum[i, j] += matrix_a[i, k] * matrix_b[k, j];
                            }
                            Console.Write($"{matrix_sum[i, j]} ");
                        }
                    }
                    Console.Write("]");
                    Console.WriteLine();
                }
                mode++;
            } while (mode != 3);
            Console.WriteLine();
        }

        static void Question_18()
        {
            Random random = new Random();
            int[,] matrix_source = new int[5,5];
            int[,] matrix_result = new int[5, 5];
            int mode = 0;
            do
            {
                if (mode == 1) { Console.WriteLine(); }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < 5; j++)
                    {
                        if (mode == 0)
                        {
                            matrix_source[i, j] = random.Next(0, 10);
                            matrix_result[i,j] = matrix_source[i, j];
                            Console.Write($"{matrix_source[i, j]} ");
                        }
                        else
                        {
                            matrix_result[i, j] = matrix_source[j, i];
                            Console.Write($"{matrix_result[i, j]} ");
                        }
                    }
                    Console.Write("]");
                    Console.WriteLine();
                }
                mode++;
            }while(mode <2);

            


        }

        static void Question_19() 
        {
            Console.WriteLine("Average value of n numbers between 10 - 30 ");
            Console.WriteLine("Enter * for exit the program :");
            int count = 0;
            double sum=0;
            string usr_input;
            do
            {
                Console.Write("Enter number : ");
                usr_input = Console.ReadLine();
                if (usr_input == "*") { break; }
                if (double.TryParse(usr_input, out double number) )
                {
                    
                    sum+=(double)number;
                    count++;
                }
                else { Console.WriteLine("Error invalid input !!"); }
                
            }
            while (usr_input != "*");
            Console.WriteLine("Asterisk is activated ");
            Console.WriteLine($"You enter {count} total numbers\nAverage value is :{sum/count}");

        }

        static void Question_20() 
        {
            Console.WriteLine("Least value of n numbers that you enter between 10 - 30 ");
            Console.WriteLine("Enter * for exit the program :");
            int count = 0;
            List<double> data= new List<double>();
            string usr_input;
            do
            {
                Console.Write("Enter number : ");
                usr_input = Console.ReadLine();
                if (usr_input == "*") { break; }
                if (double.TryParse(usr_input, out double number))
                {

                    data.Add(number);
                    count++;
                }
                else { Console.WriteLine("Error invalid input !!"); }

            }
            while (usr_input != "*");
            data.Sort();
            Console.WriteLine("Asterisk is activated ");
            if (string.IsNullOrEmpty(usr_input)) { Console.WriteLine($"You enter {count} total numbers\nLeast value is :{data[0]}"); }


        }

        static void Question_21()
        {
            Console.WriteLine("Odd or even number , you can enter 10 positive numbers ");
            string usr_input;
            int count = 1;
            List<double> odds= new List<double>();
            List<double> evens = new List<double>();
            do
            {
                Console.Write($"Enter positive number{count} : ");
                usr_input = Console.ReadLine();
                if (double.TryParse(usr_input, out double number) && number >= 0)
                {
                    if (number % 2 == 0) { evens.Add(number); }
                    else {  odds.Add(number); }
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid number ");
                }
            }
            while (count !=11);
            Console.WriteLine($"You enter {evens.Count} even numbers and {odds.Count} odd numbers");
            Console.Write($"Even number is ");
            foreach (var item in evens)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Question_22()
        {
            Console.WriteLine("Odd or even number , you can enter 10 positive numbers ");
            string usr_input;
            int count = 1;
            List<double> odds = new List<double>();
            List<double> evens = new List<double>();
            do
            {
                Console.Write($"Enter positive number{count} : ");
                usr_input = Console.ReadLine();
                if (double.TryParse(usr_input, out double number) && number >= 0)
                {
                    if (number % 2 == 0) { evens.Add(number); }
                    else { odds.Add(number); }
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid number ");
                }
            }
            while (count != 11);
            Console.WriteLine($"You enter {evens.Count} even numbers and {odds.Count} odd numbers");
            Console.Write($"Odd number is ");
            foreach (var item in odds)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Question_23()
        {
            Console.WriteLine("Enter matrix 5x5 that program will convert to matrix 5x1 by multiply each item in row");
            string usr_input;
            double[,] matrix = new double[5, 5];
            double[,] matrix_result = new double[5, 1];
            int mode = 0;
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    if(mode==0)
                    { 
                        matrix_result[i, 0] = 0;
                    JumpPoint:
                        Console.Write($"Enter number[{i}][{j}] : ");
                        usr_input = Console.ReadLine();
                        if (double.TryParse(usr_input, out double number))
                        {
                            matrix[i, j] = number;
                            matrix_result[i, 0] += number;
                        }
                        else
                        { Console.WriteLine("Invalid number!!"); goto JumpPoint; }
                    }
                }
            }
        } // not done yet
    }
}
