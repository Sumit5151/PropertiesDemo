
using PropertiesDemo;

public class Program
{
    public static void Main()
    {
        Employee employee1 = new Employee();

        //int? age = 20;

        //    employee.SetAge(age);
        //    var id = employee.GetAge();




        employee1.Age = 20;
        var EmployeeAge = employee1.Age;

        employee1.Salary = 10000;
        var employeeSalary1 = employee1.Salary;


        Employee employee2 = new Employee();

        employee2.Salary = 9000;
        var employeeSalary2 = employee2.Salary;


        employee1.Gender = Gender.Male;
        employee2.Gender = Gender.Female;

        employee1.Courses = Courses.CSharp;
        employee1.Courses = Courses.OracleDB;



        Employee employee3 = new Employee()
        {
            Age = 20,
            Salary = 3000,
            Gender = Gender.Male,
            Courses = Courses.OracleDB
        };

        Employee employee4 = new Employee();
        employee4.Age = 20;
        employee4.Salary = 3000;
        employee4.Gender = Gender.Male;
        employee4.Courses = Courses.OracleDB;

    }
}