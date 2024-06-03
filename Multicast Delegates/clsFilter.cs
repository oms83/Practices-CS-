using System;
using System.Collections.Generic;


public class clsEmployee
{
public string FirstName { get; set; } 

    public string LastName { get; set; }

    public short Age { get; set; }

    public decimal Balance { get; set; }

    public clsEmployee(string firstName, string lastName, short age, decimal balance)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Balance = balance;
    }
}

internal class clsFilter
{
    private delegate bool Filter(clsEmployee Employee);

    private static void FilteringEmployees(List<clsEmployee> lstEmployee, Filter filter)
    {
        foreach (clsEmployee emp in lstEmployee)
        {
            if (filter(emp))
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Full Name: {emp.FirstName}\nAge: {emp.Age}\nBalance: {emp.Balance:C}");
                Console.WriteLine("-----------------------------");
            }
        }
    }

    public static void Start()
    {
        List<clsEmployee> lstEmployee = new List<clsEmployee>()
        {
            new clsEmployee("Omer", "MEMES", 24, 45000),
            new clsEmployee("Ali", "MEMES", 22, 25000),
            new clsEmployee("Osman", "Ozalp", 23, 22000),
            new clsEmployee("Musa", "Ozalp", 23, 18000),
            new clsEmployee("Yusuf", "Bozkurt", 30, 28000),
            new clsEmployee("Abdullrahman", "MEMES", 19, 40000),
            new clsEmployee("Muhammed", "MEMES", 25, 35000),
            new clsEmployee("Mahmod", "MEMES", 22, 30000),
            new clsEmployee("Hasan", "MEMES", 25, 15000),
        };

        Console.WriteLine("\n\nList All Employees: ");
        FilteringEmployees(lstEmployee, (clsEmployee emp) => true);

        Console.WriteLine("\n\nFilter By Balance Greater Than 30000:");
        FilteringEmployees(lstEmployee, (clsEmployee emp) => emp.Balance >= 30000 );

        Console.WriteLine("\n\nFilter By Balance Less Than 30000:");
        FilteringEmployees(lstEmployee, (clsEmployee emp) => emp.Balance < 30000);

        Console.WriteLine("\n\nFilter By First Name Starts With \'O\':");
        FilteringEmployees(lstEmployee, (clsEmployee emp) => emp.FirstName.StartsWith("O"));

        Console.WriteLine("\n\nFilter By First Name Starts With \'M\':");
        FilteringEmployees(lstEmployee, (clsEmployee emp) => emp.FirstName.StartsWith("M"));


    }

}

/*
 
List All Employees:
-----------------------------
Full Name: Omer
Age: 24
Balance: $45,000.00
-----------------------------
-----------------------------
Full Name: Ali
Age: 22
Balance: $25,000.00
-----------------------------
-----------------------------
Full Name: Osman
Age: 23
Balance: $22,000.00
-----------------------------
-----------------------------
Full Name: Musa
Age: 23
Balance: $18,000.00
-----------------------------
-----------------------------
Full Name: Yusuf
Age: 30
Balance: $28,000.00
-----------------------------
-----------------------------
Full Name: Abdullrahman
Age: 19
Balance: $40,000.00
-----------------------------
-----------------------------
Full Name: Muhammed
Age: 25
Balance: $35,000.00
-----------------------------
-----------------------------
Full Name: Mahmod
Age: 22
Balance: $30,000.00
-----------------------------
-----------------------------
Full Name: Hasan
Age: 25
Balance: $15,000.00
-----------------------------


Filter By Balance Greater Than 30000:
-----------------------------
Full Name: Omer
Age: 24
Balance: $45,000.00
-----------------------------
-----------------------------
Full Name: Abdullrahman
Age: 19
Balance: $40,000.00
-----------------------------
-----------------------------
Full Name: Muhammed
Age: 25
Balance: $35,000.00
-----------------------------
-----------------------------
Full Name: Mahmod
Age: 22
Balance: $30,000.00
-----------------------------


Filter By Balance Less Than 30000:
-----------------------------
Full Name: Ali
Age: 22
Balance: $25,000.00
-----------------------------
-----------------------------
Full Name: Osman
Age: 23
Balance: $22,000.00
-----------------------------
-----------------------------
Full Name: Musa
Age: 23
Balance: $18,000.00
-----------------------------
-----------------------------
Full Name: Yusuf
Age: 30
Balance: $28,000.00
-----------------------------
-----------------------------
Full Name: Hasan
Age: 25
Balance: $15,000.00
-----------------------------


Filter By First Name Starts With 'O':
-----------------------------
Full Name: Omer
Age: 24
Balance: $45,000.00
-----------------------------
-----------------------------
Full Name: Osman
Age: 23
Balance: $22,000.00
-----------------------------


Filter By First Name Starts With 'M':
-----------------------------
Full Name: Musa
Age: 23
Balance: $18,000.00
-----------------------------
-----------------------------
Full Name: Muhammed
Age: 25
Balance: $35,000.00
-----------------------------
-----------------------------
Full Name: Mahmod
Age: 22
Balance: $30,000.00
-----------------------------


*/
