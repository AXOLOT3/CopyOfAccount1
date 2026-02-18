using System;
using System.Dynamic;
namespace PROJECT1;

public class BankAccount
{
    public int balence;
    public int balence_
    {
        get { return balence; }
        set { if (value > 0) { balence = value; } }
    }
    public String owner { get; }
    //Constructor
    public BankAccount(int balenceNumber, String ownerName)
    {
        balence = balenceNumber; owner = ownerName;
    }//Displays the owner and balence
    public void show()
    {
        Console.WriteLine($"The owner of this account is:{owner} and their balence is:{balence}");
    }//adds money to the account
    public void deposit(int depositValue)
    {
        balence += depositValue;
    }

    public bool withdraw(int withdrawValue)
    {
        if (withdrawValue > balence) { return false; }
        balence -= withdrawValue; return true;
    }//returns true if able to transfer 
    public bool transfer(int transferValue, BankAccount b2)
    {
        if (balence < transferValue) { return false; }
        withdraw(transferValue); b2.deposit(transferValue); return true;
    }

    public static void showValue(int? x)
    {
        if (x.HasValue) { Console.WriteLine(x); }
        else { Console.WriteLine("this has no value"); }
    }
}