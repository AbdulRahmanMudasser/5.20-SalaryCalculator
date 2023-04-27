class Salary
{
    static void Main(string[] args)
    {
        // declaring variables
        string employee1, employee2, employee3;
        double hours1, hours2, hours3;
        double rate1, rate2, rate3;
        double pay1, pay2, pay3;

        // taking input form user for employee 1
        Console.Write("Enter Name For Employee 1: ");
        employee1 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 1: " );
        hours1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 1: ");
        rate1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // taking input form user for employee 2
        Console.Write("Enter Name For Employee 2: ");
        employee2 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 2: ");
        hours2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 2: ");
        rate2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // taking input form user for employee 3
        Console.Write("Enter Name For Employee 3: ");
        employee3 = Console.ReadLine();

        Console.Write("Enter Working Hours For Employee 3: ");
        hours3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate Per Working Hour Of Employee 3: ");
        rate3 = Convert.ToDouble(Console.ReadLine());

        // employee1 pay
        if (hours1 >= 40)
        {
            pay1 = rate1 * 40;
        }

        else
        {
            pay1 = (rate1 * 40) + (hours1 - 40) * rate1 * 1.5;
        }

        // employee2 pay
        if (hours2 >= 40)
        {
            pay2 = rate2 * 40;
        }

        else
        {
            pay2 = (rate2 * 40) + (hours2 - 40) * rate2 * 1.5;
        }

        // employee3 pay
        if (hours3 >= 40)
        {
            pay3 = rate3 * 40;
        }

        else
        {
            pay3 = (rate3 * 40) + (hours3 - 40) * rate3 * 1.5;
        }

        // Output results
        Console.WriteLine("\nPayroll Summary\n");
        Console.WriteLine("  Employee Name          Hours    Rate    Gross Pay");
        Console.WriteLine("-----------------        -----    ----    ---------");
        Console.WriteLine("{0,-17}        {1,5}     {2,-4}   {3,9:C}", employee1, hours1, rate1, pay1);
        Console.WriteLine("{0,-17}        {1,5}     {2,-4}   {3,9:C}", employee2, hours2, rate2, pay2);
        Console.WriteLine("{0,-17}        {1,5}     {2,-4}   {3,9:C}", employee3, hours3, rate3, pay3);
    }
}

