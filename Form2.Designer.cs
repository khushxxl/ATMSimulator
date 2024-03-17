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
            this.txtBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.accountDetailsPanel = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtBoxPinNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtboxEnterDetails = new System.Windows.Forms.TextBox();
            this.txtboxBankingOptions = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnReturnCard = new System.Windows.Forms.Button();
            this.textboxBalance = new System.Windows.Forms.TextBox();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.btnWithdraw500 = new System.Windows.Forms.Button();
            this.btnWithdraw200 = new System.Windows.Forms.Button();
            this.btnWithdraw100 = new System.Windows.Forms.Button();
            this.btnWithdraw50 = new System.Windows.Forms.Button();
            this.btnWithdraw20 = new System.Windows.Forms.Button();
            this.btnWithdraw10 = new System.Windows.Forms.Button();
            this.bankOptionsPanel = new System.Windows.Forms.Panel();
            this.lblLastTransaction = new System.Windows.Forms.Label();
            this.accountDetailsPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.bankOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNumberBox
            // 
            this.txtBoxAccountNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAccountNumber.Location = new System.Drawing.Point(406, 273);
            this.txtBoxAccountNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxAccountNumber.Name = "accountNumberBox";
            this.txtBoxAccountNumber.Size = new System.Drawing.Size(572, 61);
            this.txtBoxAccountNumber.TabIndex = 1;
            // 
            // accountDetailsPanel
            // 
            this.accountDetailsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accountDetailsPanel.BackgroundImage")));
            this.accountDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountDetailsPanel.Controls.Add(this.btnSubmit);
            this.accountDetailsPanel.Controls.Add(this.lblPin);
            this.accountDetailsPanel.Controls.Add(this.txtBoxPinNumber);
            this.accountDetailsPanel.Controls.Add(this.lblAccountNumber);
            this.accountDetailsPanel.Controls.Add(this.txtboxEnterDetails);
            this.accountDetailsPanel.Controls.Add(this.txtBoxAccountNumber);
            this.accountDetailsPanel.ForeColor = System.Drawing.Color.Crimson;
            this.accountDetailsPanel.Location = new System.Drawing.Point(134, 85);
            this.accountDetailsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.accountDetailsPanel.Name = "accountDetailsPanel";
            this.accountDetailsPanel.Size = new System.Drawing.Size(1336, 750);
            this.accountDetailsPanel.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(538, 627);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(308, 71);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitClick);
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.BackColor = System.Drawing.Color.Transparent;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPin.Location = new System.Drawing.Point(48, 412);
            this.lblPin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(279, 36);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = "Enter Account PIN";
            // 
            // txtBoxPinNumber
            // 
            this.txtBoxPinNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPinNumber.Location = new System.Drawing.Point(406, 398);
            this.txtBoxPinNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxPinNumber.Name = "txtBoxPinNumber";
            this.txtBoxPinNumber.Size = new System.Drawing.Size(572, 61);
            this.txtBoxPinNumber.TabIndex = 3;
            this.txtBoxPinNumber.PasswordChar = '*';
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountNumber.Location = new System.Drawing.Point(34, 287);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(337, 36);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Enter Account Number";
            // 
            // txtboxEnterDetails
            // 
            this.txtboxEnterDetails.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEnterDetails.Location = new System.Drawing.Point(444, 48);
            this.txtboxEnterDetails.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxEnterDetails.Name = "txtboxEnterDetails";
            this.txtboxEnterDetails.ReadOnly = true;
            this.txtboxEnterDetails.Size = new System.Drawing.Size(502, 61);
            this.txtboxEnterDetails.TabIndex = 0;
            this.txtboxEnterDetails.Text = "Enter your Details";
            this.txtboxEnterDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtboxBankingOptions
            // 
            this.txtboxBankingOptions.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBankingOptions.Location = new System.Drawing.Point(476, 48);
            this.txtboxBankingOptions.Margin = new System.Windows.Forms.Padding(6);
            this.txtboxBankingOptions.Name = "txtboxBankingOptions";
            this.txtboxBankingOptions.ReadOnly = true;
            this.txtboxBankingOptions.Size = new System.Drawing.Size(502, 61);
            this.txtboxBankingOptions.TabIndex = 0;
            this.txtboxBankingOptions.Text = "Banking Options";
            this.txtboxBankingOptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(342, 283);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(300, 85);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdrawClick);
            // 
            // btnReturnCard
            // 
            this.btnReturnCard.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCard.Location = new System.Drawing.Point(798, 285);
            this.btnReturnCard.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturnCard.Name = "btnReturnCard";
            this.btnReturnCard.Size = new System.Drawing.Size(300, 85);
            this.btnReturnCard.TabIndex = 3;
            this.btnReturnCard.Text = "Return Card";
            this.btnReturnCard.UseVisualStyleBackColor = true;
            this.btnReturnCard.Click += new System.EventHandler(this.btnReturnCardClick);
            // 
            // textboxBalance
            // 
            this.textboxBalance.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxBalance.Location = new System.Drawing.Point(476, 148);
            this.textboxBalance.Margin = new System.Windows.Forms.Padding(6);
            this.textboxBalance.Name = "textboxBalance";
            this.textboxBalance.Size = new System.Drawing.Size(502, 61);
            this.textboxBalance.TabIndex = 4;
            this.textboxBalance.Text = "Current Balance : 100";
            this.textboxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("withdrawPanel.BackgroundImage")));
            this.withdrawPanel.Controls.Add(this.btnWithdraw500);
            this.withdrawPanel.Controls.Add(this.btnWithdraw200);
            this.withdrawPanel.Controls.Add(this.btnWithdraw100);
            this.withdrawPanel.Controls.Add(this.btnWithdraw50);
            this.withdrawPanel.Controls.Add(this.btnWithdraw20);
            this.withdrawPanel.Controls.Add(this.btnWithdraw10);
            this.withdrawPanel.Location = new System.Drawing.Point(312, 444);
            this.withdrawPanel.Margin = new System.Windows.Forms.Padding(6);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(830, 296);
            this.withdrawPanel.TabIndex = 5;
            this.withdrawPanel.Visible = false;
            // 
            // btnWithdraw500
            // 
            this.btnWithdraw500.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw500.Location = new System.Drawing.Point(618, 144);
            this.btnWithdraw500.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw500.Name = "btnWithdraw500";
            this.btnWithdraw500.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw500.TabIndex = 11;
            this.btnWithdraw500.Text = "500";
            this.btnWithdraw500.UseVisualStyleBackColor = true;
            this.btnWithdraw500.Click += new System.EventHandler(this.btnWithdraw500Click);
            // 
            // btnWithdraw200
            // 
            this.btnWithdraw200.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw200.Location = new System.Drawing.Point(332, 144);
            this.btnWithdraw200.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw200.Name = "btnWithdraw200";
            this.btnWithdraw200.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw200.TabIndex = 10;
            this.btnWithdraw200.Text = "200";
            this.btnWithdraw200.UseVisualStyleBackColor = true;
            this.btnWithdraw200.Click += new System.EventHandler(this.btnWithdraw200Click);
            // 
            // btnWithdraw100
            // 
            this.btnWithdraw100.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw100.Location = new System.Drawing.Point(30, 144);
            this.btnWithdraw100.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw100.Name = "btnWithdraw100";
            this.btnWithdraw100.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw100.TabIndex = 9;
            this.btnWithdraw100.Text = "100";
            this.btnWithdraw100.UseVisualStyleBackColor = true;
            this.btnWithdraw100.Click += new System.EventHandler(this.btnWithdraw100Click);
            // 
            // btnWithdraw50
            // 
            this.btnWithdraw50.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw50.Location = new System.Drawing.Point(618, 19);
            this.btnWithdraw50.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw50.Name = "btnWithdraw50";
            this.btnWithdraw50.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw50.TabIndex = 8;
            this.btnWithdraw50.Text = "50";
            this.btnWithdraw50.UseVisualStyleBackColor = true;
            this.btnWithdraw50.Click += new System.EventHandler(this.btnWithdraw50Click);
            // 
            // btnWithdraw20
            // 
            this.btnWithdraw20.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw20.Location = new System.Drawing.Point(332, 19);
            this.btnWithdraw20.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw20.Name = "btnWithdraw20";
            this.btnWithdraw20.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw20.TabIndex = 7;
            this.btnWithdraw20.Text = "20";
            this.btnWithdraw20.UseVisualStyleBackColor = true;
            this.btnWithdraw20.Click += new System.EventHandler(this.btnWithdraw20Click);
            // 
            // btnWithdraw10
            // 
            this.btnWithdraw10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw10.Location = new System.Drawing.Point(30, 19);
            this.btnWithdraw10.Margin = new System.Windows.Forms.Padding(6);
            this.btnWithdraw10.Name = "btnWithdraw10";
            this.btnWithdraw10.Size = new System.Drawing.Size(168, 69);
            this.btnWithdraw10.TabIndex = 6;
            this.btnWithdraw10.Text = "10";
            this.btnWithdraw10.UseVisualStyleBackColor = true;
            this.btnWithdraw10.Click += new System.EventHandler(this.bntWithdraw10Click);
            // 
            // bankOptionsPanel
            // 
            this.bankOptionsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bankOptionsPanel.BackgroundImage")));
            this.bankOptionsPanel.Controls.Add(this.lblLastTransaction);
            this.bankOptionsPanel.Controls.Add(this.withdrawPanel);
            this.bankOptionsPanel.Controls.Add(this.textboxBalance);
            this.bankOptionsPanel.Controls.Add(this.btnReturnCard);
            this.bankOptionsPanel.Controls.Add(this.btnWithdraw);
            this.bankOptionsPanel.Controls.Add(this.txtboxBankingOptions);
            this.bankOptionsPanel.Location = new System.Drawing.Point(134, 50);
            this.bankOptionsPanel.Margin = new System.Windows.Forms.Padding(6);
            this.bankOptionsPanel.Name = "bankOptionsPanel";
            this.bankOptionsPanel.Size = new System.Drawing.Size(1330, 754);
            this.bankOptionsPanel.TabIndex = 6;
            this.bankOptionsPanel.Visible = false;
            // 
            // lblLastTransaction
            // 
            this.lblLastTransaction.AutoSize = true;
            this.lblLastTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTransaction.Location = new System.Drawing.Point(534, 392);
            this.lblLastTransaction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastTransaction.Name = "lblLastTransaction";
            this.lblLastTransaction.Size = new System.Drawing.Size(363, 36);
            this.lblLastTransaction.TabIndex = 6;
            this.lblLastTransaction.Text = "Last Transaction : None ";
            this.lblLastTransaction.UseWaitCursor = true;
            // 
            // SimulatorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.bankOptionsPanel);
            this.Controls.Add(this.accountDetailsPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SimulatorOptions";
            this.accountDetailsPanel.ResumeLayout(false);
            this.accountDetailsPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.bankOptionsPanel.ResumeLayout(false);
            this.bankOptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAccountNumber;
        private System.Windows.Forms.Panel accountDetailsPanel;
        private System.Windows.Forms.TextBox txtboxEnterDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtBoxPinNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxBankingOptions;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnReturnCard;
        private System.Windows.Forms.TextBox textboxBalance;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Button btnWithdraw500;
        private System.Windows.Forms.Button btnWithdraw200;
        private System.Windows.Forms.Button btnWithdraw100;
        private System.Windows.Forms.Button btnWithdraw50;
        private System.Windows.Forms.Button btnWithdraw20;
        private System.Windows.Forms.Button btnWithdraw10;
        private System.Windows.Forms.Panel bankOptionsPanel;
        private System.Windows.Forms.Label lblLastTransaction;
    }
}