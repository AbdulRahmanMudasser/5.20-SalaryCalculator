class Salary
{
    static void Main(string[] args)
    {
        // declaring variables
        string employee1, employee2, employee3;
        double hours1, hours2, hours3;
        double rate1, rate2, rate3;

        // taking input form user for employee 1
        Console.Write("Enter Name For Employee 1: ");
        employee1 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 1: " );
        hours1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 1: ");
        rate1 = Convert.ToDouble(Console.ReadLine());

        // taking input form user for employee 2
        Console.Write("Enter Name For Employee 2: ");
        employee2 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 2: ");
        hours2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 2: ");
        rate2 = Convert.ToDouble(Console.ReadLine());

        // taking input form user for employee 3
        Console.Write("Enter Name For Employee 3: ");
        employee3 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 3: ");
        hours3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 3: ");
        rate3 = Convert.ToDouble(Console.ReadLine());
    }
}

