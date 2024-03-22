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
using System.Runtime.Remoting.Lifetime;


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

        public void addAccountBalance(int amt)
        {
            lblLastTransaction.Text = "Last Transaction : Added " + amt;
            Thread.Sleep(2000);

            if (isRace)
            {
                if (userAccount.decrementBalance(amt))
                {
                    int balance = userAccount.getBalance();
                    balance += amt;
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
                        balance = balance + amt;
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
            withdrawPanel.Visible = true;
            richTextBox2.Clear();
            WithdrawBtn.Visible = true;
            richTextBox2.AppendText("How much money would you \r\nlike to withdraw?\r\n1) 10    2) 20   3) 50\r\n4) 100  5) 200  6) 500\r\nPRESS CLEAR TO EXIT");

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
                richTextBox1.AppendText("Please enter your account number\r\n* ERROR: COMPLETE ALL FIELDS *");
                return;
            }

            if (!int.TryParse(inputUserAccNum, out userAccNum))
            {
                richTextBox1.Clear();
                txtBox.Clear();
                richTextBox1.AppendText("Please enter your account number\r\n* ERROR: INVALID ACCOUNT NUMBER *");
                return;
            }

            userAccount = atmProgram.findAccount(userAccNum);
            if (userAccount != null)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText("* Please enter your pin number *");
                AccountNumber.AppendText(inputUserAccNum);
                txtBox.Clear();
                btnSubmit.Visible = false;
                btnSubmitPin.Visible = true;
            }
            else
            {
                richTextBox1.Clear();
                txtBox.Clear();
                richTextBox1.AppendText("Please enter your account number\r\n* ERROR: INVALID *");

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
                richTextBox1.AppendText("Please enter your pin number\r\n* ERROR: Please enter a pin number *");
                return;
            }

            if (!int.TryParse(inputUserAccNum, out userAccNum))
            {
                return;
            }
            if (!int.TryParse(inputUserAccPin, out userAccPin))
            {
                richTextBox1.Clear();
                txtBox.Clear();
                richTextBox1.AppendText("Please enter your pin number\r\n* ERROR: Incorrect Pin *");
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
                txtBox.Clear();
                richTextBox1.AppendText("Please enter your pin number\r\n* ERROR: Incorrect Pin *");
                return;
            }
        }


        private void btnReturnCardClick(object sender, EventArgs e)
        {
            bankOptionsPanel.Visible = false;
            accountDetailsPanel.Visible = true;
            richTextBox1.Clear();
            richTextBox1.AppendText("Thank you, goodbye.");
            txtBox.Clear();

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

        private void ExitWithdraw(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.AppendText("Welcome, please select an option:\r\n1) Withdraw Money\r\n2) Add Money\r\n\r\nPress Clear to return card");
            withdrawPanel.Visible = false;
            WithdrawBtn.Visible = false;
        }

        private void add10(object sender, EventArgs e)
        {
            addAccountBalance(10);
        }

        private void add20(object sender, EventArgs e)
        {
            addAccountBalance(20);
        }

        private void add50(object sender, EventArgs e)
        {
            addAccountBalance(50);
        }

        private void add100(object sender, EventArgs e)
        {
            addAccountBalance(100);
        }

        private void add200(object sender, EventArgs e)
        {
            addAccountBalance(200);
        }

        private void add500(object sender, EventArgs e)
        {
            addAccountBalance(500);
        }

        private void ExitAdd(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.AppendText("Welcome, please select an option:\r\n1) Withdraw Money\r\n2) Add Money\r\n\r\nPress Clear to return card");
            addPanel.Visible = false;
            addBtn.Visible = false;
        }

        private void btnAddClick(object sender, EventArgs e)
        {
            addPanel.Visible = true;
            richTextBox2.Clear();
            addBtn.Visible = true;
            richTextBox2.AppendText("How much money would you \r\nlike to add?\r\n1) 10    2) 20   3) 50\r\n4) 100  5) 200  6) 500\r\nPRESS CLEAR TO EXIT");
        }

        private void btnBalanceClick(object sender, EventArgs e)
        {

        }
    }
}
