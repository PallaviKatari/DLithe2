using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Concepts
{
    /// <summary>
    /// STEP 1:CUSTOM EXCEPTION FOR BANKING
    /// </summary>
    public class InsufficientFundException : Exception
    {
        //Create user-defined error message
        private static readonly string DefaultMessage = "Account balance is insufficient for the transaction.";
        /// <summary>
        /// Properties for Account Details
        /// </summary>
        public string AccountName { get; set; }
        public int AccountBalance { get; set; }
        public int TransactionAmount { get; set; }
        /// <summary>
        /// Passing default error message to the constructor
        /// </summary>
        public InsufficientFundException() : base(DefaultMessage) { }
        /// <summary>
        /// Constructor with Account details
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="accountBalance"></param>
        /// <param name="transactionAmount"></param>
        public InsufficientFundException(string accountName, int accountBalance, int transactionAmount): base(DefaultMessage)
        {
            AccountName = accountName;
            AccountBalance = accountBalance;
            TransactionAmount = transactionAmount;
        }

    }
        
    class ExceptionCustom1
    {
        /// <summary>
        /// Accessing the Account class
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("SBI Bank!");
            var account = new Account("John", 20000);//invoke the constructor
            try
            {
                //Calling the Debit() and Credit() from Account class
                account.Debit(2500);
                account.Credit(2000);
            }
            catch (InsufficientFundException ex)
            {
                Console.WriteLine("Encountered exception \nException Message: " + ex.Message);
                Console.WriteLine("Account Balance: " + ex.AccountBalance);
                Console.WriteLine("Transaction Amount: " + ex.TransactionAmount);
            }

            Console.Read();
        }
    }
    /// <summary>
    /// Class created for Bank Account Details
    /// </summary>
    class Account
    {
        /// <summary>
        /// Constructor which initializes the account details automatically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="balance"></param>
        public Account(string name, int balance) //John,20000
        {
            Name = name; //assigns to the property Name
            Balance = balance; //assigns to the property Balance
        }
        /// <summary>
        /// Properties for the variables
        /// </summary>
        public string Name { get; private set; }
        public int Balance { get; private set; }

        /// <summary>
        /// Handling the exception for Debit()
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="InsufficientFundException"></exception>
        public void Debit(int amount) //10000
        {
            //Passes the exception to line:32
            if (Balance < amount) throw new InsufficientFundException(Name, Balance, amount);
            Balance = Balance - amount; //20000-10000
            Console.WriteLine("Balance after Debit:{0}", Balance);//10000
        }
        public void Credit(int amount)//50000
        {
            Balance = amount + Balance; //10000+5000
            Console.WriteLine("Balance after Credit:{0}",Balance);//15000
        }
    }    
   
}
