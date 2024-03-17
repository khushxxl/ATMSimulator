using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Diagnostics;

namespace ATMSimulator
{
    public partial class SimulatorOptions : Form
    {
        Account userAccount;
        ATMProgram atmProgram;
        static Mutex useMutex = new Mutex();
        bool isRace;

        public SimulatorOptions(ATMProgram program , bool isRace)
        {
            this.atmProgram = program;
            InitializeComponent();
            this.isRace = isRace;
            foreach (Account acc in atmProgram.getAllAccounts())
            {
                Console.WriteLine(acc.getAccountNum());
            }
        }

        public void deductAccountBalance(int amt)
        {
            lblLastTransaction.Text = "Last Transaction : Withdrawn " + amt;
            withdrawPanel.Visible = false;
            Thread.Sleep(2000);

            if (isRace)
            {
                if (userAccount.decrementBalance(amt))
                {
                    int balance = userAccount.getBalance();
                    balance -= amt;
                    Thread.Sleep(2000);
                    userAccount.setBalance(balance);
                    textboxBalance.Text = "Current Balance:  " + userAccount.getBalance().ToString();
                    lblLastTransaction.Visible = false;
                }
            }

            else
            {
                useMutex.WaitOne();
                if (userAccount.decrementBalance(amt))
                {
                    try
                    {
                        int balance = userAccount.getBalance();
                        balance = balance - amt;
                        Thread.Sleep(2000);
                        userAccount.setBalance(balance);
                        textboxBalance.Text = "Current Balance:  " + userAccount.getBalance().ToString();

                    }
                    finally
                    {
                        useMutex.ReleaseMutex();
                    }
                }

            }

        }

        private void btnWithdrawClick(object sender, EventArgs e)
        {
            withdrawPanel.Visible = !withdrawPanel.Visible;
        }

        private void bntWithdraw10Click(object sender, EventArgs e)
        {
            deductAccountBalance(10);
        }
        private void btnWithdraw20Click(object sender, EventArgs e)
        {
            deductAccountBalance(20);

        }
        private void btnWithdraw50Click(object sender, EventArgs e)
        {
            deductAccountBalance(50);
        }

        private void btnWithdraw100Click(object sender, EventArgs e)
        {
            deductAccountBalance(100);
        }

        private void btnWithdraw200Click(object sender, EventArgs e)
        {
            deductAccountBalance(200);
        }

        private void btnWithdraw500Click(object sender, EventArgs e)
        {
            deductAccountBalance(500);
        }

        private void btnSubmitClick(object sender, EventArgs e)
        {
            int userAccNum;
            int userAccPin;

            string inputUserAccNum = txtBoxAccountNumber.Text;
            string inputUserAccPin = txtBoxPinNumber.Text;

            if(string.IsNullOrEmpty(inputUserAccNum) || string.IsNullOrEmpty(inputUserAccPin))
            {
                txtboxEnterDetails.Text = "* Complete All Fields *";
                return;
            }

            if(!int.TryParse(inputUserAccNum, out userAccNum) ) {
                txtboxEnterDetails.Text = "* Invalid Details *";
                return;
            }
            if (!int.TryParse(inputUserAccPin, out userAccPin))
            {
                txtboxEnterDetails.Text = "* Invalid Details *";
                return;
            }

            userAccount = atmProgram.findAccount(userAccNum);
            if(userAccount != null) {
                if (userAccount.checkPin(userAccPin))
                {
                    accountDetailsPanel.Visible = false;
                    bankOptionsPanel.Visible = true;
                    textboxBalance.Text = "Current Balance:  " + userAccount.getBalance().ToString();
                }
                else
                {
                    txtboxEnterDetails.Text = "* Incorrect Details *";
                    return;
                }
            } else
            {
                txtboxEnterDetails.Text = "* Incorrect Details *";
            }
        }

        private void btnReturnCardClick(object sender, EventArgs e)
        {
            bankOptionsPanel.Visible = false;
            accountDetailsPanel.Visible= true;
            txtBoxAccountNumber.Text = "";
            txtBoxPinNumber.Text = "";
        }
    }
}
