﻿namespace ATMSimulator
{
    partial class Form1
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
            this.btnRaceCondition = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.raceBox = new System.Windows.Forms.Label();
            this.lblBankOfDundee = new System.Windows.Forms.Label();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.pinSetBox = new System.Windows.Forms.TextBox();
            this.accSetBox = new System.Windows.Forms.TextBox();
            this.lblOpenAccount = new System.Windows.Forms.Label();
            this.accountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRaceCondition
            // 
            this.btnRaceCondition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRaceCondition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaceCondition.ForeColor = System.Drawing.Color.White;
            this.btnRaceCondition.Location = new System.Drawing.Point(95, 173);
            this.btnRaceCondition.Name = "btnRaceCondition";
            this.btnRaceCondition.Size = new System.Drawing.Size(259, 53);
            this.btnRaceCondition.TabIndex = 1;
            this.btnRaceCondition.Text = "Run Race Condition";
            this.btnRaceCondition.UseVisualStyleBackColor = false;
            this.btnRaceCondition.Click += new System.EventHandler(this.btnRaceConditionClick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(480, 173);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(259, 53);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // raceBox
            // 
            this.raceBox.AutoSize = true;
            this.raceBox.BackColor = System.Drawing.Color.Transparent;
            this.raceBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBox.ForeColor = System.Drawing.SystemColors.Control;
            this.raceBox.Location = new System.Drawing.Point(300, 401);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(241, 23);
            this.raceBox.TabIndex = 3;
            this.raceBox.Text = "Application with Race Condition";
            // 
            // lblBankOfDundee
            // 
            this.lblBankOfDundee.AutoSize = true;
            this.lblBankOfDundee.BackColor = System.Drawing.Color.Transparent;
            this.lblBankOfDundee.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankOfDundee.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblBankOfDundee.Location = new System.Drawing.Point(277, 28);
            this.lblBankOfDundee.Name = "lblBankOfDundee";
            this.lblBankOfDundee.Size = new System.Drawing.Size(258, 37);
            this.lblBankOfDundee.TabIndex = 4;
            this.lblBankOfDundee.Text = "Bank of Dundee";
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenAccount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAccount.ForeColor = System.Drawing.Color.White;
            this.btnOpenAccount.Location = new System.Drawing.Point(282, 254);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(259, 53);
            this.btnOpenAccount.TabIndex = 5;
            this.btnOpenAccount.Text = "Open an Account";
            this.btnOpenAccount.UseVisualStyleBackColor = false;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccountClick);
            // 
            // accountPanel
            // 
            this.accountPanel.BackgroundImage = global::ATMSimulator.Properties.Resources.Gotham;
            this.accountPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountPanel.Controls.Add(this.btnBack);
            this.accountPanel.Controls.Add(this.btnRegister);
            this.accountPanel.Controls.Add(this.lblPin);
            this.accountPanel.Controls.Add(this.lblAccountNumber);
            this.accountPanel.Controls.Add(this.pinSetBox);
            this.accountPanel.Controls.Add(this.accSetBox);
            this.accountPanel.Controls.Add(this.lblOpenAccount);
            this.accountPanel.Location = new System.Drawing.Point(65, 86);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(674, 338);
            this.accountPanel.TabIndex = 6;
            this.accountPanel.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(12, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(255, 302);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(163, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Complete Registeration";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegisterClick);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.Color.Transparent;
            this.lblPin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPin.Location = new System.Drawing.Point(36, 190);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(63, 19);
            this.lblPin.TabIndex = 11;
            this.lblPin.Text = "Set Pin";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountNumber.Location = new System.Drawing.Point(36, 142);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(188, 19);
            this.lblAccountNumber.TabIndex = 10;
            this.lblAccountNumber.Text = "Account Number (Auto)";
            // 
            // pinSetBox
            // 
            this.pinSetBox.Location = new System.Drawing.Point(230, 189);
            this.pinSetBox.Name = "pinSetBox";
            this.pinSetBox.Size = new System.Drawing.Size(211, 20);
            this.pinSetBox.TabIndex = 9;
            this.pinSetBox.TextChanged += new System.EventHandler(this.pinSetBox_TextChanged);
            // 
            // accSetBox
            // 
            this.accSetBox.Enabled = false;
            this.accSetBox.Location = new System.Drawing.Point(230, 142);
            this.accSetBox.Name = "accSetBox";
            this.accSetBox.Size = new System.Drawing.Size(211, 20);
            this.accSetBox.TabIndex = 8;
            // 
            // lblOpenAccount
            // 
            this.lblOpenAccount.AutoSize = true;
            this.lblOpenAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenAccount.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenAccount.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblOpenAccount.Location = new System.Drawing.Point(142, 47);
            this.lblOpenAccount.Name = "lblOpenAccount";
            this.lblOpenAccount.Size = new System.Drawing.Size(398, 37);
            this.lblOpenAccount.TabIndex = 7;
            this.lblOpenAccount.Text = "Open an Account with us";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATMSimulator.Properties.Resources.Gotham;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 448);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.lblBankOfDundee);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btnRaceCondition);
            this.Location = new System.Drawing.Point(20, 30);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank of Dundee";
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRaceCondition;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label raceBox;
        private System.Windows.Forms.Label lblBankOfDundee;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label lblOpenAccount;
        private System.Windows.Forms.TextBox accSetBox;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox pinSetBox;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
    }
}

