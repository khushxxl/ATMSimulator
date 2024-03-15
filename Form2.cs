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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void deductAccountBalance(int amt)
        {
            withdrawMoneyText.Text = "Last Transaction : Withdrawn " + amt;
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
                    balanceBoxText.Text = "Current Balance:  " + userAccount.getBalance().ToString();
                    withdrawMoneyText.Visible = false;



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
                        balanceBoxText.Text = "Current Balance:  " + userAccount.getBalance().ToString();

                    }
                    finally
                    {
                        useMutex.ReleaseMutex();
                    }
                }

            }

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
          if(withdrawPanel.Visible == true)
            {
                withdrawPanel.Visible = false;
            }
          
            
           if (withdrawPanel.Visible == false)
            {
                withdrawPanel.Visible = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            deductAccountBalance(10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deductAccountBalance(100);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deductAccountBalance(200);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deductAccountBalance(20);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            deductAccountBalance(50);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            deductAccountBalance(500);
        }

        private void accountDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bankOptionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userAccNum;
            int userAccPin;

            string inputUserAccNum = accountNumberBox.Text;
            string inputUserAccPin = pinNumberBox.Text;

            if(string.IsNullOrEmpty(inputUserAccNum) || string.IsNullOrEmpty(inputUserAccPin))
            {
                detailsBoxResponse.Text = "* Complete All Fields *";
                return;
            }

            if(!int.TryParse(inputUserAccNum, out userAccNum) ) {
                detailsBoxResponse.Text = "* Invalid Details *";
                return;
            }
            if (!int.TryParse(inputUserAccPin, out userAccPin))
            {
                detailsBoxResponse.Text = "* Invalid Details *";
                return;
            }

            userAccount = atmProgram.findAccount(userAccNum);
            if(userAccount != null) {
                if (userAccount.checkPin(userAccPin))
                {
                    accountDetailsPanel.Visible = false;
                    bankOptionsPanel.Visible = true;
                    balanceBoxText.Text = userAccount.getBalance().ToString();
                }
                else
                {
                    detailsBoxResponse.Text = "* Incorrect Details *";
                    return;
                }
            }
        }
    }
}
