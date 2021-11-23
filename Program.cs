
// See https://aka.ms/new-console-template for more information

static List<Employee> GetEmployees()
{
List<Employee> employees = new List<Employee>();
while (true) 
{
    Console.WriteLine("Please enter your first name: (Leave empty to exit)");
    string firstName = Console.ReadLine();
    if (firstName == "")
    {
        break;
    }
    Console.WriteLine("Please enter your last name");
    string lastName = Console.ReadLine();
    Console.WriteLine("Please enter your id");
    int id = Int32.Parse(Console.ReadLine()); 
    Console.WriteLine("Please enter your photo URL");
    string photoUrl = Console.ReadLine();
    Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
    employees.Add(currentEmployee);
}
return employees;
}


{
    List<Employee> employees = GetEmployees();
    Util.PrintEmployees(employees);
}