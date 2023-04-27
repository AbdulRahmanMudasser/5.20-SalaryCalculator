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

        Console.Write("Enter Rate Per Hour: ");
        rate1 = Convert.ToDouble(Console.ReadLine());
    }
}

