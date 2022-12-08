using System;
using System.Linq;
using static System.Console;

namespace Hots4_2
{
    internal class Program
    {

        static int MAX = 5;
        static int lowAvg = 0;
        static int highAvg = 1000000;

        static void Main(string[] args)
        {
            string[] firstNames = new string[MAX];
            string[] lastNames = new string[MAX];
            string[] department = new string[MAX];
            int[] salary = new int[MAX];
            

            

            for (int lcv = 0; lcv < MAX; ++lcv)
            {
                firstNames[lcv] = inputFirstName(lcv);
                lastNames[lcv] = inputLastName(lcv);
                department[lcv] = inputDepartment(lcv);
                salary[lcv] = inputSalary(lcv);
               

            }


           OutPutInFormation(firstNames, lastNames, salary);

            ReadLine();
        }

        static string inputFirstName(int lcv)
        {
            string first;

            Write("\nInput First Name # " + "" + (lcv + 1).ToString() + "\t\t");

            first = ReadLine().Trim();

            while (first == "")
            {
                Write("\nPlease Enter A First Name: " + " ");
                first = ReadLine().Trim();
            }

            return first;
        }

        static string inputLastName(int lcv)
        {
            string last;

            Write("Input Last Name # " + "" + (lcv + 1).ToString() + "\t\t");

            last = ReadLine().Trim();

            while (last == "")
            {
                Write("\nPlease Enter A Last Name: " + " ");
                last = ReadLine().Trim();
            }

            return last;
        }

        static string inputDepartment(int lcv)
        {
            string Dep;

            Write("Input Department # " + "" + (lcv + 1).ToString() + "\t\t");

            Dep = ReadLine().Trim();

            while (Dep == "")
            {
                Write("\nPlease Enter A Last Name: " + " ");
                Dep = ReadLine().Trim();
            }

            return "";
        }

        static int inputSalary(int lcv)
        {
            bool result;
            int sal;


            Write("Input Salary # " + " " + (lcv + 1).ToString() + "\t\t");
            result = int.TryParse(ReadLine(), out sal);

            while (!result)
            {
                Write("\nPlease Enter A Salary Amount: " + " ");
                result = int.TryParse(ReadLine(), out sal);
            }
            if (sal < lowAvg)
            {
                Write("\nPlease Enter A Salary In Range: " + " ");
                result = int.TryParse(ReadLine(), out sal);
            }
            else if (sal < highAvg)
            {

                Write("\nPlease Enter A Salary In Range: " + " ");
                result = int.TryParse(ReadLine(), out sal);
            }
           
            return sal;
        }

       

        static void OutPutInFormation(string[] firstName, string[] lastName, int[] salarys)
        {
            Clear();

            for (int lcv = 0; lcv < MAX; ++lcv)
            {
                WriteLine("First Name: " + firstName[lcv]);
                WriteLine("Last Name: " + lastName[lcv]);
                WriteLine("Salary: " + salarys[lcv].ToString("c") + "\n");

                
            }

            WriteLine("Low Salary:" + salarys.Min().ToString("c"));
            WriteLine("High Salary: " + salarys.Max().ToString("c"));

        }
    }
}