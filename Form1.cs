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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(isRace? this.Location.X + this.Size.Width : this.Location.X, this.Location.Y);
            this.isRace = isRace;
            if(isRace == true)
            {
                btnRaceCondition.Text = "Run Race Condition";
                raceBox.Text = "Application with Race Condition";
            }
            else
            {
                btnRaceCondition.Text = "Run Without Race Condition";
                raceBox.Text = "Application with No Race Condition";
            }
        }
        

        private void btnRaceConditionClick(object sender, EventArgs e)
        {
            ATMProgram atm = new ATMProgram();

            // Create and start threads
            for (int i = 0; i < 2; i++)
            {
                Thread thread = new Thread(() =>
                {
                    Application.Run(new SimulatorOptions(atm, isRace));
                });
                thread.Start();
            }

            // Close the current form
            this.Close();

        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private int generateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000);
            return randomNumber; 
        }

        private void btnOpenAccountClick(object sender, EventArgs e)
        {
            string userInputPin = pinSetBox.Text;
            accountPanel.Visible = true;
            accSetBox.Text = generateRandomNumber().ToString();

         }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            int userPin;
            string userInputPin = pinSetBox.Text;

            ATMProgram helperProgram = new ATMProgram();

            List<Account> accounts = helperProgram.getAllAccounts();

            if (!int.TryParse(userInputPin, out userPin))
            {
                lblOpenAccount.Text = "Enter a valid pin of 6 digits";
                return;
            }

            if (userPin.ToString().Length != 6)
            {
                lblOpenAccount.Text = "Enter a valid pin of 6 digits";
                return;
            }
            else
            {
                helperProgram.addAccount((new Account(3000, userPin, generateRandomNumber())));
                lblOpenAccount.Text = "Account Created with 3000 pounds";
                return;
              
                
            }
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            accountPanel.Visible = false;
        }
    }

}
