using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATMSimulator
{
    public partial class Form1 : Form
    {

        bool isRace;
        public Form1(bool isRace)
        {
            InitializeComponent();
            this.isRace = isRace;
            if(isRace == true)
            {

                racebutton.Text = "Run Race Condition";
                raceBox.Text = "Application with Race Condition";
             

            }
            else
            {
                racebutton.Text = "Run Without Race Condition";
                raceBox.Text = "Application with No Race Condition";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Thread CreateAndStartThread(ATMProgram atmProgram)
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new SimulatorOptions(atmProgram , isRace));
            });
            return thread;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ATMProgram atm = new ATMProgram();
           

            // Define the number of threads you want to create
            int numThreads = 2;

            // Create and start threads
            for (int i = 0; i < numThreads; i++)
            {
                Thread thread = CreateAndStartThread(atm);
                thread.Start();
            }

            // Close the current form
            this.Close();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int randomNumber;
        private int generateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000);
            return randomNumber; 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string userInputPin = pinSetBox.Text;
            accountPanel.Visible = true;

            randomNumber = generateRandomNumber();

            accSetBox.Text = randomNumber.ToString();

         }

        private void registerButton_Click(object sender, EventArgs e)
        {
            int userPin;
            string userInputPin = pinSetBox.Text;

            ATMProgram helperProgram = new ATMProgram();

            List<Account> accounts = helperProgram.getAllAccounts();

          


            if (!int.TryParse(userInputPin, out userPin))
            {
                accountLabel.Text = "Enter a valid pin of 6 digits";
                return;
            }

            if (userPin.ToString().Length != 6)
            {
                accountLabel.Text = "Enter a valid pin of 6 digits";
                return;
            }
            else
            {
                helperProgram.addAccount((new Account(3000, userPin, randomNumber)));
                accountLabel.Text = "Account Created with 3000 pounds";
                return;
              
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accountPanel.Visible = false;
        }
    }



    public  class ATMProgram
    {
       // private Account[] ac = new Account[3];

        List<Account> accounts = new List<Account>();   



        


        public ATMProgram()
        {
           // ac[0] = new Account(300, 1111, 111111);
          //  ac[1] = new Account(750, 2222, 222222);
          //  ac[2] = new Account(3000, 3333, 333333);

            accounts.Add(new Account(300, 1111, 111111));
            accounts.Add(new Account(750, 2222, 222222));

            accounts.Add(new Account(3000, 3333, 333333));






        }

        public List<Account> getAllAccounts()
        {
            return accounts;
        }

        public void addAccount(Account account)
        {
            accounts.Add(account);
        }



        public Account findAccount(int accountNum)
        {
           

            for (int i = 0; i < this.accounts.Count(); i++)
            {
                if (accounts[i].getAccountNum() == accountNum)
                {
                    return accounts[i];
                }
            }

            return null;
        }


    }

    public class Account
    {
        private int balance;
        private int pin;
        private int accountNum;

        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }


        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }


        public Boolean decrementBalance(int amount)
        {
            if (this.balance >= amount)
            {
             
               
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

    }














}
