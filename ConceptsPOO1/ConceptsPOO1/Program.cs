// See https://aka.ms/new-console-template for more information
using ConceptsPOO1;

Console.WriteLine("Concepts POO");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = " Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M


}; 
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = " Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2021, 2, 6),
    IsActive = true,
    Sales = 3200000000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);

Employee employee3 = new HoulyEmployee()
{
    Id = 7458,
    FirstName = "Dante",
    LastName = " Cuervo",
    BirthDate = new Date(1868, 5, 23),
    HiringDate = new Date(2019, 1, 4),
    IsActive = true,
    Hours = 90.54F,
    HoursValue = 5000.54m
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee ()
{
    Id = 6558,
    FirstName = "Juan",
    LastName = " Pablo",
    BirthDate = new Date(2001, 4, 11),
    HiringDate = new Date(2009, 2, 17),
    IsActive = true,
    Base = 860754.67M,
    Sales = 58000000M,
    CommissionPercentaje = 0.01F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4

//employee.Add(employee1);
//employee.Add(employee2);
//employee.Add(employee3);
//employee.Add(employee4);
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                                 =====================");
Console.WriteLine($"TOTAL                           { $" {payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id= 1,
    Price = 5300000M,
    Quantity = 6 
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
