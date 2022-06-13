using BankApp.BankApp;
using System;

namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank TCU = new Bank("005143", "Teacher's Credit Union");
            Console.WriteLine(TCU.GetAccountList());
            TCU.PrintAllAccountInfo();
        }
    }
}