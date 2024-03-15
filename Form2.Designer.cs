namespace ATMSimulator
{
    partial class SimulatorOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorOptions));
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.accountDetailsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pinNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsBoxResponse = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.balanceBoxText = new System.Windows.Forms.TextBox();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.buttonMoney500 = new System.Windows.Forms.Button();
            this.buttonMoney200 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.buttonMoney50 = new System.Windows.Forms.Button();
            this.buttonMoney20 = new System.Windows.Forms.Button();
            this.buttonMoney10 = new System.Windows.Forms.Button();
            this.bankOptionsPanel = new System.Windows.Forms.Panel();
            this.withdrawMoneyText = new System.Windows.Forms.Label();
            this.accountDetailsPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.bankOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberBox.Location = new System.Drawing.Point(203, 142);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(288, 34);
            this.accountNumberBox.TabIndex = 1;
            this.accountNumberBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // accountDetailsPanel
            // 
            this.accountDetailsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountDetailsPanel.BackgroundImage")));
            this.accountDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountDetailsPanel.Controls.Add(this.button1);
            this.accountDetailsPanel.Controls.Add(this.label2);
            this.accountDetailsPanel.Controls.Add(this.pinNumberBox);
            this.accountDetailsPanel.Controls.Add(this.label1);
            this.accountDetailsPanel.Controls.Add(this.detailsBoxResponse);
            this.accountDetailsPanel.Controls.Add(this.accountNumberBox);
            this.accountDetailsPanel.ForeColor = System.Drawing.Color.Crimson;
            this.accountDetailsPanel.Location = new System.Drawing.Point(67, 44);
            this.accountDetailsPanel.Name = "accountDetailsPanel";
            this.accountDetailsPanel.Size = new System.Drawing.Size(670, 392);
            this.accountDetailsPanel.TabIndex = 2;
            this.accountDetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountDetailsPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Account PIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pinNumberBox
            // 
            this.pinNumberBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinNumberBox.Location = new System.Drawing.Point(203, 207);
            this.pinNumberBox.Name = "pinNumberBox";
            this.pinNumberBox.Size = new System.Drawing.Size(288, 34);
            this.pinNumberBox.TabIndex = 3;
            this.pinNumberBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Account Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // detailsBoxResponse
            // 
            this.detailsBoxResponse.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsBoxResponse.Location = new System.Drawing.Point(222, 25);
            this.detailsBoxResponse.Name = "detailsBoxResponse";
            this.detailsBoxResponse.Size = new System.Drawing.Size(253, 34);
            this.detailsBoxResponse.TabIndex = 0;
            this.detailsBoxResponse.Text = "Enter your Details";
            this.detailsBoxResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.detailsBoxResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(238, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 34);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Banking Options";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(171, 147);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(150, 44);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(399, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Return Card";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // balanceBoxText
            // 
            this.balanceBoxText.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBoxText.Location = new System.Drawing.Point(238, 77);
            this.balanceBoxText.Name = "balanceBoxText";
            this.balanceBoxText.Size = new System.Drawing.Size(253, 34);
            this.balanceBoxText.TabIndex = 4;
            this.balanceBoxText.Text = "Current Balance : 100";
            this.balanceBoxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balanceBoxText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("withdrawPanel.BackgroundImage")));
            this.withdrawPanel.Controls.Add(this.buttonMoney500);
            this.withdrawPanel.Controls.Add(this.buttonMoney200);
            this.withdrawPanel.Controls.Add(this.button100);
            this.withdrawPanel.Controls.Add(this.buttonMoney50);
            this.withdrawPanel.Controls.Add(this.buttonMoney20);
            this.withdrawPanel.Controls.Add(this.buttonMoney10);
            this.withdrawPanel.Location = new System.Drawing.Point(156, 231);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(415, 154);
            this.withdrawPanel.TabIndex = 5;
            this.withdrawPanel.Visible = false;
            this.withdrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonMoney500
            // 
            this.buttonMoney500.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney500.Location = new System.Drawing.Point(309, 75);
            this.buttonMoney500.Name = "buttonMoney500";
            this.buttonMoney500.Size = new System.Drawing.Size(84, 36);
            this.buttonMoney500.TabIndex = 11;
            this.buttonMoney500.Text = "500";
            this.buttonMoney500.UseVisualStyleBackColor = true;
            this.buttonMoney500.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonMoney200
            // 
            this.buttonMoney200.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney200.Location = new System.Drawing.Point(166, 75);
            this.buttonMoney200.Name = "buttonMoney200";
            this.buttonMoney200.Size = new System.Drawing.Size(84, 36);
            this.buttonMoney200.TabIndex = 10;
            this.buttonMoney200.Text = "200";
            this.buttonMoney200.UseVisualStyleBackColor = true;
            this.buttonMoney200.Click += new System.EventHandler(this.button8_Click);
            // 
            // button100
            // 
            this.button100.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button100.Location = new System.Drawing.Point(15, 75);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(84, 36);
            this.button100.TabIndex = 9;
            this.button100.Text = "100";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonMoney50
            // 
            this.buttonMoney50.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney50.Location = new System.Drawing.Point(309, 10);
            this.buttonMoney50.Name = "buttonMoney50";
            this.buttonMoney50.Size = new System.Drawing.Size(84, 36);
            this.buttonMoney50.TabIndex = 8;
            this.buttonMoney50.Text = "50";
            this.buttonMoney50.UseVisualStyleBackColor = true;
            this.buttonMoney50.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonMoney20
            // 
            this.buttonMoney20.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney20.Location = new System.Drawing.Point(166, 10);
            this.buttonMoney20.Name = "buttonMoney20";
            this.buttonMoney20.Size = new System.Drawing.Size(84, 36);
            this.buttonMoney20.TabIndex = 7;
            this.buttonMoney20.Text = "20";
            this.buttonMoney20.UseVisualStyleBackColor = true;
            this.buttonMoney20.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonMoney10
            // 
            this.buttonMoney10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney10.Location = new System.Drawing.Point(15, 10);
            this.buttonMoney10.Name = "buttonMoney10";
            this.buttonMoney10.Size = new System.Drawing.Size(84, 36);
            this.buttonMoney10.TabIndex = 6;
            this.buttonMoney10.Text = "10";
            this.buttonMoney10.UseVisualStyleBackColor = true;
            this.buttonMoney10.Click += new System.EventHandler(this.button3_Click);
            // 
            // bankOptionsPanel
            // 
            this.bankOptionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bankOptionsPanel.BackgroundImage")));
            this.bankOptionsPanel.Controls.Add(this.withdrawMoneyText);
            this.bankOptionsPanel.Controls.Add(this.withdrawPanel);
            this.bankOptionsPanel.Controls.Add(this.balanceBoxText);
            this.bankOptionsPanel.Controls.Add(this.button4);
            this.bankOptionsPanel.Controls.Add(this.withdrawButton);
            this.bankOptionsPanel.Controls.Add(this.textBox2);
            this.bankOptionsPanel.Location = new System.Drawing.Point(67, 26);
            this.bankOptionsPanel.Name = "bankOptionsPanel";
            this.bankOptionsPanel.Size = new System.Drawing.Size(665, 392);
            this.bankOptionsPanel.TabIndex = 6;
            this.bankOptionsPanel.Visible = false;
            this.bankOptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bankOptionsPanel_Paint);
            // 
            // withdrawMoneyText
            // 
            this.withdrawMoneyText.AutoSize = true;
            this.withdrawMoneyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawMoneyText.Location = new System.Drawing.Point(267, 204);
            this.withdrawMoneyText.Name = "withdrawMoneyText";
            this.withdrawMoneyText.Size = new System.Drawing.Size(194, 18);
            this.withdrawMoneyText.TabIndex = 6;
            this.withdrawMoneyText.Text = "Last Transaction : None ";
            this.withdrawMoneyText.UseWaitCursor = true;
            this.withdrawMoneyText.Click += new System.EventHandler(this.label3_Click);
            // 
            // SimulatorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bankOptionsPanel);
            this.Controls.Add(this.accountDetailsPanel);
            this.Name = "SimulatorOptions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.accountDetailsPanel.ResumeLayout(false);
            this.accountDetailsPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.bankOptionsPanel.ResumeLayout(false);
            this.bankOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.Panel accountDetailsPanel;
        private System.Windows.Forms.TextBox detailsBoxResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pinNumberBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox balanceBoxText;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Button buttonMoney500;
        private System.Windows.Forms.Button buttonMoney200;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button buttonMoney50;
        private System.Windows.Forms.Button buttonMoney20;
        private System.Windows.Forms.Button buttonMoney10;
        private System.Windows.Forms.Panel bankOptionsPanel;
        private System.Windows.Forms.Label withdrawMoneyText;
    }
}