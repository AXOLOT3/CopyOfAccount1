namespace PROJECT1;

public class MainT
{
    static void Main(string[] args)
    {

        Console.WriteLine("this writeline added on the MainChange branch");
        /*
        BankAccount Account1 = new BankAccount(100, "Bob");
        Account1.show(); Console.WriteLine("About to withdraw 150");
        if (Account1.withdraw(150))
        {
            Console.WriteLine("Withdraw was successful");
        }
        else
        {
            Console.WriteLine("Withdraw was not successful insufficient funds");
        }
        Account1.show(); Console.WriteLine("About to deposit 200");
        Account1.deposit(200); Account1.show();
        Console.WriteLine("About to withdraw 150");
        Account1.withdraw(150); Account1.show();
        Console.WriteLine("Creating account 2");
        BankAccount Account2 = new BankAccount(100, "Mary");
        Account2.show();
        Console.WriteLine("About to transfer 50 from Bob to Mary");
        if (Account1.transfer(50, Account2))
        {
            Console.WriteLine("Transfer was successful");
        }
        else
        {
            Console.WriteLine("Withdraw was not successful insufficient funds");
        }
        Account1.show();
        Account2.show();

        Console.WriteLine(Account1.balence_);
        Account1.balence_ = 80;
        Console.WriteLine(Account1.balence_);

        Account1.show();
        */

        /*




        BankAccount a1 = new BankAccount(100, "bob");
        BankAccount a2 = new BankAccount(200, "fred");

        a1 = a2;
        a1.show();
        a2.show();
        a1.withdraw(10);
        a2.withdraw(20);
        a1.show();
        a2.show();
        int x = 5, y = 10;
        x = y;
        x++;
        Console.WriteLine(x);
        Console.WriteLine(y);
        */


        /*

        BankAccount a1 = new BankAccount(100, "bob");
        int totalAssets = 1000;
        DoIt(a1, ref totalAssets);
        Console.WriteLine("after doIt:");
        a1.show();
        Console.WriteLine($"total assets is now {totalAssets}");
        Console.WriteLine("This is a test for stuff?");

        */








        /*
        int? x1;
        int? x2;
        x1 = 20;
        x2 = null;

        BankAccount.showValue(x1);
        BankAccount.showValue(x2);

        string? s;
        s = null;
        s = "test";

        if (s != null){}
        BankAccount? test = null;
        if (test != null){}
        */
    }
    public static void DoIt(BankAccount a, ref int totalAssets)
    {
        a.withdraw(50);
        totalAssets--;
    }
}