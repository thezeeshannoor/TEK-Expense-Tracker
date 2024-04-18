// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using System;
using System.Linq;
class Program
{
    string name;
    string desc;
    int amount;
    int totalAmount = 0;

    List<string> dataList= new List<string>();
    List<int> amountData=new List<int>();
    void AddExpense()
    {
        try
        {
            Console.WriteLine("Enter Expense name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Expense description");
            desc = Console.ReadLine();

            Console.WriteLine("Enter Expense amount");
            amount = int.Parse(Console.ReadLine());

            amountData.Add(amount);
            DateTime now = DateTime.Now;
            dataList.Add($"Expense name {name} Expense Description {desc} Expense Amount {amount} Timestamped {now}");  
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
    void ViewTotalExpenses()
    {
        foreach (int sum in amountData)
        {
                totalAmount += sum;
        }
        Console.WriteLine(totalAmount);
    }
    void ViewAllExpense()
    {
        if (dataList.Any())
        {
            foreach (string list in dataList)
            {
                Console.WriteLine(list);
            }
        }
        else Console.WriteLine("List is empty");
    }
    static void Main(string[] args)
    {
       
        Program exp = new Program();
        Console.WriteLine(" 1:Enter 1 for Add Expense \n 2:Enter 2 for View Total Expenses \n 3:Enter 3 for View All Expense \n 0:Enter 0 for exit" );
        int key = int.Parse(Console.ReadLine());
        while (key != 0)
        {
            switch (key)
            {
                case 1:
                    exp.AddExpense();
                    break;
                case 2:
                    exp.ViewTotalExpenses();
                    break;
                case 3:
                    exp.ViewAllExpense();
                    break;
                default:
                    Console.WriteLine("Please enter valid Key ");
                    break;
            }
            Console.WriteLine("\nEnter your choice");
            key = int.Parse(Console.ReadLine());
        }  

    }
}
