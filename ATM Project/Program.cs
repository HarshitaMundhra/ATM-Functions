// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
return firstName;
    }

    public string getLastName()
    {
        return lastName;

    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName) { 
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        { 
            Console.WriteLine("Please choose one of the options..");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money you want to deposit ?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your money. Your new Balance is : "+ currentUser.getBalance());

        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money you want to withdraw ? ");
            double withdrawal = Double.Parse(Console.ReadLine()); 
            
            if(currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient Balance :(");
            }

            else
            {
                //double newBalance = currentUser.getBalance() - withdrawal;
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go! Thank You : " + "Your current balance is" );
            }

        }

        void balance (cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.getBalance());

        }

         List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("425368175327181931", 1234, "Harshita", "Mundhra", 150.01));
        cardHolders.Add(new cardHolder("425368175327181932", 1235, "Yash", "Mundhra", 250.01));
        cardHolders.Add(new cardHolder("425368175327181933", 1236, "Manoj", "Mundhra", 350.01));
        cardHolders.Add(new cardHolder("425368175327181934", 1237, "Nisha", "Mundhra", 450.01));
        cardHolders.Add(new cardHolder("425368175327181935", 1238, "Ani", "Jones", 130.01));

        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please insert your debit card : ");
        string debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if(currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }

            }
            catch { Console.WriteLine("Card not recognized. Please try again"); }
        }

        Console.WriteLine("Please Enter your Pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if(currentUser.getPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Pin. Please try again ");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Pin. Please try again");
            }
        }

        Console.WriteLine("Welcome" + currentUser.getFirstName()+ " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());

            }
            catch { }
            if(option == 1)
            {
                deposit(currentUser);
            }
            else if(option == 2) { withdraw(currentUser); }
            else if(option == 3) { balance(currentUser); }
            else if(option == 4) { break; }
            else { option = 0;  }
        }
        while (option != 4);
         Console.WriteLine("Thank you! Have a nice day :)");

            

    }
}
