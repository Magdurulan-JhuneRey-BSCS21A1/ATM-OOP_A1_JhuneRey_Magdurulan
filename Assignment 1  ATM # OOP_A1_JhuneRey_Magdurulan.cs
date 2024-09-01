using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

int balance = 1000;
bool exit = true;
Console.WriteLine("Hello, World!");
while (exit == true)
{
    Console.WriteLine("1.Check Balance\r\n2.Deposit Money\r\n3.Withdraw Money\r\n4.Exit");
    Console.WriteLine("Choose Option : ");
    string userinput = Console.ReadLine();
    if (userinput == "1")
    {
        Console.WriteLine("Your current balance is: Php " + balance);
    }
    else if (userinput == "2")
    {
        Console.WriteLine("Enter the amount to deposit: ");
        var deposit = Convert.ToInt32(Console.ReadLine());
        if (deposit <= 0)
        {
            Console.WriteLine("Error");
        }
        else
        {
            balance = balance + deposit;
            Console.WriteLine(" You have successfully deposited Php" + deposit + ".Your new balance is Php " + balance);
        }

    }
    else if (userinput == "3") {
        Console.WriteLine("Enter the amount to deposit: ");
        var withdraw = Convert.ToInt32(Console.ReadLine());
        if (withdraw <= 0)
        {
            Console.WriteLine("Error");
        }
        else if (withdraw > balance)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            balance = balance - withdraw;
            Console.WriteLine("You have successfully withdrawn Php" + withdraw + ".Your new balance is Php " + balance);
        }

    }
    else if (userinput == "4") 
    { 
    exit = false;
    }
    else
    {
        Console.WriteLine("Error");
    }

}
