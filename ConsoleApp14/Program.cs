using ConsoleApp14;
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        #region q1
        Console.WriteLine("enter your num ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num);
        #endregion

        #region q2
        Console.WriteLine("enter your string ");
        string s = Console.ReadLine();
        if (int.TryParse(s, out int res))
        {
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine("Can't convert, string is not a valid number");
        }
        #endregion

        #region q3
        double num1 = 5.5;
        double num2 = 2.2;

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);

        #endregion


        #region q4
        Console.WriteLine("enter your string ");
        string str = Console.ReadLine();
        string sub = str.Substring(0, 5);
        Console.WriteLine(sub);
        #endregion

        #region q5
        int a = 10;
        int b = a;
        b = 20;

        Console.WriteLine("a = " + a); // 10
        Console.WriteLine("b = " + b); //20

        #endregion

        #region q6
        person p1 = new person();
        p1.name = "Esraa";

        person p2 = p1;
        p2.name = "Sara";

        Console.WriteLine("p1.Name = " + p1.name); // Sara
        Console.WriteLine("p2.Name = " + p2.name); // Sara
        #endregion

        #region q7

        Console.WriteLine("enter first");
        string s1 = Console.ReadLine();
        Console.WriteLine("enter second");
        string s2 = Console.ReadLine();
        Console.WriteLine(s1 + " " + s2);

        #endregion

        #region q8
        Console.WriteLine("enter the principal amount");
        int amount = int.Parse(Console.ReadLine());

        Console.WriteLine("enter rate of interest");
        int rate = int.Parse(Console.ReadLine());

        Console.WriteLine("enter time");
        int time = int.Parse(Console.ReadLine());

        int interest = (amount * rate * time) / 100;
        Console.WriteLine($"The simple interest is:{interest}");




        #endregion

        #region q9
        Console.WriteLine("Enter your weight in kilograms");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your height in meters");
        double height = double.Parse(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"Your BMI is: {bmi}");
        #endregion

        #region q10
        Console.WriteLine("enter temperature");
        int temp = int.Parse(Console.ReadLine());

        if (temp < 10)
        {
            Console.WriteLine("Just Cold");
        }
        else if (temp > 30)
        {
            Console.WriteLine("Just Hot");
        }
        else
        {
            Console.WriteLine("Just Good");
        }
        #endregion

        #region q11
        Console.WriteLine("Enter the day");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the month");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the year");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"Today's date : {day} , {month} , {year}");
        Console.WriteLine($"Today's date : {day} / {month} / {year}");
        Console.WriteLine($"Today's date : {day} - {month} - {year}");

        #endregion

        #region q12
        DateTime date = new DateTime(2024, 6, 14);
        Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
        //output The event is on 06/14/2024 
        #endregion

        #region q13
        int d;
        d = Convert.ToInt32(!(30 < 20));

        // A value 1 will be assigned to d. 
        #endregion

        #region q14
        Console.WriteLine(13 / 2 + " " + 13 % 2);
        //6 1  
        #endregion

        #region q15
        int n = 1, z = 5;


        if (!(n <= 0))
            Console.WriteLine(++n + z++ + " " + ++z);
        else

            Console.WriteLine(--n + z-- + " " + --z);

        // 7 7  
        #endregion


    }
}
