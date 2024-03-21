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

        public SimulatorOptions(ATMProgram program, bool isRace)
        {
            this.atmProgram = program;
            InitializeComponent();
            accountDetailsPanel.Visible = true;
            richTextBox1.AppendText("Please enter your account number");
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
            richTextBox1.Clear();
            richTextBox1.AppendText("How much money would you like to deposit?");

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

            string inputUserAccNum = txtBox.Text;


            if (string.IsNullOrEmpty(inputUserAccNum))
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your account number");
                richTextBox1.AppendText(Environment.NewLine + "* COMLPETE ALL FIELDS *");
                return;
            }

            if (!int.TryParse(inputUserAccNum, out userAccNum))
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your account number");
                richTextBox1.AppendText(Environment.NewLine + "* INVALID DETAILS *");
                return;
            }

            userAccount = atmProgram.findAccount(userAccNum);
            if (userAccount != null)
            {

                richTextBox1.AppendText("* Please Enter Pin *");
                AccountNumber.AppendText(inputUserAccNum);
                txtBox.Clear();
                btnSubmit.Visible = false;
                btnSubmitPin.Visible = true;
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your pin number");
                richTextBox1.AppendText(Environment.NewLine + "* INVALID DETAILS *");
                return;
            }
        }

        private void btnSubmitClickPin(object sender, EventArgs e)
        {
            int userAccPin;
            int userAccNum;

            string inputUserAccNum = AccountNumber.Text;
            string inputUserAccPin = txtBox.Text;

            if (string.IsNullOrEmpty(inputUserAccPin))
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your pin number");
                richTextBox1.AppendText(Environment.NewLine + "* COMPLETE ALL FIELDS *");
                return;
            }

            if (!int.TryParse(inputUserAccNum, out userAccNum))
            {
                return;
            }
            if (!int.TryParse(inputUserAccPin, out userAccPin))
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your pin number");
                richTextBox1.AppendText(Environment.NewLine + "* INVALID DETAILS *");
                return;
            }

            userAccount = atmProgram.findAccount(userAccNum);

            if (userAccount.checkPin(userAccPin))
            {
                bankOptionsPanel.Visible = true;
                textboxBalance.Text = "Current Balance:  " + userAccount.getBalance().ToString();
            }
            else
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("Please enter your pin number");
                richTextBox1.AppendText(Environment.NewLine + "* INVALID DETAILS *");
                return;
            }
        }


        private void btnReturnCardClick(object sender, EventArgs e)
        {
            bankOptionsPanel.Visible = false;
            accountDetailsPanel.Visible = true;
            richTextBox1.AppendText("Please enter your account number");

        }

        private void txtboxEnterDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnClearClick(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void Btn1Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void Btn2Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void Btn3Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void Btn4Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void Btn5Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void Btn6Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void Btn7Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void Btn8Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void Btn9Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void Btn0Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SimulatorOptions_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastTransaction_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void withdrawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
