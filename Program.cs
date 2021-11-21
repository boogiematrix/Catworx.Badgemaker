
// See https://aka.ms/new-console-template for more information

static List<string> GetEmployees()
{
List<string> employees = new List<string>();
while (true) 
{
    Console.WriteLine("Please enter a name: ");
// Get a name from the console and assign it to a variable
    string? input = Console.ReadLine();
    if (input == "")
    {
        break;
    }
    Employee currentEmployee = new Employee(input, "Smith");
    employees.Add(currentEmployee.GetName());
}
return employees;
}

static void PrintEmployees(List<string> employees)
{
    for (int i = 0; i < employees.Count; i++)
    {
        Console.WriteLine(employees[i]);
    }
}

{
    List<string> employees = GetEmployees();
    PrintEmployees(employees);
}