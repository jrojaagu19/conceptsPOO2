﻿// See https://aka.ms/new-console-template for more information
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

Console.WriteLine(employee1);

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
Console.WriteLine(employee2);