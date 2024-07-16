using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    

    public class CreditCardDebt
    {
        private double balance;
        private double monthlyInterestRate;
        private double monthlyPayment;

        // Constructor to initialize the credit card debt details
        public CreditCardDebt(double initialBalance, double monthlyPayment)
        {
            this.balance = initialBalance;
            this.monthlyPayment = monthlyPayment;
            this.monthlyInterestRate = 0.015; // 1.5% interest rate per month
        }

        // Method to simulate the debt payment process
        public void PayOffDebt()
        {
            int month = 1;
            double totalPayments = 0;

            while (balance > 0)
            {
                balance = balance + (balance * monthlyInterestRate) - monthlyPayment;
                totalPayments += monthlyPayment;

                if (balance < 0) balance = 0; // Ensure balance does not go below zero

                Console.WriteLine($"Month: {month} balance: {balance:F2} total payments: {totalPayments:F2}");
                month++;
            }
        }
    }

    // Main Program
    public class CreditDebt
    {
        public static void Main()
        {
            Console.Write("Enter the monthly payment: ");
            double monthlyPayment = double.Parse(Console.ReadLine());

            double initialBalance = 1000; // Example initial balance

            CreditCardDebt debt = new CreditCardDebt(initialBalance, monthlyPayment);
            debt.PayOffDebt();
        }
    }

}
