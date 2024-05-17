// See https://aka.ms/new-console-template for more information
using PRN_Slot4_TX2_1;
internal class Program()
{ 
    static String inputString(String mess)
    {
        Console.WriteLine(mess);
        //force user input exectly non-empty string
        while (true)
        {
            String input = Console.ReadLine().Trim();
            if (input.Equals(""))
            {
                Console.WriteLine("Please input a non-empty string: ");
                continue;
            }
            return input;
        }
    }
    static double inputNumber(String mess)
    {
        while (true)
        {
            // print the message 
            Console.WriteLine(mess);
            String input = Console.ReadLine();
            // Prompt user to enter correct number
            try
            {
                double number = Convert.ToInt32(input);
                if (number >= 0) return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid positive number");
            }

        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        int type = Convert.ToInt32(inputNumber("Enter employee type (1 - FullTime, 2 - PartTime): "));
        String name = inputString("Enter a name: ");
        int paymentPerHour = Convert.ToInt32(inputNumber("Enter payment per hour: "));
        // Check with type to add suitable employee
        if (type == 1)
        {
            employees.Add(new FullTimeEmployee(name, paymentPerHour));
        }
        else if (type == 2)
        {
            int workingHours = Convert.ToInt32(inputNumber("Enter working hours"));
            employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
        }
        else
        {
            Console.WriteLine("Invalid employee type.");
        }
    }

    static void FindHighestSalaryEmployee(List<Employee> employees)
    {
        if (employees.Count == 0) { Console.WriteLine("No Employees found"); return; }
        Employee temp= employees[0];
        foreach (var e in employees)
        {
            if (e.CalculateSalary() > temp.CalculateSalary())
            {
                temp = e;
            }
        }
        Console.WriteLine("Employee with highest salary: " + temp);
    }
    static void FindEmployeeByName(List<Employee> employees)
    {
        String name = inputString("Enter name to search: ");
        var foundEmployees = new List<Employee>();
        // Iterate through list to find the matching employees and add no foundEmployees
        foreach (var e in employees)
        {
            if (e.GetName().Equals(name, StringComparison.OrdinalIgnoreCase)) foundEmployees.Add(e);
        }
        // Handle 2 cases: found & not Found
        if (foundEmployees.Count != 0)
        {
            foreach(var e in foundEmployees) Console.WriteLine(e.ToString());
        } else { Console.WriteLine("No employee with that name found"); }
    }
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            // Print the menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Find Employee with Highest Salary");
            Console.WriteLine("3. Find Employee by Name");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            // Prompt user to input int
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 3:
                    FindEmployeeByName(employees);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}





