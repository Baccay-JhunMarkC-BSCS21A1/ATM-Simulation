using System;

public class ATM
{
    static double Balance = 1000.00;
    static void cout(string message)
    {
        Console.WriteLine(message);
    }
    public static void Main(string[] args)
    {
        bool loop = true;
        while (loop == true)
        {
            cout("-------------------Basic ATM Simulation-------------------");
            try
            {
                cout("1. Check Balance\n2. Deposit\n3. Withdraw\n4. Exit");
                int userIn = Convert.ToInt32(Console.ReadLine());
                switch (userIn)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        Withdraw();
                        break;
                    case 4:
                        cout("Thank you for using our program. Goodbye!");
                        Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                cout("Invalid Input!");
            }

        }
        
    }
    static void CheckBalance()
    {
        cout($"Your current Balance is: ₱{Balance}");
    }
    static void Deposit()
    {
        cout("Enter the amount you want to Deposit: ");
        double dep = Convert.ToDouble(Console.ReadLine());
        Balance = Balance+dep;
        cout($"You have succesfully Deposited ₱{dep}\nYour new Balance is ₱{Balance}");
    }
    static void Withdraw() 
    {
        cout($"Your current Balance is: ₱{Balance}\nEnter the amount you want to Withdraw: ");
        double wDraw = Convert.ToDouble(Console.ReadLine());
        if (wDraw > 0 || wDraw >= Balance)
        {
            Balance = Balance - wDraw;
            cout($"You have successfully withdrawn ₱{wDraw}. Your new balance is ₱{Balance}");
        }
    }
}