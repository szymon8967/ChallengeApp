using ChallengeApp;

Employee employee1 = new Employee("Jan", "Kowalski", 40);
Employee employee2 = new Employee("Marcin", "Zając", 25);
Employee employee3 = new Employee("Ewelina", "Nowak", 35);

employee1.AddRating(6);
employee1.AddRating(8);
employee1.AddRating(6);
employee1.AddRating(9);
employee1.AddRating(10);

employee2.AddRating(2);
employee2.AddRating(3);
employee2.AddRating(3);
employee2.AddRating(1);
employee2.AddRating(2);

employee3.AddRating(9);
employee3.AddRating(9);
employee3.AddRating(9);
employee3.AddRating(9);
employee3.AddRating(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int bestRating = -1;
Employee? employeeWithBestRating = null;


foreach (var employee in employees)
{
    if (employee.Rating > bestRating)
    {
        employeeWithBestRating = employee;
        bestRating = employeeWithBestRating.Rating;
    }
}

Console.WriteLine(employeeWithBestRating.Name + " " + employeeWithBestRating.LastName + " - rating -> " + employeeWithBestRating.Rating);
